using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BankParser.Controller
{
    static class ConfigurationReader
    {

        internal static void SetupEnvironment()
        {
            if (!Directory.Exists(Model.ModelBusinessRules.GetFileBaseDirectory()))
            {
                //Create base directory if one does not exist for working files.
                Directory.CreateDirectory(Model.ModelBusinessRules.FILEBASEDIRECTORY);
                Directory.CreateDirectory(Model.ModelBusinessRules.GetXMLLocation());
            }

            if (!Directory.Exists(Model.ModelBusinessRules.GetConfigFolder()))
            {
                Directory.CreateDirectory(Model.ModelBusinessRules.GetConfigFolder());

            }
            if (!File.Exists(Model.ModelBusinessRules.GetConfigFileLocation()))
            {
                CreateDefaultConfigFile();
            }
        }

        internal static void CreateDefaultConfigFile()
        {
            string[] lines = new string[6];

            lines[0] = Model.ModelBusinessRules.configBudgetFileNameProp + "=" + Model.ModelBusinessRules.BUDGETXMLBASE;
            lines[1] = Model.ModelBusinessRules.configIncomeFileNameProp + "=" + Model.ModelBusinessRules.INCOMEXMLBASE;
            lines[2] = Model.ModelBusinessRules.configExpenseFileNameProp + "=" + Model.ModelBusinessRules.EXPENSEXMLBASE;
            lines[3] = Model.ModelBusinessRules.configCatagoryFileNameProp + "=" + Model.ModelBusinessRules.CATAGORYXMLBASE;
            lines[4] = Model.ModelBusinessRules.configSubCatagoryFileNameProp + "=" + Model.ModelBusinessRules.SUBCATAGORYXMLBASE;
            lines[5] = Model.ModelBusinessRules.configDeletedExpenseFileNameProp + "=" + Model.ModelBusinessRules.DELETEDEXPENSEXMLBASE;
            using (StreamWriter outputFile = new StreamWriter(Model.ModelBusinessRules.GetConfigFileLocation()))
            {
                foreach (string lineItm in lines)
                {
                    outputFile.WriteLine(lineItm);
                }
            }
        }

        static public void ReadConfigurationFile()
        {
            string[] lines = System.IO.File.ReadAllLines(Model.ModelBusinessRules.GetConfigFileLocation());
            foreach (string str in lines)
            {
                if (str.Contains(Model.ModelBusinessRules.configBudgetFileNameProp))
                {
                    Model.ModelBusinessRules.budgetXMLFileName = str.Replace(Model.ModelBusinessRules.configBudgetFileNameProp + "=", "");
                }
                if (str.Contains(Model.ModelBusinessRules.configIncomeFileNameProp))
                {
                    Model.ModelBusinessRules.incomeXMLFileName = str.Replace(Model.ModelBusinessRules.configIncomeFileNameProp + "=", "");
                }
                if (str.Contains(Model.ModelBusinessRules.configExpenseFileNameProp))
                {
                    Model.ModelBusinessRules.expenseXMLFileName = str.Replace(Model.ModelBusinessRules.configExpenseFileNameProp + "=", "");
                }
                if (str.Contains(Model.ModelBusinessRules.configCatagoryFileNameProp))
                {
                    Model.ModelBusinessRules.catagoryXMLFileName = str.Replace(Model.ModelBusinessRules.configCatagoryFileNameProp + "=", "");
                }
                if (str.Contains(Model.ModelBusinessRules.configSubCatagoryFileNameProp))
                {
                    Model.ModelBusinessRules.subCatagoryXMLFileName = str.Replace(Model.ModelBusinessRules.configSubCatagoryFileNameProp + "=", "");
                }
                if (str.Contains(Model.ModelBusinessRules.configDeletedExpenseFileNameProp))
                {
                    Model.ModelBusinessRules.deletedExpenseXMLFilename = str.Replace(Model.ModelBusinessRules.configDeletedExpenseFileNameProp + "=", "");
                }
            }
        }

        static public void WriteConfigurationFile()
        {
            string[] lines = System.IO.File.ReadAllLines(Model.ModelBusinessRules.GetConfigFileLocation());
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(Model.ModelBusinessRules.configBudgetFileNameProp))
                {
                    lines[i] = Model.ModelBusinessRules.configBudgetFileNameProp + "=" + Model.ModelBusinessRules.budgetXMLFileName;
                }
                if (lines[i].Contains(Model.ModelBusinessRules.configIncomeFileNameProp))
                {
                    lines[i] = Model.ModelBusinessRules.configIncomeFileNameProp + "=" + Model.ModelBusinessRules.incomeXMLFileName;
                }
                if (lines[i].Contains(Model.ModelBusinessRules.configExpenseFileNameProp))
                {
                    lines[i] = Model.ModelBusinessRules.configExpenseFileNameProp + "=" + Model.ModelBusinessRules.expenseXMLFileName;
                }
                if (lines[i].Contains(Model.ModelBusinessRules.configCatagoryFileNameProp))
                {
                    lines[i] = Model.ModelBusinessRules.configCatagoryFileNameProp + "=" + Model.ModelBusinessRules.catagoryXMLFileName;
                }
                if (lines[i].Contains(Model.ModelBusinessRules.configSubCatagoryFileNameProp))
                {
                    lines[i] = Model.ModelBusinessRules.configSubCatagoryFileNameProp + "=" + Model.ModelBusinessRules.subCatagoryXMLFileName;
                }
                if (lines[i].Contains(Model.ModelBusinessRules.configDeletedExpenseFileNameProp))
                {
                    lines[i] = Model.ModelBusinessRules.configDeletedExpenseFileNameProp + "=" + Model.ModelBusinessRules.deletedExpenseXMLFilename;
                }
            }
            using (StreamWriter outputFile = new StreamWriter(Model.ModelBusinessRules.GetConfigFileLocation()))
            {
                foreach (string lineItm in lines)
                {
                    outputFile.WriteLine(lineItm);
                }
            }
        
        }
    }
}
