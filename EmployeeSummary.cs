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
    public partial class EmployeeSummary : SummaryForm
    {
        public EmployeeSummary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        protected Operator currentOperator { get; set; }
        protected ChequingAccount currentChequingAccount { get; set; }
        protected SavingAccount currentSavingAccount { get; set; }
        protected LoginForm parentForm { get; set; }
        protected bool logout { get; set; } = false;
        public EmployeeSummary(LoginForm parentForm, Operator loggedInOperator)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            this.currentOperator = loggedInOperator;
            if (this.currentOperator is Client)
            {
                this.currentChequingAccount = loggedInOperator.GetChequingAccount();
                this.currentSavingAccount = loggedInOperator.GetSavingAccount();
            }

            if (this.currentOperator is Employee)
            {
                this.openCreateForm.Visible = true;

            }

            this.RefreshSummary();

            this.welcomeUser.Text = $"Welcome, {loggedInOperator.GetUsername()}";
        }

        public void RefreshSummary()
        {
            if (currentChequingAccount != null)
            {
                this.cheqAccNumberLabel.Text = this.currentChequingAccount.GetNumber();
                this.cheqBalanceLabel.Text = this.currentChequingAccount.GetBalance();
            }
            else
            {
                this.cheqAccNumberLabel.Text = this.cheqBalanceLabel.Text = "N/A";
            }

            if (currentSavingAccount != null)
            {
                this.saveAccNumberLabel.Text = this.currentSavingAccount.GetNumber();
                this.saveBalanceLabel.Text = this.currentSavingAccount.GetBalance();
            }
            else
            {
                this.saveAccNumberLabel.Text = this.saveBalanceLabel.Text = "N/A";
            }

            return;
        }

        private void openDepositForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositForm depositForm = new DepositForm(this, this.currentChequingAccount, this.currentSavingAccount);
            depositForm.ShowDialog();
        }

        private void openWithdrawForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawForm withdrawForm = new WithdrawForm(this, this.currentChequingAccount, this.currentSavingAccount);
            withdrawForm.ShowDialog();
        }

        private void openTransferForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferForm withdrawForm = new TransferForm(this, this.currentChequingAccount, this.currentSavingAccount);
            withdrawForm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.logout = true;
            this.Hide();
            this.parentForm.Show();
            this.Close();
        }

        private void openCreateForm_Click(object sender, EventArgs e)
        {

        }

        private void SummaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (this.logout)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    Application.Exit();
                }
            }
        }

        private void viewChequingTransaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTransactionForm viewTransactionForm = new ViewTransactionForm(this, this.currentChequingAccount);
            viewTransactionForm.ShowDialog();
        }

        private void viewSavingTransaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTransactionForm viewTransactionForm = new ViewTransactionForm(this, this.currentSavingAccount);
            viewTransactionForm.ShowDialog();
        }
    }
}
