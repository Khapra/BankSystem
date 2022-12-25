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
    public partial class DepositForm : Form
    {
        private SummaryForm parentForm;
        private ChequingAccount currentCheqAcc;
        private SavingAccount currentSaveAcc;

        public DepositForm(SummaryForm parentForm, ChequingAccount currentCheqAcc, SavingAccount currentSaveAcc)
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

        private void Deposit_button_Click(object sender, EventArgs e)
        {
            if (!(float.TryParse(this.txt_Amount.Text, out float amount)))
            {
                MessageBox.Show("Invalid amount");
                return;
            }
            
            if (amount < 0)
            {
                MessageBox.Show("Invalid amount");
                return;
            }

            if (
                MessageBox.Show(
                    $"Are you sure you would like to deposit ${(Math.Round(amount * 100f) / 100f).ToString()} ?",
                    "Confirmation", 
                    MessageBoxButtons.OKCancel) != DialogResult.OK
            ) { return; }

            bool flag;
            if (this.checkChequing.Checked)
            {
                flag = this.currentCheqAcc.Deposit(amount);
            } 
            else
            {
                flag = this.currentSaveAcc.Deposit(amount);
            }

            if (flag == true)
            {
                MessageBox.Show("Deposit Successful");
                
                this.Hide();
                this.parentForm.RefreshSummary();
                this.parentForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Deposit Unsuccessful");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.parentForm.Show();
            this.parentForm.RefreshSummary();
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.button1.PerformClick();
            }

            if (keyData == Keys.Enter)
            {
                this.Deposit_button.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
