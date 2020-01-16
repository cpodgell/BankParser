using System;
using System.Collections.Generic;
using System.Text;
using BankParser.View;
using BankParser.Model;
using System.Data;
using BankParser.Model.DataSets;

namespace BankParser.Controller
{
    class ExpenseFormController
    {
        internal static void OpenExpenseForm()
        {
            ExpenseForm ef = new ExpenseForm();
            ef.Show();
        }

        internal static void GetCSVData(ref Expenses dtsExpenses, ref List<string> errorLog)
        {
            ExpenseImportFormModel.GetCSVData(ref dtsExpenses, ref errorLog);
        }

        internal static void ImportCSV(ref Expenses dtsExpenses, ref List<string> errorlog)
        {
            ExpenseImportFormModel.ImportCSV(ref dtsExpenses, ref errorlog);
        }

        internal static void GetExpenseData(ref Expenses dtsExpenses)
        {
            Model.ExpenseImportFormModel.GetExpenseData(ref dtsExpenses);
        }
    }
}
