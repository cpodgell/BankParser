using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankParser.View;

namespace BankParser
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void btnOpenBudgetForm_Click(object sender, EventArgs e)
        {
            Controller.BudgetFormController.OpenBudgetForm();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Controller.IncomeFormController.OpenIncomeForm();
        }

        private void btnExpenseImportForm_Click(object sender, EventArgs e)
        {
            Controller.ExpenseFormController.OpenExpenseForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void btnCatagoryAssign_Click(object sender, EventArgs e)
        {
            Controller.CatagoryAssignController.OpenCatagoryAssignForm();
        }

        private void btnOpenAnalysis_Click(object sender, EventArgs e)
        {
            Controller.AnalysisController.OpenAnalysisAssignForm();
        }

        private void btnExpenseEditForm_Click(object sender, EventArgs e)
        {
           Controller.ExpenseEditFormController.OpenExpenseForm();
        }

        private void btnSubCatagory_Click(object sender, EventArgs e)
        {
            Controller.SubCatagoryFormController.OpenSubCatagoryForm();
        }

        private void convertMastercardBankCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.DataUtils.FixMasterCardPDFCSV();
        }

        private void converrtRoyalBankCSVPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.DataUtils.FixRoyalBankPDFCSV();
        }

        private void setupToolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
