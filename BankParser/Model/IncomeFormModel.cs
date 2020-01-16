using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankParser.Model.DataSets;
using System.IO;
using System.Windows.Forms;
using BankParser.Utils;

namespace BankParser.Model
{
    public static class IncomeFormModel
    {
        internal static void GetData(ref Income dtsIncome)
        {
            dtsIncome.Clear();
            PopulateIncome(ref dtsIncome);
        }

        private static void PopulateIncome(ref Income dtsIncome)
        {
            if (File.Exists(Model.ModelBusinessRules.GetIncomeFileLocation()))
            {
                dtsIncome.ReadXml(Model.ModelBusinessRules.GetIncomeFileLocation());
            }
            else
            {
                MessageBox.Show("ERROR NOT FOUND Path: " + Model.ModelBusinessRules.GetIncomeFileLocation());
            }
        }


        internal static void SaveData(Income dtsIncome)
        {
            Model.ModelBusinessRules.incomeXMLFileName = DataUtils.BuildXMLFileName(Model.ModelBusinessRules.INCOMEXMLBASE);
            dtsIncome.WriteXml(Model.ModelBusinessRules.GetIncomeFileLocation());
            Controller.ConfigurationReader.WriteConfigurationFile();
        }
    }
}
