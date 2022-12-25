using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public class Operator
    {
        protected string username { get; set; }
        protected string password { get; set; }
        protected string baseAccountNumber { get; set; }

        public Operator()
        {

        }

        public Operator(string username, string password, string baseAccountNumber) // Constructor
        {
            this.username = username;
            this.password = password;
            this.baseAccountNumber = baseAccountNumber;
        }

        public bool VerifyPassword(string password)
        {
            return (this.password == password);
        }

        public string GetUsername()
        {
            return this.username;
        }

        public SavingAccount GetSavingAccount()
        {
            return (SavingAccount)Database.GetAccount($"{this.baseAccountNumber}1");
        }

        public ChequingAccount GetChequingAccount()
        {
            return (ChequingAccount)Database.GetAccount($"{this.baseAccountNumber}0");
        }

        public string GetNumber()
        {
            return this.baseAccountNumber;
        }

        public virtual string ToQueryString()
        {
            string[] query = { this.username, this.password, this.baseAccountNumber };
            return string.Join(",", query);
        }

        public void Lock()
        {

        }
    }

    public class Client : Operator
    {
        private bool accessFlag;

        public Client() : base()
        {

        }

        public Client(string username, string password, string baseAccountNumber, bool accessFlag = true) : base(username, password, baseAccountNumber)
        {
            this.accessFlag = accessFlag;
        }

        public bool CheckFlag()
        {
            return this.accessFlag;
        }

        public override string ToQueryString()
        {
            string[] query = { this.username, this.password, this.baseAccountNumber, "0" };
            return string.Join(",", query);
        }
    }

    public class Employee : Operator
    {
        public Employee() : base()
        {

        }

        public Employee(string username, string password, string accountNumber) : base(username, password, accountNumber)
        {

        }

        public void CreateClient(string username, string password)
        {

        }

        public void CreateEmployee(string username, string password)
        {

        }

        public void CreateAccount(string username, Func<string, string> generateAccNumber, bool createSaving = false)
        {
            string newAccountNumber = generateAccNumber("");
            Account newAccount;
            
            if (createSaving)
            {
                newAccount = new SavingAccount(username, newAccountNumber, "0");
            }
            else
            {
                newAccount = new ChequingAccount(username, newAccountNumber, "0");
            }

            Database.SaveAccount(newAccount);
            return;
        }

        public override string ToQueryString()
        {
            string[] query = { this.username, this.password, this.baseAccountNumber, "1" };
            return string.Join(",", query);
        }
    }
}
