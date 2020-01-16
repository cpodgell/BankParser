namespace BankParser.View
{
    partial class AnalysisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLoadChart = new System.Windows.Forms.Button();
            this.dtsExpenses = new BankParser.Model.DataSets.Expenses();
            this.bdsExpenses = new System.Windows.Forms.BindingSource(this.components);
            this.dtsCatagory = new BankParser.Model.DataSets.Catagory();
            this.bdsCatagory = new System.Windows.Forms.BindingSource(this.components);
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonth2 = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpYear = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountSaved = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalBudget = new System.Windows.Forms.TextBox();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.chkShowLegend = new System.Windows.Forms.CheckBox();
            this.chkIncudeFixed = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvExpenseItems = new System.Windows.Forms.DataGridView();
            this.bdsBudgetReadOnly = new System.Windows.Forms.BindingSource(this.components);
            this.dtsBudgetReadOnly = new BankParser.Model.DataSets.BudgetItems();
            this.grpAll = new System.Windows.Forms.GroupBox();
            this.cmsAnalysis = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSubCatagoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBudgetAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemExpenseAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.differenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtsExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.grpYear.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBudgetReadOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsBudgetReadOnly)).BeginInit();
            this.grpAll.SuspendLayout();
            this.cmsAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadChart
            // 
            this.btnLoadChart.Location = new System.Drawing.Point(32, 75);
            this.btnLoadChart.Name = "btnLoadChart";
            this.btnLoadChart.Size = new System.Drawing.Size(100, 23);
            this.btnLoadChart.TabIndex = 1;
            this.btnLoadChart.Text = "Load Chart";
            this.btnLoadChart.UseVisualStyleBackColor = true;
            this.btnLoadChart.Click += new System.EventHandler(this.btnLoadChart_Click);
            // 
            // dtsExpenses
            // 
            this.dtsExpenses.DataSetName = "Expenses";
            this.dtsExpenses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsExpenses
            // 
            this.bdsExpenses.DataMember = "tttExpenses";
            this.bdsExpenses.DataSource = this.dtsExpenses;
            // 
            // dtsCatagory
            // 
            this.dtsCatagory.DataSetName = "Catagory";
            this.dtsCatagory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCatagory
            // 
            this.bdsCatagory.DataMember = "tttCatagory";
            this.bdsCatagory.DataSource = this.dtsCatagory;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(50, 19);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 2;
            this.txtYear.Text = "2017";
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(207, 19);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 20);
            this.txtMonth.TabIndex = 3;
            this.txtMonth.Text = "8";
            // 
            // chart1
            // 
            lineAnnotation1.AllowMoving = true;
            lineAnnotation1.AllowPathEditing = true;
            lineAnnotation1.AllowTextEditing = true;
            lineAnnotation1.Name = "LineAnnotation1";
            this.chart1.Annotations.Add(lineAnnotation1);
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(458, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(797, 476);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.AnnotationPlaced += new System.EventHandler(this.chart1_AnnotationPlaced);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 22);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(161, 22);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(40, 13);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Month:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 108);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(15, 140);
            this.trackBar2.Maximum = 9;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Month 2:";
            // 
            // txtMonth2
            // 
            this.txtMonth2.Location = new System.Drawing.Point(207, 57);
            this.txtMonth2.Name = "txtMonth2";
            this.txtMonth2.Size = new System.Drawing.Size(100, 20);
            this.txtMonth2.TabIndex = 9;
            this.txtMonth2.Text = "9";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(247, 41);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(16, 13);
            this.to.TabIndex = 11;
            this.to.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "0 to ignore month or span";
            // 
            // grpYear
            // 
            this.grpYear.Controls.Add(this.label4);
            this.grpYear.Controls.Add(this.txtAmountSaved);
            this.grpYear.Controls.Add(this.label3);
            this.grpYear.Controls.Add(this.txtTotalBudget);
            this.grpYear.Controls.Add(this.lblTotalExpense);
            this.grpYear.Controls.Add(this.txtTotal);
            this.grpYear.Controls.Add(this.chkShowLegend);
            this.grpYear.Controls.Add(this.chkIncudeFixed);
            this.grpYear.Controls.Add(this.txtYear);
            this.grpYear.Controls.Add(this.label2);
            this.grpYear.Controls.Add(this.btnLoadChart);
            this.grpYear.Controls.Add(this.to);
            this.grpYear.Controls.Add(this.txtMonth);
            this.grpYear.Controls.Add(this.label1);
            this.grpYear.Controls.Add(this.lblYear);
            this.grpYear.Controls.Add(this.txtMonth2);
            this.grpYear.Controls.Add(this.lblMonth);
            this.grpYear.Controls.Add(this.trackBar2);
            this.grpYear.Controls.Add(this.trackBar1);
            this.grpYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpYear.Location = new System.Drawing.Point(3, 16);
            this.grpYear.Name = "grpYear";
            this.grpYear.Size = new System.Drawing.Size(452, 217);
            this.grpYear.TabIndex = 13;
            this.grpYear.TabStop = false;
            this.grpYear.Text = "Selectrion Criteria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Amount Saved";
            // 
            // txtAmountSaved
            // 
            this.txtAmountSaved.Location = new System.Drawing.Point(336, 160);
            this.txtAmountSaved.Name = "txtAmountSaved";
            this.txtAmountSaved.Size = new System.Drawing.Size(113, 20);
            this.txtAmountSaved.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total Budget";
            // 
            // txtTotalBudget
            // 
            this.txtTotalBudget.Location = new System.Drawing.Point(336, 108);
            this.txtTotalBudget.Name = "txtTotalBudget";
            this.txtTotalBudget.Size = new System.Drawing.Size(113, 20);
            this.txtTotalBudget.TabIndex = 17;
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.Location = new System.Drawing.Point(255, 137);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(75, 13);
            this.lblTotalExpense.TabIndex = 16;
            this.lblTotalExpense.Text = "Total Expense";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(336, 134);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(113, 20);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // chkShowLegend
            // 
            this.chkShowLegend.AutoSize = true;
            this.chkShowLegend.Location = new System.Drawing.Point(336, 18);
            this.chkShowLegend.Name = "chkShowLegend";
            this.chkShowLegend.Size = new System.Drawing.Size(92, 17);
            this.chkShowLegend.TabIndex = 14;
            this.chkShowLegend.Text = "Show Legend";
            this.chkShowLegend.UseVisualStyleBackColor = true;
            // 
            // chkIncudeFixed
            // 
            this.chkIncudeFixed.AutoSize = true;
            this.chkIncudeFixed.Checked = true;
            this.chkIncudeFixed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncudeFixed.Location = new System.Drawing.Point(336, 60);
            this.chkIncudeFixed.Name = "chkIncudeFixed";
            this.chkIncudeFixed.Size = new System.Drawing.Size(118, 17);
            this.chkIncudeFixed.TabIndex = 13;
            this.chkIncudeFixed.Text = "Include Fixed Costs";
            this.chkIncudeFixed.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvExpenseItems);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 607);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvExpenseItems
            // 
            this.dgvExpenseItems.AllowUserToAddRows = false;
            this.dgvExpenseItems.AutoGenerateColumns = false;
            this.dgvExpenseItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemType,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemBudgetAmountDataGridViewTextBoxColumn,
            this.itemExpenseAmountDataGridViewTextBoxColumn,
            this.differenceDataGridViewTextBoxColumn});
            this.dgvExpenseItems.DataSource = this.bdsBudgetReadOnly;
            this.dgvExpenseItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenseItems.Location = new System.Drawing.Point(3, 16);
            this.dgvExpenseItems.Name = "dgvExpenseItems";
            this.dgvExpenseItems.ReadOnly = true;
            this.dgvExpenseItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenseItems.ShowEditingIcon = false;
            this.dgvExpenseItems.Size = new System.Drawing.Size(446, 588);
            this.dgvExpenseItems.TabIndex = 1;
            this.dgvExpenseItems.Sorted += new System.EventHandler(this.dgvExpenseItems_Sorted);
            // 
            // bdsBudgetReadOnly
            // 
            this.bdsBudgetReadOnly.DataMember = "tttBudgetItemsReadOnly";
            this.bdsBudgetReadOnly.DataSource = this.dtsBudgetReadOnly;
            // 
            // dtsBudgetReadOnly
            // 
            this.dtsBudgetReadOnly.DataSetName = "BudgetItems";
            this.dtsBudgetReadOnly.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpAll
            // 
            this.grpAll.Controls.Add(this.groupBox1);
            this.grpAll.Controls.Add(this.grpYear);
            this.grpAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpAll.Location = new System.Drawing.Point(0, 0);
            this.grpAll.Name = "grpAll";
            this.grpAll.Size = new System.Drawing.Size(458, 843);
            this.grpAll.TabIndex = 15;
            this.grpAll.TabStop = false;
            // 
            // cmsAnalysis
            // 
            this.cmsAnalysis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showExpensesToolStripMenuItem,
            this.showSubCatagoryToolStripMenuItem});
            this.cmsAnalysis.Name = "cmsAnalysis";
            this.cmsAnalysis.Size = new System.Drawing.Size(178, 48);
            // 
            // showExpensesToolStripMenuItem
            // 
            this.showExpensesToolStripMenuItem.Name = "showExpensesToolStripMenuItem";
            this.showExpensesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.showExpensesToolStripMenuItem.Text = "Show Expenses";
            // 
            // showSubCatagoryToolStripMenuItem
            // 
            this.showSubCatagoryToolStripMenuItem.Name = "showSubCatagoryToolStripMenuItem";
            this.showSubCatagoryToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.showSubCatagoryToolStripMenuItem.Text = "Show Sub Catagory";
            this.showSubCatagoryToolStripMenuItem.Click += new System.EventHandler(this.showSubCatagoryToolStripMenuItem_Click);
            // 
            // ItemType
            // 
            this.ItemType.DataPropertyName = "ItemType";
            this.ItemType.HeaderText = "ItemType";
            this.ItemType.Name = "ItemType";
            this.ItemType.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemBudgetAmountDataGridViewTextBoxColumn
            // 
            this.itemBudgetAmountDataGridViewTextBoxColumn.DataPropertyName = "ItemBudgetAmount";
            dataGridViewCellStyle1.Format = "C2";
            this.itemBudgetAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.itemBudgetAmountDataGridViewTextBoxColumn.HeaderText = "ItemBudgetAmount";
            this.itemBudgetAmountDataGridViewTextBoxColumn.Name = "itemBudgetAmountDataGridViewTextBoxColumn";
            this.itemBudgetAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemExpenseAmountDataGridViewTextBoxColumn
            // 
            this.itemExpenseAmountDataGridViewTextBoxColumn.DataPropertyName = "ItemExpenseAmount";
            dataGridViewCellStyle2.Format = "C2";
            this.itemExpenseAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemExpenseAmountDataGridViewTextBoxColumn.HeaderText = "ItemExpenseAmount";
            this.itemExpenseAmountDataGridViewTextBoxColumn.Name = "itemExpenseAmountDataGridViewTextBoxColumn";
            this.itemExpenseAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // differenceDataGridViewTextBoxColumn
            // 
            this.differenceDataGridViewTextBoxColumn.DataPropertyName = "Difference";
            dataGridViewCellStyle3.Format = "C2";
            this.differenceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.differenceDataGridViewTextBoxColumn.HeaderText = "Difference";
            this.differenceDataGridViewTextBoxColumn.Name = "differenceDataGridViewTextBoxColumn";
            this.differenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 843);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.grpAll);
            this.Name = "AnalysisForm";
            this.Text = "AnalysisForm";
            this.Load += new System.EventHandler(this.AnalysisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.grpYear.ResumeLayout(false);
            this.grpYear.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBudgetReadOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsBudgetReadOnly)).EndInit();
            this.grpAll.ResumeLayout(false);
            this.cmsAnalysis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoadChart;
        private System.Windows.Forms.BindingSource bdsExpenses;
        private Model.DataSets.Expenses dtsExpenses;
        private Model.DataSets.Catagory dtsCatagory;
        private System.Windows.Forms.BindingSource bdsCatagory;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonth2;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvExpenseItems;
        private System.Windows.Forms.CheckBox chkIncudeFixed;
        private System.Windows.Forms.CheckBox chkShowLegend;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsBudgetReadOnly;
        private Model.DataSets.BudgetItems dtsBudgetReadOnly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmountSaved;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalBudget;
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.GroupBox grpAll;
        private System.Windows.Forms.ContextMenuStrip cmsAnalysis;
        private System.Windows.Forms.ToolStripMenuItem showExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSubCatagoryToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBudgetAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemExpenseAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn differenceDataGridViewTextBoxColumn;
    }
}