using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;

namespace BankParser
{
    public partial class Form1 : Form
    {
        List<string> categories = new List<string>();

        string[] Months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }; 

        DataTable csvDataTable;

        public Form1()
        {
            InitializeComponent();

            //TESTING TO SHOW HOW CHART WORKS
            /*
            DataTable dt = new DataTable();
            dt.Columns.Add("Month", typeof(string));
            dt.Columns.Add("Values", typeof(decimal));


            dt.Rows.Add("Jan", 10.00);
            dt.Rows.Add("Feb", 30.01);
            dt.Rows.Add("Mar", 20);
            dt.Rows.Add("Apr", 40);
            dt.Rows.Add("May", 60);
            dt.Rows.Add("Jun", 55);
            dt.Rows.Add("Jul", 65);
            dt.Rows.Add("Aug", 70);
            dt.Rows.Add("Sep", 60);
            dt.Rows.Add("Oct", 40);
            dt.Rows.Add("Nov", 45);
            dt.Rows.Add("Dec", 50);

            ultraChart1.DataSource = dt;
            ultraChart1.PieChart.Labels.FormatString = "<ITEM_LABEL> : $<DATA_VALUE>";
            ultraChart1.Data.IncludeColumn(0, true);

            Color[] ChartColors = new Color[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet };

            ultraChart1.ColorModel.CustomPalette = ChartColors; 
             * */

            //ultraChart1.Data.SwapRowsAndColumns = true;
            //ultraChart1.LineChart.NullHandling = Infragistics.UltraChart.Shared.Styles.NullHandling.DontPlot;

            CollectCategories();
        }

        private void CollectCategories()
        {
            
            foreach (ToolStripItem tsi in ((ToolStripMenuItem)cmsAll.Items[0]).DropDownItems)
            {
                categories.Add(tsi.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dgvRecordList.DataSource = Model.ExpenseFormModel.GetCSVData();

        }


        private void foodToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MapCatagory("Food");
            
        }

        private void entertainmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MapCatagory("Entertainment");
            
        }

        private void travelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MapCatagory("Travel");
            
        }

        private void restaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapCatagory("Restaurant");
        }

        private void btnWriteMappings_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to write?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                 == DialogResult.Yes)
            {
                pdsCatagoryMapping.ttiCatagories.WriteXml(@"D:\DeveoProjects\BankParser\BankParser\bankFiles\Catagories.xml");
            }
        }

        private void btnImportMappings_Click(object sender, EventArgs e)
        {
            pdsCatagoryMapping.Clear();
            pdsCatagoryMapping.ttiCatagories.ReadXml(@"D:\DeveoProjects\BankParser\BankParser\bankFiles\Catagories.xml");
        }

        public void MapCatagory(string catagory)
        {
            DataGridView tmpDataGrid = (DataGridView)currentSourceControl;
            if (tmpDataGrid.Equals(dgvRecordList))
            {
                if (tmpDataGrid.SelectedRows.Count != 0)
                {
                    TextSelection textForm = new TextSelection();
                    textForm.ProductName = (string)((DataRowView)tmpDataGrid.SelectedRows[0].DataBoundItem).Row["Decription 1"];
                    if (textForm.ShowDialog() == DialogResult.OK)
                    {
                        CatagoryMapping.ttiCatagoriesRow dtrCatagoryRow = pdsCatagoryMapping.ttiCatagories.NewttiCatagoriesRow();
                        dtrCatagoryRow[0] = textForm.ProductName;
                        dtrCatagoryRow[1] = catagory;
                        pdsCatagoryMapping.ttiCatagories.AddttiCatagoriesRow(dtrCatagoryRow);
                    }
                }
            }
            else
            {
                if (tmpDataGrid.SelectedRows.Count != 0)
                {
                    TextSelection textForm = new TextSelection();
                    textForm.ProductName = (string)((DataRowView)tmpDataGrid.SelectedRows[0].DataBoundItem).Row["Decription 1"];
                    if (textForm.ShowDialog() == DialogResult.OK)
                    {
                        ((DataRowView)tmpDataGrid.SelectedRows[0].DataBoundItem).Row["Decription 1"] = textForm.ProductName;
                    }
                }
            }
        }

        /// <summary>
        /// Applies all the mappings from the catagories to the actual BUDGET csv side.
        /// </summary>
        public void ApplyCatagoryMappings()
        {
            if (dgvRecordList.DataSource != null)
            {
                foreach (CatagoryMapping.ttiCatagoriesRow dgrCatagoryRow in pdsCatagoryMapping.ttiCatagories.Rows)
                {
                    foreach (DataRow dtrRow in ((DataTable)dgvRecordList.DataSource).Rows)
                    {
                        if (dtrRow["Decription 1"].ToString().Contains(dgrCatagoryRow[pdsCatagoryMapping.ttiCatagories.ProductNameColumn.Ordinal].ToString()))
                        {
                            dtrRow["Category"] = dgrCatagoryRow[pdsCatagoryMapping.ttiCatagories.CatagoryColumn.Ordinal];
                        }
                    }
                }
            }
        }

        private void btnApplyCatagory_Click(object sender, EventArgs e)
        {
            ApplyCatagoryMappings();
        }

        DataGridView currentSourceControl;

        private void cmsAll_Opening(object sender, CancelEventArgs e)
        {
            currentSourceControl = (DataGridView)cmsAll.SourceControl;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCatagoryMapping.SelectedRows.Count != 0)
            {
                ((DataRowView)dgvCatagoryMapping.SelectedRows[0].DataBoundItem).Row.Delete();
                pdsCatagoryMapping.AcceptChanges();
                this.BringToFront();
            }
        }

        private void fitnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapCatagory("Fitness");
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapCatagory("product");
        }

        private void clothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapCatagory("Clothing");
        }

        private void miscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapCatagory("Misc.");
        }

        private void fixedCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapCatagory("Fixed Cost");
        }

        private void drugStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapCatagory("Drug Store");
        }

        private void hairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapCatagory("Hair");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
        }

        
        private void btnCalculateCategory_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Total Amount", typeof(decimal));

            foreach (string category in categories)
            {
                decimal monthTotal = 0;
                foreach (DataRow dtrRow in csvDataTable.Rows)
                {

                    if ((dtrRow[4] != DBNull.Value))
                    {
                        string tmpCategory = (string)dtrRow["Category"];
                        if (tmpCategory.Contains(category))
                        {


                            Decimal currentDecimal;
                            if (Decimal.TryParse(dtrRow[2].ToString(), out currentDecimal))
                            {
                                monthTotal = monthTotal + currentDecimal;
                            }

                        }
                    }
                }
                dt.Rows.Add(category, monthTotal);
            }

            Color[] ChartColors = new Color[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet };
        }
       

      }
    }

