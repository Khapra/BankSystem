using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace BankSystem
{
    public partial class LoginForm : Form
    {
        static public int tries = 3;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            Operator retrievedOperator = Database.GetOperator("username", username);
            
            // Check if the operator exists
            if (retrievedOperator is null)
            {
                MessageBox.Show("Invalid credentials entered. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the operator's access flag is on
            if (retrievedOperator is Client && ((Client)retrievedOperator).CheckFlag() == false)
            {
                MessageBox.Show("Your user account has been locked for security reasons. Please contact our employees to unlock it. Thank you very much.");
                return;
            }

            // Check if the password retrieved matcth the password for the operator
            if (!(retrievedOperator.VerifyPassword(password)))
            {
                tries -= 1;
                MessageBox.Show("Wrong password entered. Please try again. \n\nAttempts left : " + tries, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tries > 0)
            {
                retrievedOperator.Lock();
            }

            this.Hide();

            this.txt_username.Text = "";
            this.txt_password.Text = "";
            this.checkBox1.Checked = false;
            this.txt_username.Focus();
            
            SummaryForm summary = new SummaryForm(this, retrievedOperator);
            summary.Show();
            return;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (this.txt_username.Focused)
                {
                    this.txt_password.Focus();                    
                } 
                else
                {
                    LoginButton.PerformClick();
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.txt_password.UseSystemPasswordChar =
                this.checkBox1.Checked ? false : true;
        }
    }
}
