using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Transaction
    {
        protected string transactionID { get; set; }
        protected string transactionType { get; set; }
        protected DateTime transactionDate { get; set; }
        protected float transactionAmount { get; set; }
        protected string senderAccount { get; set; }
        protected string receiverAccount { get; set; }

        public Transaction(
            string transactionID, 
            string transactionType, 
            DateTime transactionDate, 
            float transactionAmount, 
            string senderAccount,
            string receiverAccount = "N/A"
        )
        {
            this.transactionID = transactionID;
            this.transactionType = transactionType;
            this.transactionDate = transactionDate;
            this.transactionAmount = transactionAmount;
            this.senderAccount = senderAccount;
            this.receiverAccount = receiverAccount;
        }

        public string GetSenderNumber()
        {
            return this.senderAccount;
        }

        public string GetReceiverNumber()
        {
            return this.receiverAccount;
        }

        public string ToQueryString()
        {
            string[] query =
            {
                this.transactionID,
                this.transactionType,
                this.transactionDate.ToString(),
                this.transactionAmount.ToString(),
                this.senderAccount,
                this.receiverAccount
            };

            return string.Join(",", query) + '\n';
        }

        public string[] ToQuery()
        {
            string[] query =
            {
                this.transactionID,
                this.transactionType,
                this.transactionDate.ToString(),
                this.transactionAmount.ToString(),
                this.senderAccount,
                this.receiverAccount
            };

            return query;
        }
    }
}
