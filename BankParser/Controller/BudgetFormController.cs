using System;
using System.Collections.Generic;
using System.Text;
using BankParser.View;
using System.Data;

namespace BankParser.Controller
{
    static class BudgetFormController
    {
        static public void OpenBudgetForm()
        {
            BudgetForm budgetForm = new BudgetForm();
            budgetForm.Show();
        }


        internal static void Initialize(BudgetForm budgetForm)
        {
            
        }

        internal static void GetData(ref BankParser.Model.DataSets.BudgetItems budgetDataSet, ref BankParser.Model.DataSets.ItemTypes itemTypeDataSet)
        {
            Model.BudgetFormModel.GetData(ref budgetDataSet, ref itemTypeDataSet);
           
        }

        internal static void SaveData(BankParser.Model.DataSets.BudgetItems dtsBudgetItems)
        {
            Model.BudgetFormModel.SaveData(dtsBudgetItems);
        }
    }
}
