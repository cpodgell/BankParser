using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankParser.Model
{
    static class ModelBusinessRules
    {

        static public string configBudgetFileLocationProp = "[XMLFileLocation]";

        static public string configBudgetFileNameProp = "[BudgetFileName]";

        static public string configIncomeFileNameProp = "[IncomeFileName]";

        static public string configExpenseFileNameProp = "[ExpenseFileName]";

        static public string configDeletedExpenseFileNameProp = "[DeletedExpenseFileName]";

        static public string configCatagoryFileNameProp = "[CatagoryFileName]";

        static public string configSubCatagoryFileNameProp = "[SubCatagoryFileName]";

        public const string BUDGETXMLBASE = "BudgetXML";
        public const string INCOMEXMLBASE = "IncomeXML";
        public const string EXPENSEXMLBASE = "ExpenseXML";
        public const string DELETEDEXPENSEXMLBASE = "DeletedExpenseXML";
        public const string CATAGORYXMLBASE = "CatagoryXML";
        public const string SUBCATAGORYXMLBASE = "SubCatagoryXML";

        public const string FILEBASEDIRECTORY = @"C:\BankParserFiles";

        public const string CONFIGFILEBASE = "Config.txt";

        //Paths
        //static public string XMLPath;

        static public string budgetXMLFileName;
        static public string incomeXMLFileName;
        static public string expenseXMLFileName;
        static public string deletedExpenseXMLFilename;
        static public string catagoryXMLFileName;
        static public string subCatagoryXMLFileName;


        static private string configFileName = @"Config.txt";
        static private string configFileFolder = @"\config";

        static private string workingDirectory = @"\WorkingFiles";

        static private string XMLDirectory = @"\DatabaseXML";

        static private string CSVDirectory = @"\csv";

        //static public string newBudgetXMLPath = @"C:\dotnet\BankParser\BankParser\Model\xml\XMLBudget" + GetTimeStamp() + ".xsd";

        public static string GetConfigFolder()
        {
            string s = GetFileBaseDirectory() + workingDirectory + configFileFolder;
            return s;
        }

        public static string GetXMLLocation()
        {
            string root1 = Directory.GetCurrentDirectory();
            DirectoryInfo root2 = Directory.GetParent(root1).Parent;
            string s = root2.FullName + XMLDirectory;
            return s;
        }

        public static string GetCSVLocation()
        {
            string s = GetFileBaseDirectory() + workingDirectory + CSVDirectory;
            return s;
        }

        public static string GetConfigFileLocation()
        {
            string s = GetConfigFolder() + @"\" + configFileName;
            return s;
        }

        public static string GetBudgetFileLocation()
        {
            string s = GetXMLLocation() + @"\" + budgetXMLFileName;
            return s;
        }

        internal static string GetIncomeFileLocation()
        {
            string s = GetXMLLocation() + @"\" + incomeXMLFileName;
            return s;
        }

        internal static string GetExpenseFileLocation()
        {
            string s = GetXMLLocation() + @"\" + expenseXMLFileName;
            return s;
        }


        internal static string GetDeletedExpenseFileLocation()
        {
            string s = GetXMLLocation() + @"\" + deletedExpenseXMLFilename;
            return s;
        }

        internal static string GetCatagoryFileLocation()
        {
            string s = GetXMLLocation() + @"\" + catagoryXMLFileName;
            return s;
        }

        internal static string GetSubCatagoryFileLocation()
        {
            string s = GetXMLLocation() + @"\" + subCatagoryXMLFileName;
            return s;
        }

        public static string GetFileBaseDirectory()
        {
            return FILEBASEDIRECTORY;//System.IO.Directory.GetCurrentDirectory();
        }

        //BudgetFormModel
        static public string[] itemTypes = new string[]{"Fixed","Variable"};
    }
}
