using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankParser.Model.DataSets;

namespace BankParser.View
{
    public partial class BudgetForm : Form
    {
        public BudgetForm()
        {
            InitializeComponent();
            BudgetFormInitialize();
        }

        public void BudgetFormInitialize()
        {
            Controller.BudgetFormController.GetData(ref dtsBudgetItems, ref dtsItemTypes);
            BusinessRulesGlobal.DataGridRules(this);
            foreach (DataGridViewColumn dgvTmp in dgvBudgetItems.Columns)
            {
                if (dgvTmp.DataPropertyName.Equals(dtsBudgetItems.tttBudgetItems.ColorColumn.ColumnName))
                {
                    dgvTmp.Width = 300;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Controller.BudgetFormController.SaveData(dtsBudgetItems);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CalculateTotals(2017);
        }

        private void CalculateTotals(int year)
        {
            Model.IncomeFormModel.GetData(ref dtsIncome);
            decimal monthlyIncome = 0;
            decimal monthlyIncomeCPP = 0;
            bool foundCPP = false;

            int numberOfCPPMonths = 0;

            foreach (Income.tttIncomeRow dtrRow in dtsIncome.tttIncome.Rows)
            {
                if ((bool)dtrRow[dtsIncome.tttIncome.IsCPPColumn.Ordinal])
                {
                    monthlyIncomeCPP = (decimal)dtrRow[dtsIncome.tttIncome.AmountColumn.Ordinal];
                    foundCPP = true;
                    numberOfCPPMonths++;
                }
                else
                {
                    monthlyIncome = (decimal)dtrRow[dtsIncome.tttIncome.AmountColumn.Ordinal];
                }
            }


            txtMonthlyIncome.Text = string.Format("{0:C}", monthlyIncome);
            txtMonthlyCPPIncome.Text = string.Format("{0:C}", monthlyIncomeCPP);
            //* Income

            txtMonth.Text = (12 - numberOfCPPMonths).ToString();
            txtMonthsCPP.Text = numberOfCPPMonths.ToString();

            decimal YearlySavingsTotal = monthlyIncome*12;

            txtYearlySavingsTotal.Text = string.Format("{0:C}", (12 - numberOfCPPMonths) * monthlyIncome + numberOfCPPMonths * monthlyIncomeCPP);

            decimal totalMonthlyExpenses = 0;
            //* Expenses
            foreach (BudgetItems.tttBudgetItemsRow tmpRow in dtsBudgetItems.tttBudgetItems.Rows)
            {
                decimal tmpAmount;
                decimal.TryParse(tmpRow[dtsBudgetItems.tttBudgetItems.ItemAmountColumn.Ordinal].ToString(), out tmpAmount);
                totalMonthlyExpenses += tmpAmount;
            }

            decimal totalYearlyExpenses = totalMonthlyExpenses * 12; 

            txtMonthlyExpenseTotal.Text = string.Format("{0:C}", totalMonthlyExpenses);
            txtYearlyExpenseTotal.Text = string.Format("{0:C}", totalYearlyExpenses);

            txtNetMonthlySavings.Text = string.Format("{0:C}", monthlyIncome - totalMonthlyExpenses);
            txtYearlyNetSavings.Text = string.Format("{0:C}", monthlyIncome*12 - totalMonthlyExpenses*12);

            //// SAVINGS TOTAL
            //txtMonthlySavingsTotal.Text = string.Format("{0:C}", monthlyIncomeTotal - totalMonthlyExpenses);
            //txtYearlySavingsTotal.Text = string.Format("{0:C}", yearlyIncomeTotal - totalYearlyExpenses);
        }

        private void dgvBudgetItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (bdsBudgetItems.Current != null)
            {
                ((DataRowView)bdsBudgetItems.Current).Row[dtsBudgetItems.tttBudgetItems.ColorColumn.Ordinal] = colorDialog1.Color.ToArgb();
            }
        }

        private void dgvBudgetItems_SelectionChanged(object sender, EventArgs e)
        {
            
            if (bdsBudgetItems.Current != null && ((DataRowView)bdsBudgetItems.Current).Row[dtsBudgetItems.tttBudgetItems.ColorColumn.Ordinal] != null
                && (((DataRowView)bdsBudgetItems.Current).Row[dtsBudgetItems.tttBudgetItems.ColorColumn.Ordinal].GetType() != typeof(DBNull)))
            {
                int theColor = (Int32)((DataRowView)bdsBudgetItems.Current).Row[dtsBudgetItems.tttBudgetItems.ColorColumn.Ordinal];
                panel1.BackColor = System.Drawing.Color.FromArgb(theColor);
            }
        }
    }
}
