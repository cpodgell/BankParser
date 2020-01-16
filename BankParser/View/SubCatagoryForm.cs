using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankParser.Controller;
using BankParser.Model;
using BankParser.Utils;

namespace BankParser.View
{
    public partial class SubCatagoryForm : Form
    {
        public SubCatagoryForm()
        {
            InitializeComponent();
        }

        private void SubCatagoryForm_Load(object sender, EventArgs e)
        {
            SubCatagoryFormController.GetData(ref dtsSubCatagory);
            BudgetFormModel.GetBudgetData(ref dtsBudgetItems);
            DataUtils.PopulateContextMenu(cmsBudgetItems);
        }

        private void cmsBudgetItems_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string item = e.ClickedItem.Text;

            string subCatagory = "";
            if (dgvSubCatagory.CurrentRow != null && dgvSubCatagory.CurrentRow.DataBoundItem != null)
            {
                ((DataRowView)dgvSubCatagory.CurrentRow.DataBoundItem).Row[dtsSubCatagory.tttSubCatagory.CatagoryColumn.Ordinal] = item;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Controller.SubCatagoryFormController.SaveData(ref dtsSubCatagory);
        }
    }
}
