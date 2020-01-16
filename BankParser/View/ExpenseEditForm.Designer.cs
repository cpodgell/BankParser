namespace BankParser.View
{
    partial class ExpenseEditForm
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
            this.bdsExpenses = new System.Windows.Forms.BindingSource(this.components);
            this.dtsExpenses = new BankParser.Model.DataSets.Expenses();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvExpenseItems = new System.Windows.Forms.DataGridView();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniqueExpenseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemoveNegative = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsDeletedExpenses = new System.Windows.Forms.BindingSource(this.components);
            this.dtsDeletedExpenses = new BankParser.Model.DataSets.DeletedExpenses();
            ((System.ComponentModel.ISupportInitialize)(this.bdsExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsExpenses)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDeletedExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDeletedExpenses)).BeginInit();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvExpenseItems);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1080, 360);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvExpenseItems
            // 
            this.dgvExpenseItems.AutoGenerateColumns = false;
            this.dgvExpenseItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionDateDataGridViewTextBoxColumn,
            this.description1DataGridViewTextBoxColumn,
            this.cADDataGridViewTextBoxColumn,
            this.uniqueExpenseIDDataGridViewTextBoxColumn,
            this.accountTypeDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.chequeNumberDataGridViewTextBoxColumn,
            this.description2DataGridViewTextBoxColumn,
            this.uSDDataGridViewTextBoxColumn,
            this.catagoryDataGridViewTextBoxColumn});
            this.dgvExpenseItems.DataSource = this.bdsExpenses;
            this.dgvExpenseItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenseItems.Location = new System.Drawing.Point(3, 16);
            this.dgvExpenseItems.Name = "dgvExpenseItems";
            this.dgvExpenseItems.Size = new System.Drawing.Size(1074, 341);
            this.dgvExpenseItems.TabIndex = 2;
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
            // uniqueExpenseIDDataGridViewTextBoxColumn
            // 
            this.uniqueExpenseIDDataGridViewTextBoxColumn.DataPropertyName = "UniqueExpenseID";
            this.uniqueExpenseIDDataGridViewTextBoxColumn.HeaderText = "UniqueExpenseID";
            this.uniqueExpenseIDDataGridViewTextBoxColumn.Name = "uniqueExpenseIDDataGridViewTextBoxColumn";
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(177, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemoveNegative
            // 
            this.btnRemoveNegative.Location = new System.Drawing.Point(350, 363);
            this.btnRemoveNegative.Name = "btnRemoveNegative";
            this.btnRemoveNegative.Size = new System.Drawing.Size(167, 23);
            this.btnRemoveNegative.TabIndex = 5;
            this.btnRemoveNegative.Text = "Remove Negatives";
            this.btnRemoveNegative.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoveNegative.UseVisualStyleBackColor = true;
            this.btnRemoveNegative.Click += new System.EventHandler(this.btnRemoveNegative_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Location = new System.Drawing.Point(523, 363);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(167, 23);
            this.btnDeleteRow.TabIndex = 6;
            this.btnDeleteRow.Text = "Delete Row";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView1.DataSource = this.bdsDeletedExpenses;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 415);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1080, 305);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TransactionDate";
            this.dataGridViewTextBoxColumn1.HeaderText = "TransactionDate";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description 1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description 1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CAD$";
            this.dataGridViewTextBoxColumn3.HeaderText = "CAD$";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UniqueExpenseID";
            this.dataGridViewTextBoxColumn4.HeaderText = "UniqueExpenseID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AccountType";
            this.dataGridViewTextBoxColumn5.HeaderText = "AccountType";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AccountNumber";
            this.dataGridViewTextBoxColumn6.HeaderText = "AccountNumber";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ChequeNumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "ChequeNumber";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description 2";
            this.dataGridViewTextBoxColumn8.HeaderText = "Description 2";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "USD$";
            this.dataGridViewTextBoxColumn9.HeaderText = "USD$";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Catagory";
            this.dataGridViewTextBoxColumn10.HeaderText = "Catagory";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // bdsDeletedExpenses
            // 
            this.bdsDeletedExpenses.DataMember = "tttDeletedExpenses";
            this.bdsDeletedExpenses.DataSource = this.dtsDeletedExpenses;
            // 
            // dtsDeletedExpenses
            // 
            this.dtsDeletedExpenses.DataSetName = "DeletedExpenses";
            this.dtsDeletedExpenses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExpenseEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnRemoveNegative);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExpenseEditForm";
            this.Text = "ExpenseEditForm";
            this.Load += new System.EventHandler(this.ExpenseEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsExpenses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDeletedExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDeletedExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsExpenses;
        private Model.DataSets.Expenses dtsExpenses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemoveNegative;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.DataGridView dgvExpenseItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueExpenseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource bdsDeletedExpenses;
        private Model.DataSets.DeletedExpenses dtsDeletedExpenses;
    }
}