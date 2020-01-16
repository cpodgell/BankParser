namespace BankParser.View
{
    partial class BudgetForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBudgetItems = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsItemTypes = new System.Windows.Forms.BindingSource(this.components);
            this.dtsItemTypes = new BankParser.Model.DataSets.ItemTypes();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsBudgetItems = new System.Windows.Forms.BindingSource(this.components);
            this.dtsBudgetItems = new BankParser.Model.DataSets.BudgetItems();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMonthlyIncome = new System.Windows.Forms.Label();
            this.txtMonthlyIncome = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblMonthNumber = new System.Windows.Forms.Label();
            this.txtMonthsCPP = new System.Windows.Forms.TextBox();
            this.txtMonthlyCPPIncome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtYearlyTotal = new System.Windows.Forms.TextBox();
            this.lblYearlyTotal = new System.Windows.Forms.Label();
            this.txtMonthlyExpenseTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYearlyExpenseTotal = new System.Windows.Forms.TextBox();
            this.lblYearlyExpenseTotal = new System.Windows.Forms.Label();
            this.txtYearlySavingsTotal = new System.Windows.Forms.TextBox();
            this.lblYearlySavingsTotal = new System.Windows.Forms.Label();
            this.txtMonthlySavingsTotal = new System.Windows.Forms.TextBox();
            this.lblMonthlySavings = new System.Windows.Forms.Label();
            this.bdsIncome = new System.Windows.Forms.BindingSource(this.components);
            this.dtsIncome = new BankParser.Model.DataSets.Income();
            this.txtNetMonthlySavings = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYearlyNetSavings = new System.Windows.Forms.TextBox();
            this.lblYearlyNetSavings = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItemTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsItemTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBudgetItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsBudgetItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBudgetItems);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 580);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvBudgetItems
            // 
            this.dgvBudgetItems.AutoGenerateColumns = false;
            this.dgvBudgetItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBudgetItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBudgetItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemAmountDataGridViewTextBoxColumn,
            this.itemTypeDataGridViewTextBoxColumn,
            this.Color});
            this.dgvBudgetItems.DataSource = this.bdsBudgetItems;
            this.dgvBudgetItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBudgetItems.Location = new System.Drawing.Point(3, 16);
            this.dgvBudgetItems.Name = "dgvBudgetItems";
            this.dgvBudgetItems.Size = new System.Drawing.Size(647, 561);
            this.dgvBudgetItems.TabIndex = 0;
            this.dgvBudgetItems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvBudgetItems_DataError);
            this.dgvBudgetItems.SelectionChanged += new System.EventHandler(this.dgvBudgetItems_SelectionChanged);
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "ItemCode";
            this.ItemCode.Name = "ItemCode";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemAmountDataGridViewTextBoxColumn
            // 
            this.itemAmountDataGridViewTextBoxColumn.DataPropertyName = "ItemAmount";
            dataGridViewCellStyle2.Format = "c2";
            this.itemAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemAmountDataGridViewTextBoxColumn.HeaderText = "ItemAmount";
            this.itemAmountDataGridViewTextBoxColumn.Name = "itemAmountDataGridViewTextBoxColumn";
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.DataSource = this.bdsItemTypes;
            this.itemTypeDataGridViewTextBoxColumn.DisplayMember = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            this.itemTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemTypeDataGridViewTextBoxColumn.ValueMember = "ItemType";
            // 
            // bdsItemTypes
            // 
            this.bdsItemTypes.DataMember = "tttItemTypes";
            this.bdsItemTypes.DataSource = this.dtsItemTypes;
            // 
            // dtsItemTypes
            // 
            this.dtsItemTypes.DataSetName = "ItemTypes";
            this.dtsItemTypes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            // 
            // bdsBudgetItems
            // 
            this.bdsBudgetItems.DataMember = "tttBudgetItems";
            this.bdsBudgetItems.DataSource = this.dtsBudgetItems;
            // 
            // dtsBudgetItems
            // 
            this.dtsBudgetItems.DataSetName = "BudgetItems";
            this.dtsBudgetItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(339, 22);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMonthlyIncome
            // 
            this.lblMonthlyIncome.AutoSize = true;
            this.lblMonthlyIncome.Location = new System.Drawing.Point(671, 56);
            this.lblMonthlyIncome.Name = "lblMonthlyIncome";
            this.lblMonthlyIncome.Size = new System.Drawing.Size(85, 13);
            this.lblMonthlyIncome.TabIndex = 4;
            this.lblMonthlyIncome.Text = "Montlhy Income:";
            // 
            // txtMonthlyIncome
            // 
            this.txtMonthlyIncome.Location = new System.Drawing.Point(797, 54);
            this.txtMonthlyIncome.Name = "txtMonthlyIncome";
            this.txtMonthlyIncome.Size = new System.Drawing.Size(112, 20);
            this.txtMonthlyIncome.TabIndex = 6;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(923, 53);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(112, 20);
            this.txtMonth.TabIndex = 5;
            // 
            // lblMonthNumber
            // 
            this.lblMonthNumber.AutoSize = true;
            this.lblMonthNumber.Location = new System.Drawing.Point(920, 37);
            this.lblMonthNumber.Name = "lblMonthNumber";
            this.lblMonthNumber.Size = new System.Drawing.Size(45, 13);
            this.lblMonthNumber.TabIndex = 2;
            this.lblMonthNumber.Text = "Months:";
            // 
            // txtMonthsCPP
            // 
            this.txtMonthsCPP.Location = new System.Drawing.Point(923, 80);
            this.txtMonthsCPP.Name = "txtMonthsCPP";
            this.txtMonthsCPP.Size = new System.Drawing.Size(112, 20);
            this.txtMonthsCPP.TabIndex = 9;
            // 
            // txtMonthlyCPPIncome
            // 
            this.txtMonthlyCPPIncome.Location = new System.Drawing.Point(797, 80);
            this.txtMonthlyCPPIncome.Name = "txtMonthlyCPPIncome";
            this.txtMonthlyCPPIncome.Size = new System.Drawing.Size(112, 20);
            this.txtMonthlyCPPIncome.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Monthly Income CPP:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(1093, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 22);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtYearlyTotal
            // 
            this.txtYearlyTotal.Location = new System.Drawing.Point(797, 125);
            this.txtYearlyTotal.Name = "txtYearlyTotal";
            this.txtYearlyTotal.ReadOnly = true;
            this.txtYearlyTotal.Size = new System.Drawing.Size(112, 20);
            this.txtYearlyTotal.TabIndex = 11;
            // 
            // lblYearlyTotal
            // 
            this.lblYearlyTotal.AutoSize = true;
            this.lblYearlyTotal.Location = new System.Drawing.Point(713, 128);
            this.lblYearlyTotal.Name = "lblYearlyTotal";
            this.lblYearlyTotal.Size = new System.Drawing.Size(66, 13);
            this.lblYearlyTotal.TabIndex = 10;
            this.lblYearlyTotal.Text = "Yearly Total:";
            // 
            // txtMonthlyExpenseTotal
            // 
            this.txtMonthlyExpenseTotal.Location = new System.Drawing.Point(171, 623);
            this.txtMonthlyExpenseTotal.Name = "txtMonthlyExpenseTotal";
            this.txtMonthlyExpenseTotal.ReadOnly = true;
            this.txtMonthlyExpenseTotal.Size = new System.Drawing.Size(176, 20);
            this.txtMonthlyExpenseTotal.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 630);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Monthly Expense Total:";
            // 
            // txtYearlyExpenseTotal
            // 
            this.txtYearlyExpenseTotal.Location = new System.Drawing.Point(171, 653);
            this.txtYearlyExpenseTotal.Name = "txtYearlyExpenseTotal";
            this.txtYearlyExpenseTotal.ReadOnly = true;
            this.txtYearlyExpenseTotal.Size = new System.Drawing.Size(176, 20);
            this.txtYearlyExpenseTotal.TabIndex = 19;
            // 
            // lblYearlyExpenseTotal
            // 
            this.lblYearlyExpenseTotal.AutoSize = true;
            this.lblYearlyExpenseTotal.Location = new System.Drawing.Point(47, 656);
            this.lblYearlyExpenseTotal.Name = "lblYearlyExpenseTotal";
            this.lblYearlyExpenseTotal.Size = new System.Drawing.Size(110, 13);
            this.lblYearlyExpenseTotal.TabIndex = 18;
            this.lblYearlyExpenseTotal.Text = "Yearly Expense Total:";
            // 
            // txtYearlySavingsTotal
            // 
            this.txtYearlySavingsTotal.Location = new System.Drawing.Point(834, 236);
            this.txtYearlySavingsTotal.Name = "txtYearlySavingsTotal";
            this.txtYearlySavingsTotal.ReadOnly = true;
            this.txtYearlySavingsTotal.Size = new System.Drawing.Size(180, 20);
            this.txtYearlySavingsTotal.TabIndex = 15;
            // 
            // lblYearlySavingsTotal
            // 
            this.lblYearlySavingsTotal.AutoSize = true;
            this.lblYearlySavingsTotal.Location = new System.Drawing.Point(721, 239);
            this.lblYearlySavingsTotal.Name = "lblYearlySavingsTotal";
            this.lblYearlySavingsTotal.Size = new System.Drawing.Size(107, 13);
            this.lblYearlySavingsTotal.TabIndex = 14;
            this.lblYearlySavingsTotal.Text = "Yearly Savings Total:";
            // 
            // txtMonthlySavingsTotal
            // 
            this.txtMonthlySavingsTotal.Location = new System.Drawing.Point(834, 210);
            this.txtMonthlySavingsTotal.Name = "txtMonthlySavingsTotal";
            this.txtMonthlySavingsTotal.ReadOnly = true;
            this.txtMonthlySavingsTotal.Size = new System.Drawing.Size(180, 20);
            this.txtMonthlySavingsTotal.TabIndex = 13;
            // 
            // lblMonthlySavings
            // 
            this.lblMonthlySavings.AutoSize = true;
            this.lblMonthlySavings.Location = new System.Drawing.Point(713, 214);
            this.lblMonthlySavings.Name = "lblMonthlySavings";
            this.lblMonthlySavings.Size = new System.Drawing.Size(115, 13);
            this.lblMonthlySavings.TabIndex = 12;
            this.lblMonthlySavings.Text = "Monthly Savings Total:";
            // 
            // bdsIncome
            // 
            this.bdsIncome.DataMember = "tttIncome";
            this.bdsIncome.DataSource = this.dtsIncome;
            // 
            // dtsIncome
            // 
            this.dtsIncome.DataSetName = "Income";
            this.dtsIncome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNetMonthlySavings
            // 
            this.txtNetMonthlySavings.Location = new System.Drawing.Point(171, 695);
            this.txtNetMonthlySavings.Name = "txtNetMonthlySavings";
            this.txtNetMonthlySavings.ReadOnly = true;
            this.txtNetMonthlySavings.Size = new System.Drawing.Size(180, 20);
            this.txtNetMonthlySavings.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 698);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Monthly Net Savings Total:";
            // 
            // txtYearlyNetSavings
            // 
            this.txtYearlyNetSavings.Location = new System.Drawing.Point(171, 721);
            this.txtYearlyNetSavings.Name = "txtYearlyNetSavings";
            this.txtYearlyNetSavings.ReadOnly = true;
            this.txtYearlyNetSavings.Size = new System.Drawing.Size(180, 20);
            this.txtYearlyNetSavings.TabIndex = 23;
            // 
            // lblYearlyNetSavings
            // 
            this.lblYearlyNetSavings.AutoSize = true;
            this.lblYearlyNetSavings.Location = new System.Drawing.Point(30, 724);
            this.lblYearlyNetSavings.Name = "lblYearlyNetSavings";
            this.lblYearlyNetSavings.Size = new System.Drawing.Size(127, 13);
            this.lblYearlyNetSavings.TabIndex = 22;
            this.lblYearlyNetSavings.Text = "Yearly Net Savings Total:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(705, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 69);
            this.panel1.TabIndex = 25;
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 785);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtYearlyNetSavings);
            this.Controls.Add(this.lblYearlyNetSavings);
            this.Controls.Add(this.txtNetMonthlySavings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYearlySavingsTotal);
            this.Controls.Add(this.lblYearlySavingsTotal);
            this.Controls.Add(this.txtMonthlySavingsTotal);
            this.Controls.Add(this.lblMonthlySavings);
            this.Controls.Add(this.txtYearlyExpenseTotal);
            this.Controls.Add(this.lblYearlyExpenseTotal);
            this.Controls.Add(this.txtMonthlyExpenseTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYearlyTotal);
            this.Controls.Add(this.lblYearlyTotal);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtMonthsCPP);
            this.Controls.Add(this.txtMonthlyCPPIncome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMonthNumber);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtMonthlyIncome);
            this.Controls.Add(this.lblMonthlyIncome);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "BudgetForm";
            this.Text = "BudgetForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsItemTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsItemTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBudgetItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsBudgetItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBudgetItems;
        private System.Windows.Forms.BindingSource bdsBudgetItems;
        private BankParser.Model.DataSets.BudgetItems dtsBudgetItems;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bdsItemTypes;
        private BankParser.Model.DataSets.ItemTypes dtsItemTypes;
        private System.Windows.Forms.Label lblMonthlyIncome;
        private System.Windows.Forms.TextBox txtMonthlyIncome;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblMonthNumber;
        private System.Windows.Forms.TextBox txtMonthsCPP;
        private System.Windows.Forms.TextBox txtMonthlyCPPIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtYearlyTotal;
        private System.Windows.Forms.Label lblYearlyTotal;
        private System.Windows.Forms.TextBox txtMonthlyExpenseTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYearlyExpenseTotal;
        private System.Windows.Forms.Label lblYearlyExpenseTotal;
        private System.Windows.Forms.TextBox txtYearlySavingsTotal;
        private System.Windows.Forms.Label lblYearlySavingsTotal;
        private System.Windows.Forms.TextBox txtMonthlySavingsTotal;
        private System.Windows.Forms.Label lblMonthlySavings;
        private System.Windows.Forms.BindingSource bdsIncome;
        private BankParser.Model.DataSets.Income dtsIncome;
        private System.Windows.Forms.TextBox txtNetMonthlySavings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYearlyNetSavings;
        private System.Windows.Forms.Label lblYearlyNetSavings;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}