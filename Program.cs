using System;
using System.Configuration;
using System.Windows.Forms;

namespace BankSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            string operatorsFilePath = ConfigurationManager.AppSettings.Get("operatorsFilePath");
            string accountsFileDirectory = ConfigurationManager.AppSettings.Get("accountsFileDirectory");

            Database.SetFilesPath(accountsFileDirectory, operatorsFilePath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

    }
}
