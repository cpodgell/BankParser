using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BankParser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BankParser.Controller.ConfigurationReader.SetupEnvironment();
            BankParser.Controller.ConfigurationReader.ReadConfigurationFile();
            Application.Run(new EntryForm());
        }
    }
}
