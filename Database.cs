using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BankSystem
{
    public class Database
    {
        static private string accountsFileDirectory { get; set; }
        static private string operatorsFilePath { get; set; }
        static private string transactionIDFile { get; set; } = "globals.txt";

        static private Dictionary<string, int> operatorKeyMap = new Dictionary<string, int>()
        {
            { "username", 0 },
            { "password", 1 },
            { "accountNumber", 2 },
            { "accessFlag", 3},
            { "isEmployee", 4 }
        };

        static private Dictionary<string, int> transactionKeyMap = new Dictionary<string, int>()
        {
            { "transactionID", 0 },
            { "transactionType", 1},
            { "transactionDate", 2 },
            { "transactionAmount", 3 },
            { "senderAccount", 4 },
            { "receiverAccount", 5 }
        };

        static public void SetFilesPath(string accountsFileDirectory = null, string operatorsFilePath = null)
        {
            Database.accountsFileDirectory = accountsFileDirectory;
            Database.operatorsFilePath = operatorsFilePath;
        }

        // Retrieve data for an account from the data storage and
        // parse them into an Account object
        static public Account GetAccount(string accountNumber) // Get an Account object from the files
        {
            string[] dirs = Directory.GetDirectories(Database.accountsFileDirectory);

            if (accountNumber.Length != 10)
            {
                return null;
            }

            foreach (var dir in dirs)
            {
                if (dir.EndsWith(accountNumber.Substring(0, 9)))
                {
                    string[] entry = File.ReadAllText(Path.Combine(dir, $"{accountNumber}.txt")).Split(',');
                    if (accountNumber.EndsWith("1"))
                    {
                        return new SavingAccount(entry[0], accountNumber, entry[1]);
                    }
                    else if(accountNumber.EndsWith("0"))
                    {
                        return new ChequingAccount(entry[0], accountNumber, entry[1]);
                    }
                }
            }

            return null; // No accounts found
        }

        // Retrieve data for an operator from the data storage and
        // parse them into an Operator object
        static public Operator GetOperator(string key, string value)
        {
            bool isValidKey = Database.operatorKeyMap.ContainsKey(key);

            if (!isValidKey) return null;

            string[] lines = File.ReadAllLines(Database.operatorsFilePath);
            foreach (var line in lines)
            {
                List<string> entry = new List<string>(line.Split(','));
                if (entry[Database.operatorKeyMap[key]] == value)
                {
                    if (entry.Last() == "1")
                    {
                        // Return Employee
                        return new Employee(entry[0], entry[1], entry[2]);
                    }

                    // Return Client
                    return new Client(entry[0], entry[1], entry[2], entry[3] == "1" ? true : false);
                }
            }

            return null; // No operators found
        }

        // Write the content of an Account object into the data storage
        static public void SaveAccount(Account accountToBeSaved, bool saveNew = false)
        {
            string accountNumber = accountToBeSaved.GetNumber();

            if (saveNew)
            {
                Directory.CreateDirectory(Path.Combine(Database.accountsFileDirectory, accountNumber.Substring(0, 9)));
                File.WriteAllText(Path.Combine(Database.accountsFileDirectory, accountNumber.Substring(0, 9), $"{accountNumber}.txt"), accountToBeSaved.ToQueryString());
                return;
            }
            
            string[] dirs = Directory.GetDirectories(Database.accountsFileDirectory);
            foreach (var dir in dirs)
            {
                if (dir.EndsWith(accountNumber.Substring(0, 9)))
                {
                    string filepath = Path.Combine(dir, $"{accountNumber}.txt");
                    File.WriteAllText(filepath, accountToBeSaved.ToQueryString());
                    return;
                }
            }

            throw new FileNotFoundException();
        }

        // Write the contents of an Operator object into the data storage
        static public void SaveOperator(Operator operatorToBeSaved, bool saveNew = false)
        {
            if (saveNew)
            {
                File.AppendAllText(Database.operatorsFilePath, operatorToBeSaved.ToQueryString() + '\n');
                return;
            }

            if (operatorToBeSaved == null) return;

            string[] lines = File.ReadAllLines(Database.operatorsFilePath);
            for (var index = 0; index < lines.Length; index++)
            {
                List<string> entry = new List<string>(lines[index].Split(','));
                if (entry[Database.operatorKeyMap["accountNumber"]] == operatorToBeSaved.GetNumber())
                {
                    string modifiedEntry = operatorToBeSaved.ToQueryString();
                }
            }

            return;
        }

        // Write the content of a Transaction object into the data storage
        static public void SaveTransaction(Transaction transactionToBeSaved)
        {
            List<string> accountsToBeWrittenTo = new List<string>();

            accountsToBeWrittenTo.Add(transactionToBeSaved.GetSenderNumber());
            
            string receiverAccNumber = transactionToBeSaved.GetReceiverNumber();
            if (receiverAccNumber != "N/A")
 { accountsToBeWrittenTo.Add(receiverAccNumber); }
            try
            {
                for (int i = 0; i < accountsToBeWrittenTo.Count; i++)
                {
                    string accountNumber = accountsToBeWrittenTo[i];
                    File.AppendAllText(Path.Combine(Database.accountsFileDirectory, accountNumber.Substring(0, 9), $"{accountNumber}_transaction.txt"), transactionToBeSaved.ToQueryString());
                }

                int incrementedTransactionID = int.Parse(File.ReadAllText(Path.Combine(Database.accountsFileDirectory, Database.transactionIDFile))) + 1;

                File.WriteAllText(Path.Combine(Database.accountsFileDirectory, Database.transactionIDFile), incrementedTransactionID.ToString());

                return;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // Returns the current available transaction ID
        static public string GetTransactionID()
        {
            return File.ReadAllText(Path.Combine(Database.accountsFileDirectory, Database.transactionIDFile));
        }

        static public Transaction[] GetTransactions(string accountNumber, string key = null, string value1 = null, string value2 = null)
        {
            List<Transaction> result = new List<Transaction>();
            string filepath = Path.Combine(
                Database.accountsFileDirectory,
                $"{accountNumber.Substring(0, 9)}",
                $"{accountNumber}_transaction.txt"
            );


            if (!File.Exists(filepath)) { return result.ToArray(); }
            string[] lines = File.ReadAllLines(filepath);

            // Returns all transactions made from the account
            if (key == null)
            {
                foreach (var line in lines)
                {
                    string[] entry = line.Split(',');
                    Transaction newTransaction = new Transaction(
                            entry[0],
                            entry[1],
                            DateTime.Parse(entry[2]),
                            float.Parse(entry[3]),
                            entry[4],
                            entry[5]
                        );
                    result.Add(newTransaction);
                }
                return result.ToArray();
            }

            
            // Returns an empty array of transactions if the key does not exist
            if (!transactionKeyMap.ContainsKey(key)) { return result.ToArray(); }

            

            // Returns transactions with a specified condition
            if (key == "transactionDate")
            {
                foreach (var line in lines)
                {
                    string[] entry = line.Split(',');
                    if (DateTime.Parse(value1) < DateTime.Parse(entry[Database.transactionKeyMap["transactionDate"]]) 
                        && 
                        DateTime.Parse(entry[Database.transactionKeyMap["transactionDate"]]) < DateTime.Parse(value2))
                    {
                        Transaction newTransaction = new Transaction(
                            entry[0],
                            entry[1],
                            DateTime.Parse(entry[2]),
                            float.Parse(entry[3]),
                            entry[4],
                            entry[5]
                        );
                        result.Add(newTransaction);
                    }
                }
            }
            else
            {
                
                foreach (var line in lines)
                {
                    string[] entry = line.Split(',');
                    if (entry[Database.transactionKeyMap[key]] == value1)
                    {
                        Transaction newTransaction = new Transaction(
                            entry[0],
                            entry[1],
                            DateTime.Parse(entry[2]),
                            float.Parse(entry[3]),
                            entry[4],
                            entry[5]
                        );
                        result.Add(newTransaction);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
