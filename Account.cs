using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public class Account
    {
        protected string username { get; set; }
        protected string accountNumber { get; set; }
        protected float balance { get; set; }

        public Account()
        {
            this.username = "";
            this.accountNumber = "";
            this.balance = 0.00F;
        }

        public Account(string username, string accountNumber, string balance)
        {
            this.username = username;
            this.accountNumber = accountNumber;
            this.balance = float.Parse(balance);
        }

        public string GetBalance()
        {
            return this.balance.ToString();
        }

        public string GetOwner()
        {
            return this.username;
        }

        public string GetNumber()
        {
            return this.accountNumber;
        }

        public virtual string ToQueryString()
        {
            return "";
        }

        public bool Deposit(float amount, bool fromTransfer = false) // Deposit into any account
        {
            float roundedAmount = (float)Math.Round(amount * 100f) / 100f;
            this.balance += roundedAmount;
            try
            {
                Database.SaveAccount(this);

                if (!fromTransfer)
                {
                    Transaction transactionRecord = new Transaction(
                            Database.GetTransactionID(),
                            "Deposit",
                            DateTime.Now,
                            roundedAmount,
                            this.accountNumber
                        );

                    Database.SaveTransaction(transactionRecord);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Withdraw(float amount)
        {
            float roundedAmount = (float)Math.Round(amount * 100f) / 100f;
            if (this.balance < roundedAmount)
            {
                return false;
            }

            try
            {
                this.balance -= roundedAmount;
                Database.SaveAccount(this);

                Transaction transactionRecord = new Transaction(
                        Database.GetTransactionID(),
                        "Withdraw",
                        DateTime.Now,
                        roundedAmount,
                        this.accountNumber

                    );

                Database.SaveTransaction(transactionRecord);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Transfer(float amount, string receiverAccountNumber)
        {
            float roundedAmount = (float)Math.Round(amount * 100f) / 100f;
            if (this.balance < roundedAmount)
            {
                return false;
            }

            try
            {
                Account receiverAccount = Database.GetAccount(receiverAccountNumber);

                if (receiverAccount == null) { return false; }

                receiverAccount.Deposit(roundedAmount, true);
                
                this.balance -= roundedAmount;
                Database.SaveAccount(this);

                Transaction transactionRecord = new Transaction(
                        Database.GetTransactionID(),
                        "Transfer",
                        DateTime.Now,
                        roundedAmount,
                        this.accountNumber,
                        receiverAccountNumber
                    );

                Database.SaveTransaction(transactionRecord);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public class ChequingAccount : Account
    {
        public ChequingAccount() : base()
        {

        }

        public ChequingAccount(string username, string accountNumber, string balance) : base(username, accountNumber, balance)
        {

        }

        public override string ToQueryString()
        {
            string[] query = { this.username, this.balance.ToString() };
            return string.Join(",", query);
        }
    }

    public class SavingAccount : Account
    {
        public SavingAccount() : base()
        {

        }

        public SavingAccount(string username, string accountNumber, string balance) : base(username, accountNumber, balance)
        {

        }

        public override string ToQueryString()
        {
            string[] query = { this.username, this.balance.ToString() };
            return string.Join(",", query);
        }
    }
}
