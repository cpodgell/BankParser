using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankParser.Model;

namespace BankParser.Controller
{
    class ExpenseEditFormController
    {
        internal static void OpenExpenseForm()
        {
            View.ExpenseEditForm ef = new View.ExpenseEditForm();
            ef.Show();
        }
    }
}
