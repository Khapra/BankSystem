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
    public partial class EmployeeLogin : LoginForm
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void LoginClient_Click(object sender, EventArgs e)
        {
            string username = AccountNumber_txt.Text;
            Operator retrievedOperator = Database.GetOperator("username", username);
            EmployeeSummary summary = new EmployeeSummary(this, retrievedOperator);
            summary.Show();
            return;
        }
    }
}
