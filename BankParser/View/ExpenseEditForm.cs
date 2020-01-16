using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankParser.Model.DataSets;
using BankParser.Utils;

namespace BankParser.View
{
    public partial class ExpenseEditForm : Form
    {
        public ExpenseEditForm()
        {
            InitializeComponent();
        }

        internal static void GetExpenseData(ref Expenses dtsExpenses)
        {
            Model.ExpenseImportFormModel.GetExpenseData(ref dtsExpenses);
           
        }


        internal static void GetDeletedExpenseData(ref DeletedExpenses dtsDeletedExpenses)
        {
            Model.ExpenseImportFormModel.GetDeletedExpenseData(ref dtsDeletedExpenses);

        }
      

        private void ExpenseEditForm_Load(object sender, EventArgs e)
        {
            GetExpenseData(ref dtsExpenses);
            GetDeletedExpenseData(ref dtsDeletedExpenses);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.ExpenseImportFormModel.SaveExpenseData(dtsExpenses);
            Model.ExpenseImportFormModel.SaveDeletedExpenseData(dtsDeletedExpenses);
        }

        private void btnRemoveNegative_Click(object sender, EventArgs e)
        {
            foreach(Expenses.tttExpensesRow expRow in dtsExpenses.tttExpenses.Rows)
            {
                Type t = expRow[dtsExpenses.tttExpenses._CAD_Column.Ordinal].GetType();
                if ((decimal)expRow[dtsExpenses.tttExpenses._CAD_Column.Ordinal] < 0)
                {
                    expRow[dtsExpenses.tttExpenses._CAD_Column.Ordinal] = -1 * ((decimal)expRow[dtsExpenses.tttExpenses._CAD_Column.Ordinal]);
                }
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dgvRow in dgvExpenseItems.SelectedRows)
            {
                DataRow dtrRow = ((DataRowView)dgvRow.DataBoundItem).Row;
                dtsDeletedExpenses.tttDeletedExpenses.ImportRow(dtrRow);
                ((DataRowView)dgvRow.DataBoundItem).Row.Delete();
            }
            

        }
    }
}
