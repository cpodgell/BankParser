using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankParser.Model.DataSets;
using System.Diagnostics;
using BankParser.Utils;
using System.Windows.Forms.DataVisualization.Charting;

namespace BankParser.View
{
    public partial class AnalysisForm : Form
    {
        Model.DataSets.BudgetItems dtsChartBudget = new Model.DataSets.BudgetItems();

        int year;
        int month;
        int month2;
        int monthSpan;
        decimal grandTotal;


        public AnalysisForm()
        {
            InitializeComponent();
        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {
           
        }

        public void LoadChartData()
        {
            grandTotal = 0;
            int.TryParse(txtMonth.Text, out month);
            int.TryParse(txtYear.Text, out year);
            int.TryParse(txtMonth2.Text, out month2);

            monthSpan = 1+month2 - month;

            //We use the datastructure of the budget so we can get all the 'budget items' and then put the totals into it.
            Model.BudgetFormModel.GetBudgetData(ref dtsChartBudget);

            // zero all the values because this is for the budget of the expenses
            foreach (BudgetItems.tttBudgetItemsRow dtrBudg in dtsChartBudget.tttBudgetItems.Rows)
            {
                //Only zero variable values.  Fixed need to be timed by the span of months.
                if (dtrBudg[dtsChartBudget.tttBudgetItems.ItemTypeColumn.Ordinal].ToString() == "Variable" || chkIncudeFixed.Checked == false)
                {
                    dtrBudg[dtsChartBudget.tttBudgetItems.ItemAmountColumn.Ordinal] = 0;
                }
                else
                {
                    dtrBudg[dtsChartBudget.tttBudgetItems.ItemAmountColumn.Ordinal] = monthSpan * (decimal)dtrBudg[dtsChartBudget.tttBudgetItems.ItemAmountColumn.Ordinal];
                    grandTotal = grandTotal + monthSpan * (decimal)dtrBudg[dtsChartBudget.tttBudgetItems.ItemAmountColumn.Ordinal];
                }
            }

            //Lets populate the totals of the budget table.
            foreach (BudgetItems.tttBudgetItemsRow dtrBudg in dtsChartBudget.tttBudgetItems.Rows)
            {
                // Do not include ignored items (might be stuff that was re-imbursed through work, etc.
                if ("Ignore" != dtrBudg[dtsChartBudget.tttBudgetItems.ItemNameColumn.Ordinal].ToString())
                {
                    foreach (Expenses.tttExpensesRow dtrExpenses in dtsExpenses.tttExpenses.Rows)
                    {
                        DateTime dttCurrent = (DateTime)dtrExpenses[dtsExpenses.tttExpenses.TransactionDateColumn.Ordinal];
                        string budgetItemName = dtrBudg[dtsChartBudget.tttBudgetItems.ItemNameColumn.Ordinal].ToString();
                        string expenseItemName = dtrExpenses[dtsExpenses.tttExpenses.CatagoryColumn.Ordinal].ToString();

                        if (budgetItemName.Equals(expenseItemName))
                        {
                            if (year == 0 || year == dttCurrent.Year)
                            {
                                if (month == 0 || (month <= dttCurrent.Month && month2 >= dttCurrent.Month))
                                {
                                    decimal currentBudgetAmount = (decimal)dtrBudg[dtsChartBudget.tttBudgetItems.ItemAmountColumn.Ordinal];
                                    decimal currentExpensesItemAmount = (decimal)dtrExpenses[dtsExpenses.tttExpenses._CAD_Column.Ordinal];
                                    decimal total = currentBudgetAmount + currentExpensesItemAmount;
                                    dtrBudg[dtsChartBudget.tttBudgetItems.ItemAmountColumn.Ordinal] = currentBudgetAmount + currentExpensesItemAmount;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ApplyChart()
        {
            this.chart1.Series.Clear();
            this.chart1.Titles.Clear();

            dtsChartBudget.tttBudgetItems.DefaultView.Sort = dtsChartBudget.tttBudgetItems.ItemTypeColumn.ColumnName + " ASC";

            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();



            Title t = new Title("Title Here", Docking.Top, new Font("Verdana", 12), Color.Black);
            chart1.Titles.Add(t);

            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            //series1.Legend = "" + year + DataUtils.GetMonthFromNumber(month) + " - " + DataUtils.GetMonthFromNumber(month);
            series1.Name = "Series1";
            series1.Label = "#VALX : #VALY{$#,###.##}";
            series1.LegendText = "#VALX #VALY";
            
            this.chart1.Series.Add(series1);

            if (!chkShowLegend.Checked)
            {
                this.chart1.Series["Series1"].IsVisibleInLegend = false;
            }

            this.chart1.Series["Series1"]["PieLabelStyle"] = "Outside";


            
            int index = 0;

            DataRow[] rowList = dtsChartBudget.tttBudgetItems.Select("", dtsChartBudget.tttBudgetItems.ItemTypeColumn.ColumnName + " ASC");
            foreach (BudgetItems.tttBudgetItemsRow dtrBudg in rowList)
            {
                string currentItem = dtrBudg[dtsChartBudget.tttBudgetItems.ItemNameColumn.Ordinal].ToString();
                decimal amount = (decimal)dtrBudg[dtsChartBudget.tttBudgetItems.ItemAmountColumn.Ordinal];
                int assignedColor = -123456;
                if (amount != 0)
                {
                    this.chart1.Series["Series1"].Points.AddXY(currentItem, amount);
                    if (dtrBudg[dtsChartBudget.tttBudgetItems.ColorColumn.Ordinal].GetType() != typeof(System.DBNull))
                    {
                        assignedColor = (Int32)dtrBudg[dtsChartBudget.tttBudgetItems.ColorColumn.Ordinal];
                        
                    }
                    this.chart1.Series["Series1"].Points[index].Color = System.Drawing.Color.FromArgb(assignedColor);
                    index++;
                }
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void chart1_AnnotationPlaced(object sender, EventArgs e)
        {
            Trace.WriteLine("AnnotationPlaced");
        }

        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            dtsExpenses.Clear();
            dtsCatagory.Clear();

            Controller.ExpenseFormController.GetExpenseData(ref dtsExpenses);
            Controller.CatagoryAssignController.GetData(ref dtsCatagory);

            Controller.CatagoryAssignController.PropogateExpenseCatagory(dtsExpenses, dtsCatagory);

            LoadChartData();
            LoadBudgetReadOnlyData();
            CalculateGrandTotal();

            ApplyChart();
        }

        private void CalculateGrandTotal()
        {
            decimal grandTotalExpense = 0;
            decimal grandTotalBudget = 0;
            decimal grandTotalSaved = 0;
            foreach (BudgetItems.tttBudgetItemsReadOnlyRow dtrRow in dtsBudgetReadOnly.tttBudgetItemsReadOnly.Rows)
            {
                grandTotalExpense += (decimal)dtrRow[dtsBudgetReadOnly.tttBudgetItemsReadOnly.ItemExpenseAmountColumn.Ordinal];
                grandTotalBudget += (decimal)dtrRow[dtsBudgetReadOnly.tttBudgetItemsReadOnly.ItemBudgetAmountColumn.Ordinal];
                grandTotalSaved = grandTotalBudget - grandTotalExpense;
            }
            txtTotal.Text = String.Format("{0:C}", grandTotalExpense);
            txtTotalBudget.Text = String.Format("{0:C}", grandTotalBudget);
            txtAmountSaved.Text = String.Format("{0:C}", grandTotalSaved);

            if((grandTotalSaved) >= 0)
            {
                txtAmountSaved.ForeColor = Color.Green;
            }
            else
            {
                txtAmountSaved.ForeColor = Color.Red;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.chart1.ChartAreas[0].InnerPlotPosition.Width = 10* trackBar1.Value;
            this.chart1.ChartAreas[0].InnerPlotPosition.Height = 10 * trackBar1.Value;
            
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            this.chart1.ChartAreas[0].Area3DStyle.Inclination = 10 * trackBar2.Value;
            this.chart1.ChartAreas[0].Area3DStyle.Rotation = 10 * trackBar2.Value;
        }


        private void LoadBudgetReadOnlyData()
        {
            BudgetItems originalBudget = new BudgetItems();
            Model.BudgetFormModel.GetBudgetData(ref originalBudget);

            dtsBudgetReadOnly.Clear();
            foreach (BudgetItems.tttBudgetItemsRow dtrBudg in dtsChartBudget.tttBudgetItems.Rows)
            {
                AddReadOnlyTotalRow(dtrBudg, originalBudget);
            }
            ColorDataGridViewCells();
        }

        private void AddReadOnlyTotalRow(BudgetItems.tttBudgetItemsRow expenseRow, BudgetItems originalBudget)
        {
            //BudgetItems.tttBudgetItemsRow btRow = dtsBudgetReadOnly.tttBudgetItems.NewtttBudgetItemsRow()
            string itemName = expenseRow[dtsChartBudget.tttBudgetItems.ItemNameColumn].ToString();

            decimal itemAmount = (decimal) expenseRow[dtsChartBudget.tttBudgetItems.ItemAmountColumn];
            decimal itemBudgetAmount = 0;
            string itemType = "";
            //itemExpenseAmount = (decimal) 1.99;

            foreach(BudgetItems.tttBudgetItemsRow bdgRow in originalBudget.tttBudgetItems)
            {
                if(bdgRow[originalBudget.tttBudgetItems.ItemNameColumn.Ordinal].ToString() == itemName)
                {
                    itemBudgetAmount = (decimal)bdgRow[originalBudget.tttBudgetItems.ItemAmountColumn.Ordinal];
                    itemType = (string)bdgRow[originalBudget.tttBudgetItems.ItemTypeColumn.Ordinal];
                }
            }

            decimal itemBudgetAmountSpan = itemBudgetAmount * monthSpan;

            decimal difference = itemAmount - itemBudgetAmountSpan;

            dtsBudgetReadOnly.tttBudgetItemsReadOnly.AddtttBudgetItemsReadOnlyRow(itemName, itemBudgetAmountSpan,  itemType, 0, itemAmount, difference);
        }

        private void ColorDataGridViewCells()
        {
            foreach(DataGridViewRow dgvRow in dgvExpenseItems.Rows)
            {
                if ((decimal)((DataRowView)dgvRow.DataBoundItem).Row[dtsBudgetReadOnly.tttBudgetItemsReadOnly.DifferenceColumn.Ordinal] <= 0)
                {
                    dgvRow.Cells["differenceDataGridViewTextBoxColumn"].Style.ForeColor = Color.Green;
                }
                else
                {
                    dgvRow.Cells["differenceDataGridViewTextBoxColumn"].Style.ForeColor = Color.Red;
                }
            }
        }

        private void dgvExpenseItems_Sorted(object sender, EventArgs e)
        {
            ColorDataGridViewCells();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void showSubCatagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
