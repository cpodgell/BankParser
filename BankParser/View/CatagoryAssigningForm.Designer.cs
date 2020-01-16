namespace BankParser.View
{
    partial class CatagoryAssigningForm
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
            this.dgvExpenseItems = new System.Windows.Forms.DataGridView();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsBudgetItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bdsExpenses = new System.Windows.Forms.BindingSource(this.components);
            this.dtsExpenses = new BankParser.Model.DataSets.Expenses();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCatagory = new System.Windows.Forms.DataGridView();
            this.catagoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetItemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCatagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniqueExpenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsCatagoryMapping = new System.Windows.Forms.BindingSource(this.components);
            this.dtsCatagory = new BankParser.Model.DataSets.Catagory();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsExpenses)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCatagoryMapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCatagory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvExpenseItems);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1147, 312);
            this.groupBox1.TabIndex = 2;
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
            this.transactionDateDataGridViewTextBoxColumn,
            this.description1DataGridViewTextBoxColumn,
            this.cADDataGridViewTextBoxColumn,
            this.catagoryDataGridViewTextBoxColumn,
            this.accountTypeDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.chequeNumberDataGridViewTextBoxColumn,
            this.description2DataGridViewTextBoxColumn,
            this.uSDDataGridViewTextBoxColumn});
            this.dgvExpenseItems.ContextMenuStrip = this.cmsBudgetItems;
            this.dgvExpenseItems.DataSource = this.bdsExpenses;
            this.dgvExpenseItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenseItems.Location = new System.Drawing.Point(3, 16);
            this.dgvExpenseItems.Name = "dgvExpenseItems";
            this.dgvExpenseItems.ReadOnly = true;
            this.dgvExpenseItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenseItems.ShowEditingIcon = false;
            this.dgvExpenseItems.Size = new System.Drawing.Size(1141, 293);
            this.dgvExpenseItems.TabIndex = 0;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            this.transactionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // description1DataGridViewTextBoxColumn
            // 
            this.description1DataGridViewTextBoxColumn.DataPropertyName = "Description 1";
            this.description1DataGridViewTextBoxColumn.HeaderText = "Description 1";
            this.description1DataGridViewTextBoxColumn.Name = "description1DataGridViewTextBoxColumn";
            this.description1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cADDataGridViewTextBoxColumn
            // 
            this.cADDataGridViewTextBoxColumn.DataPropertyName = "CAD$";
            this.cADDataGridViewTextBoxColumn.HeaderText = "CAD$";
            this.cADDataGridViewTextBoxColumn.Name = "cADDataGridViewTextBoxColumn";
            this.cADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // catagoryDataGridViewTextBoxColumn
            // 
            this.catagoryDataGridViewTextBoxColumn.DataPropertyName = "Catagory";
            this.catagoryDataGridViewTextBoxColumn.HeaderText = "Catagory";
            this.catagoryDataGridViewTextBoxColumn.Name = "catagoryDataGridViewTextBoxColumn";
            this.catagoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            this.accountTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            this.accountNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // chequeNumberDataGridViewTextBoxColumn
            // 
            this.chequeNumberDataGridViewTextBoxColumn.DataPropertyName = "ChequeNumber";
            this.chequeNumberDataGridViewTextBoxColumn.HeaderText = "ChequeNumber";
            this.chequeNumberDataGridViewTextBoxColumn.Name = "chequeNumberDataGridViewTextBoxColumn";
            this.chequeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.chequeNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // description2DataGridViewTextBoxColumn
            // 
            this.description2DataGridViewTextBoxColumn.DataPropertyName = "Description 2";
            this.description2DataGridViewTextBoxColumn.HeaderText = "Description 2";
            this.description2DataGridViewTextBoxColumn.Name = "description2DataGridViewTextBoxColumn";
            this.description2DataGridViewTextBoxColumn.ReadOnly = true;
            this.description2DataGridViewTextBoxColumn.Visible = false;
            // 
            // uSDDataGridViewTextBoxColumn
            // 
            this.uSDDataGridViewTextBoxColumn.DataPropertyName = "USD$";
            this.uSDDataGridViewTextBoxColumn.HeaderText = "USD$";
            this.uSDDataGridViewTextBoxColumn.Name = "uSDDataGridViewTextBoxColumn";
            this.uSDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cmsBudgetItems
            // 
            this.cmsBudgetItems.Name = "cmsBudgetItems";
            this.cmsBudgetItems.Size = new System.Drawing.Size(61, 4);
            this.cmsBudgetItems.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsBudgetItems_ItemClicked);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCatagory);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1147, 391);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dgvCatagory
            // 
            this.dgvCatagory.AllowUserToAddRows = false;
            this.dgvCatagory.AutoGenerateColumns = false;
            this.dgvCatagory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatagory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatagory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catagoryNameDataGridViewTextBoxColumn,
            this.budgetItemCodeDataGridViewTextBoxColumn,
            this.budgetItemNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.SubCatagory,
            this.UniqueExpenseID});
            this.dgvCatagory.ContextMenuStrip = this.cmsBudgetItems;
            this.dgvCatagory.DataSource = this.bdsCatagoryMapping;
            this.dgvCatagory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCatagory.Location = new System.Drawing.Point(3, 16);
            this.dgvCatagory.Name = "dgvCatagory";
            this.dgvCatagory.ReadOnly = true;
            this.dgvCatagory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatagory.ShowEditingIcon = false;
            this.dgvCatagory.Size = new System.Drawing.Size(1141, 372);
            this.dgvCatagory.TabIndex = 0;
            // 
            // catagoryNameDataGridViewTextBoxColumn
            // 
            this.catagoryNameDataGridViewTextBoxColumn.DataPropertyName = "CatagoryName";
            this.catagoryNameDataGridViewTextBoxColumn.HeaderText = "CatagoryName";
            this.catagoryNameDataGridViewTextBoxColumn.Name = "catagoryNameDataGridViewTextBoxColumn";
            this.catagoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // budgetItemCodeDataGridViewTextBoxColumn
            // 
            this.budgetItemCodeDataGridViewTextBoxColumn.DataPropertyName = "BudgetItemCode";
            this.budgetItemCodeDataGridViewTextBoxColumn.FillWeight = 20F;
            this.budgetItemCodeDataGridViewTextBoxColumn.HeaderText = "BudgetItemCode";
            this.budgetItemCodeDataGridViewTextBoxColumn.Name = "budgetItemCodeDataGridViewTextBoxColumn";
            this.budgetItemCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // budgetItemNameDataGridViewTextBoxColumn
            // 
            this.budgetItemNameDataGridViewTextBoxColumn.DataPropertyName = "BudgetItemName";
            this.budgetItemNameDataGridViewTextBoxColumn.HeaderText = "BudgetItemName";
            this.budgetItemNameDataGridViewTextBoxColumn.Name = "budgetItemNameDataGridViewTextBoxColumn";
            this.budgetItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SubCatagory
            // 
            this.SubCatagory.DataPropertyName = "SubCatagory";
            this.SubCatagory.HeaderText = "SubCatagory";
            this.SubCatagory.Name = "SubCatagory";
            this.SubCatagory.ReadOnly = true;
            // 
            // UniqueExpenseID
            // 
            this.UniqueExpenseID.DataPropertyName = "UniqueExpenseID";
            this.UniqueExpenseID.HeaderText = "UniqueExpenseID";
            this.UniqueExpenseID.Name = "UniqueExpenseID";
            this.UniqueExpenseID.ReadOnly = true;
            // 
            // bdsCatagoryMapping
            // 
            this.bdsCatagoryMapping.DataMember = "tttCatagory";
            this.bdsCatagoryMapping.DataSource = this.dtsCatagory;
            // 
            // dtsCatagory
            // 
            this.dtsCatagory.DataSetName = "Catagory";
            this.dtsCatagory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 723);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(279, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(351, 723);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(279, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CatagoryAssigningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 833);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CatagoryAssigningForm";
            this.Text = "CatagoryAssigningForm";
            this.Load += new System.EventHandler(this.CatagoryAssigningForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsExpenses)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCatagoryMapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCatagory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvExpenseItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsExpenses;
        private Model.DataSets.Expenses dtsExpenses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCatagory;
        private System.Windows.Forms.BindingSource bdsCatagoryMapping;
        private Model.DataSets.Catagory dtsCatagory;
        private System.Windows.Forms.ContextMenuStrip cmsBudgetItems;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetItemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCatagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniqueExpenseID;
    }
}