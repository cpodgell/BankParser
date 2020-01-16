using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using BankParser.Utils;

namespace BankParser.Model
{
    class BudgetFormModel
    {
        static public void GetData(ref Model.DataSets.BudgetItems budgetDataSet, ref Model.DataSets.ItemTypes typeDataSet)
        {
            PopulateBudget(ref budgetDataSet);
            PopulateTypes(ref typeDataSet);
        }

        static public void GetBudgetData(ref Model.DataSets.BudgetItems budgetDataSet)
        {
            PopulateBudget(ref budgetDataSet);
        }

        public static void PopulateBudget(ref BankParser.Model.DataSets.BudgetItems budgetDataSet)
        {
            budgetDataSet.Clear();
            if (File.Exists(Model.ModelBusinessRules.GetBudgetFileLocation()))
            {
                budgetDataSet.ReadXml(Model.ModelBusinessRules.GetBudgetFileLocation());
            }
            else
            {
                PathUtils.FindXMLDialog(Model.ModelBusinessRules.GetBudgetFileLocation());
            }
        }

        public static void PopulateTypes(ref Model.DataSets.ItemTypes typeDataSet)
        {
            foreach (string itm in Model.ModelBusinessRules.itemTypes)
            {
                Model.DataSets.ItemTypes.tttItemTypesRow itemTypeRow = typeDataSet.tttItemTypes.NewtttItemTypesRow();

                itemTypeRow[typeDataSet.tttItemTypes.ItemTypeColumn.Ordinal] = itm;

                typeDataSet.tttItemTypes.Rows.Add(itemTypeRow);
            }
        }

        internal static void SaveData(BankParser.Model.DataSets.BudgetItems dtsBudgetItems)
        {
            Model.ModelBusinessRules.budgetXMLFileName = DataUtils.BuildXMLFileName(Model.ModelBusinessRules.BUDGETXMLBASE);
            dtsBudgetItems.WriteXml(Model.ModelBusinessRules.GetBudgetFileLocation());
            Controller.ConfigurationReader.WriteConfigurationFile();
        }
    }
}
