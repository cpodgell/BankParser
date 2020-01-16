using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankParser.Model.DataSets;
using BankParser.Model;
using BankParser.Controller;
using BankParser.ModalForm;
using System.Diagnostics;

namespace BankParser.View
{
    public partial class CatagoryAssigningForm : Form
    {
        public CatagoryAssigningForm()
        {
            InitializeComponent();
        }

        private void CatagoryAssigningForm_Load(object sender, EventArgs e)
        {
            ExpenseImportFormModel.GetExpenseData(ref dtsExpenses);

            CatagoryAssignController.GetData(ref dtsCatagory);

            CatagoryAssignController.PopulateContentMenuStrip(cmsBudgetItems);


            CatagoryAssignController.PropogateExpenseCatagory(dtsExpenses, dtsCatagory);
        }

        private void cmsBudgetItems_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (cmsBudgetItems.SourceControl.Equals(dgvExpenseItems))
            {
                string description = (((DataRowView)dgvExpenseItems.SelectedRows[0].DataBoundItem).Row[dtsExpenses.tttExpenses.Description_1Column].ToString());
                string item = e.ClickedItem.Text;

                string subCatagory = "";
                string ExpenseID = (string)(((DataRowView)dgvExpenseItems.SelectedRows[0].DataBoundItem).Row[dtsExpenses.tttExpenses.UniqueExpenseIDColumn.Ordinal]);

                CatagoryAssignController.AssignCatagory(description, item, ref dtsCatagory, ref dtsExpenses, subCatagory, ExpenseID);

                CatagoryAssignController.PropogateExpenseCatagory(dtsExpenses, dtsCatagory);
            }
            else
            {
                ((DataRowView)dgvCatagory.SelectedRows[0].DataBoundItem).Row[dtsCatagory.tttCatagory.BudgetItemNameColumn.Ordinal] = e.ClickedItem.Text;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Controller.CatagoryAssignController.SaveData(ref dtsCatagory);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dgrRow in dgvCatagory.SelectedRows)
            {
                ((DataRowView)dgrRow.DataBoundItem).Row.Delete();
            }
        }

        private void EndEdit()
        {
            foreach(DataRow dtr in dtsCatagory.tttCatagory.Rows)
            {
                dtr.EndEdit();
                dtr.AcceptChanges();
            }
        }
    }
}
