using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class TransferForm : Form
    {
        private SummaryForm parentForm;
        private ChequingAccount currentCheqAcc;
        private SavingAccount currentSaveAcc;

        public TransferForm(SummaryForm parentForm, ChequingAccount currentCheqAcc, SavingAccount currentSaveAcc)
        {
            this.parentForm = parentForm;
            this.currentCheqAcc = currentCheqAcc;
            this.currentSaveAcc = currentSaveAcc;

            InitializeComponent();

            if (this.currentCheqAcc == null) { this.checkChequing.Enabled = false; }
            else { this.chequingBalance.Text = this.currentCheqAcc.GetBalance().ToString(); }

            if (this.currentSaveAcc == null) { this.checkSaving.Enabled = false; }
            else { this.savingBalance.Text = this.currentSaveAcc.GetBalance().ToString(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.parentForm.Show();
            this.parentForm.RefreshSummary();
            this.Close();
        }

        private void Transfer_button_Click(object sender, EventArgs e)
        {
            if (!(float.TryParse(this.txt_Amount.Text, out float amount)))
            {
                MessageBox.Show("Invalid amount");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Invalid amount");
                return;
            }

            if (Database.GetAccount(this.txt_receiverAccount.Text) == null)
            {
                MessageBox.Show("Invalid receiver account number");
                return;
            }

            bool flag;
            if (this.checkChequing.Checked)
            {
                if (
                MessageBox.Show(
                    $"Are you sure you would like to proceed ?\n\n" +
                    $"Receiver : {Database.GetAccount(txt_receiverAccount.Text).GetOwner()}\n" +
                    $"Receiver Account Number : {txt_receiverAccount.Text}\n" +
                    $"Your Chequing account balance after this action: " +
                    $"${(Math.Round((float.Parse(this.currentCheqAcc.GetBalance()) - amount) * 100f) / 100f).ToString()}",
                    "Confirmation",
                    MessageBoxButtons.OKCancel) != DialogResult.OK
                ) { return; }

                flag = this.currentCheqAcc.Transfer(amount, this.txt_receiverAccount.Text);
            }
            else
            {
                if (
                MessageBox.Show(
                    $"Are you sure you would like to proceed ?\n\n" +
                    $"Receiver : {Database.GetAccount(txt_receiverAccount.Text).GetOwner()}\n" +
                    $"Receiver Account Number : {txt_receiverAccount.Text}\n" +
                    $"Your Saving account balance after this action: " +
                    $"${(Math.Round((float.Parse(this.currentSaveAcc.GetBalance()) - amount) * 100f) / 100f).ToString()}",
                    "Confirmation",
                    MessageBoxButtons.OKCancel) != DialogResult.OK
                ) { return; }

                flag = this.currentSaveAcc.Transfer(amount, this.txt_receiverAccount.Text);
            }

            if (flag == true)
            {
                System.Windows.Forms.MessageBox.Show("Transfer Successful");

                this.Hide();
                this.parentForm.RefreshSummary();
                this.parentForm.Show();
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Transfer Unsuccessful");
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.button1.PerformClick();
            }

            if (keyData == Keys.Enter)
            {
                this.Transfer_button.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
