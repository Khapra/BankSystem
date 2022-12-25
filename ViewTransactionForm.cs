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
    public partial class ViewTransactionForm : Form
    {
        protected SummaryForm parentForm;
        protected Account currentAccount;

        public ViewTransactionForm(SummaryForm parentForm, Account currentAccount)
        {
            this.parentForm = parentForm;
            this.currentAccount = currentAccount;
            
            InitializeComponent();
            this.startDate.ValueChanged += (s, args) =>
            {
                this.endDate.MinDate = this.startDate.Value;
            };
            this.endDate.ValueChanged += (s, args) =>
            {
                this.startDate.MaxDate = this.endDate.Value;
            };

            this.ResetDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.parentForm.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedItem.ToString() == "Transaction Date")
            {
                this.startDate.Visible = true;
                this.endDate.Visible = true;
                this.label3.Visible = true;
                this.label4.Visible = true;
                this.searchValue.Visible = false;
            }
            else
            {
                this.startDate.Visible = false;
                this.endDate.Visible = false;
                this.label3.Visible = false;
                this.label4.Visible = false;
                this.searchValue.Visible = true;
            }
        }

        private void PopulateDataGridView(Transaction[] transactions)
        {
            this.dataGridView1.Rows.Clear();

            foreach (var transaction in transactions)
            {
                string[] entry = transaction.ToQuery();
                this.dataGridView1.Rows.Add(new object[] { 
                    entry[0],
                    entry[1],
                    entry[2],
                    entry[3],
                    entry[4],
                    entry[5]
                });
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Convert the search key obtained from the combo box
            // into camelCase format
            if (this.comboBox1.SelectedIndex == 0)
            {
                this.ResetDataGridView();
                return;
            }

            string[] originalKey = this.comboBox1.SelectedItem.ToString().Split(' ');
            originalKey[0] = originalKey[0].ToLower();
            string key = string.Join("", originalKey);

            Transaction[] result = { };

            if (key.Equals("transactionDate"))
            {
                result = Database.GetTransactions(
                    this.currentAccount.GetNumber(),
                    key,
                    this.startDate.Value.ToString(),
                    this.endDate.Value.ToString()
                );
            }
            else
            {
                result = Database.GetTransactions(
                    this.currentAccount.GetNumber(),
                    key,
                    this.searchValue.Text
                );
            }

            this.PopulateDataGridView(result);
        }
        private void ResetDataGridView()
        {
            this.PopulateDataGridView(Database.GetTransactions(this.currentAccount.GetNumber()));
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.button1.PerformClick();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
