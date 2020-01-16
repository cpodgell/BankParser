namespace BankParser.View
{
    partial class ExpenseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBudgetItems = new System.Windows.Forms.DataGridView();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniqueExpenseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsExpenses = new System.Windows.Forms.BindingSource(this.components);
            this.dtsExpenses = new BankParser.Model.DataSets.Expenses();
            this.btnRetreiveCSVData = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.rtbErrors = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBudgetItems);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1174, 424);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvBudgetItems
            // 
            this.dgvBudgetItems.AutoGenerateColumns = false;
            this.dgvBudgetItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBudgetItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBudgetItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionDateDataGridViewTextBoxColumn,
            this.description1DataGridViewTextBoxColumn,
            this.cADDataGridViewTextBoxColumn,
            this.accountTypeDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.chequeNumberDataGridViewTextBoxColumn,
            this.description2DataGridViewTextBoxColumn,
            this.uSDDataGridViewTextBoxColumn,
            this.catagoryDataGridViewTextBoxColumn,
            this.uniqueExpenseIDDataGridViewTextBoxColumn});
            this.dgvBudgetItems.DataSource = this.bdsExpenses;
            this.dgvBudgetItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBudgetItems.Location = new System.Drawing.Point(3, 16);
            this.dgvBudgetItems.Name = "dgvBudgetItems";
            this.dgvBudgetItems.Size = new System.Drawing.Size(1168, 405);
            this.dgvBudgetItems.TabIndex = 1;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            // 
            // description1DataGridViewTextBoxColumn
            // 
            this.description1DataGridViewTextBoxColumn.DataPropertyName = "Description 1";
            this.description1DataGridViewTextBoxColumn.HeaderText = "Description 1";
            this.description1DataGridViewTextBoxColumn.Name = "description1DataGridViewTextBoxColumn";
            // 
            // cADDataGridViewTextBoxColumn
            // 
            this.cADDataGridViewTextBoxColumn.DataPropertyName = "CAD$";
            this.cADDataGridViewTextBoxColumn.HeaderText = "CAD$";
            this.cADDataGridViewTextBoxColumn.Name = "cADDataGridViewTextBoxColumn";
            // 
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            this.accountTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            this.accountNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // chequeNumberDataGridViewTextBoxColumn
            // 
            this.chequeNumberDataGridViewTextBoxColumn.DataPropertyName = "ChequeNumber";
            this.chequeNumberDataGridViewTextBoxColumn.HeaderText = "ChequeNumber";
            this.chequeNumberDataGridViewTextBoxColumn.Name = "chequeNumberDataGridViewTextBoxColumn";
            this.chequeNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // description2DataGridViewTextBoxColumn
            // 
            this.description2DataGridViewTextBoxColumn.DataPropertyName = "Description 2";
            this.description2DataGridViewTextBoxColumn.HeaderText = "Description 2";
            this.description2DataGridViewTextBoxColumn.Name = "description2DataGridViewTextBoxColumn";
            this.description2DataGridViewTextBoxColumn.Visible = false;
            // 
            // uSDDataGridViewTextBoxColumn
            // 
            this.uSDDataGridViewTextBoxColumn.DataPropertyName = "USD$";
            this.uSDDataGridViewTextBoxColumn.HeaderText = "USD$";
            this.uSDDataGridViewTextBoxColumn.Name = "uSDDataGridViewTextBoxColumn";
            this.uSDDataGridViewTextBoxColumn.Visible = false;
            // 
            // catagoryDataGridViewTextBoxColumn
            // 
            this.catagoryDataGridViewTextBoxColumn.DataPropertyName = "Catagory";
            this.catagoryDataGridViewTextBoxColumn.HeaderText = "Catagory";
            this.catagoryDataGridViewTextBoxColumn.Name = "catagoryDataGridViewTextBoxColumn";
            this.catagoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // uniqueExpenseIDDataGridViewTextBoxColumn
            // 
            this.uniqueExpenseIDDataGridViewTextBoxColumn.DataPropertyName = "UniqueExpenseID";
            this.uniqueExpenseIDDataGridViewTextBoxColumn.HeaderText = "UniqueExpenseID";
            this.uniqueExpenseIDDataGridViewTextBoxColumn.Name = "uniqueExpenseIDDataGridViewTextBoxColumn";
            this.uniqueExpenseIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bdsExpenses
            // 
            this.bdsExpenses.DataMember = "tttExpenses";
            this.bdsExpenses.DataSource = this.dtsExpenses;
            // 
            // dtsExpenses
            // 
            this.dtsExpenses.DataSetName = "Expenses";
            this.dtsExpenses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRetreiveCSVData
            // 
            this.btnRetreiveCSVData.Location = new System.Drawing.Point(12, 430);
            this.btnRetreiveCSVData.Name = "btnRetreiveCSVData";
            this.btnRetreiveCSVData.Size = new System.Drawing.Size(174, 23);
            this.btnRetreiveCSVData.TabIndex = 2;
            this.btnRetreiveCSVData.Text = "Retreive CSV Data";
            this.btnRetreiveCSVData.UseVisualStyleBackColor = true;
            this.btnRetreiveCSVData.Click += new System.EventHandler(this.btnRetreiveCSVData_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(253, 430);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(174, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export To Data XML";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // rtbErrors
            // 
            this.rtbErrors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbErrors.ForeColor = System.Drawing.Color.DarkRed;
            this.rtbErrors.Location = new System.Drawing.Point(0, 552);
            this.rtbErrors.Name = "rtbErrors";
            this.rtbErrors.Size = new System.Drawing.Size(1174, 118);
            this.rtbErrors.TabIndex = 4;
            this.rtbErrors.Text = "";
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 670);
            this.Controls.Add(this.rtbErrors);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnRetreiveCSVData);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExpenseForm";
            this.Text = "ExpenseForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRetreiveCSVData;
        private Model.DataSets.Expenses dtsExpenses;
        private System.Windows.Forms.BindingSource bdsExpenses;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvBudgetItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueExpenseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox rtbErrors;
    }
}