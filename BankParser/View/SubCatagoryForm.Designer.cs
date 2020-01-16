namespace BankParser.View
{
    partial class SubCatagoryForm
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
            this.dgvSubCatagory = new System.Windows.Forms.DataGridView();
            this.catagoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCatagoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCatagoryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsBudgetItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bdsSubCatagory = new System.Windows.Forms.BindingSource(this.components);
            this.dtsSubCatagory = new BankParser.Model.DataSets.SubCatagory();
            this.dtsCatagory = new BankParser.Model.DataSets.Catagory();
            this.dtsBudgetItems = new BankParser.Model.DataSets.BudgetItems();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsSubCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsBudgetItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSubCatagory);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 303);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvSubCatagory
            // 
            this.dgvSubCatagory.AutoGenerateColumns = false;
            this.dgvSubCatagory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubCatagory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCatagory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catagoryDataGridViewTextBoxColumn,
            this.subCatagoryNameDataGridViewTextBoxColumn,
            this.subCatagoryCodeDataGridViewTextBoxColumn});
            this.dgvSubCatagory.ContextMenuStrip = this.cmsBudgetItems;
            this.dgvSubCatagory.DataSource = this.bdsSubCatagory;
            this.dgvSubCatagory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubCatagory.Location = new System.Drawing.Point(3, 16);
            this.dgvSubCatagory.Name = "dgvSubCatagory";
            this.dgvSubCatagory.Size = new System.Drawing.Size(896, 284);
            this.dgvSubCatagory.TabIndex = 1;
            // 
            // catagoryDataGridViewTextBoxColumn
            // 
            this.catagoryDataGridViewTextBoxColumn.DataPropertyName = "Catagory";
            this.catagoryDataGridViewTextBoxColumn.HeaderText = "Catagory";
            this.catagoryDataGridViewTextBoxColumn.Name = "catagoryDataGridViewTextBoxColumn";
            this.catagoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subCatagoryNameDataGridViewTextBoxColumn
            // 
            this.subCatagoryNameDataGridViewTextBoxColumn.DataPropertyName = "SubCatagoryName";
            this.subCatagoryNameDataGridViewTextBoxColumn.HeaderText = "SubCatagoryName";
            this.subCatagoryNameDataGridViewTextBoxColumn.Name = "subCatagoryNameDataGridViewTextBoxColumn";
            // 
            // subCatagoryCodeDataGridViewTextBoxColumn
            // 
            this.subCatagoryCodeDataGridViewTextBoxColumn.DataPropertyName = "SubCatagoryCode";
            this.subCatagoryCodeDataGridViewTextBoxColumn.HeaderText = "SubCatagoryCode";
            this.subCatagoryCodeDataGridViewTextBoxColumn.Name = "subCatagoryCodeDataGridViewTextBoxColumn";
            // 
            // cmsBudgetItems
            // 
            this.cmsBudgetItems.Name = "cmsBudgetItems";
            this.cmsBudgetItems.Size = new System.Drawing.Size(61, 4);
            this.cmsBudgetItems.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsBudgetItems_ItemClicked);
            // 
            // bdsSubCatagory
            // 
            this.bdsSubCatagory.DataMember = "tttSubCatagory";
            this.bdsSubCatagory.DataSource = this.dtsSubCatagory;
            // 
            // dtsSubCatagory
            // 
            this.dtsSubCatagory.DataSetName = "SubCatagory";
            this.dtsSubCatagory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtsCatagory
            // 
            this.dtsCatagory.DataSetName = "Catagory";
            this.dtsCatagory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtsBudgetItems
            // 
            this.dtsBudgetItems.DataSetName = "BudgetItems";
            this.dtsBudgetItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(40, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(239, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SubCatagoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 698);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubCatagoryForm";
            this.Text = "SubCatagoryForm";
            this.Load += new System.EventHandler(this.SubCatagoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsSubCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsBudgetItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Model.DataSets.Catagory dtsCatagory;
        private System.Windows.Forms.BindingSource bdsSubCatagory;
        private Model.DataSets.SubCatagory dtsSubCatagory;
        private System.Windows.Forms.ContextMenuStrip cmsBudgetItems;
        private Model.DataSets.BudgetItems dtsBudgetItems;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvSubCatagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCatagoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCatagoryCodeDataGridViewTextBoxColumn;
    }
}