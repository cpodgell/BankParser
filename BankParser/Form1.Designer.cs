namespace BankParser
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRetrieveCSV = new System.Windows.Forms.Button();
            this.grpRoyalBank = new System.Windows.Forms.GroupBox();
            this.dgvRecordList = new System.Windows.Forms.DataGridView();
            this.cmsAll = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.decalreGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.travelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entertainmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixedCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drugStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCatagoryMappings = new System.Windows.Forms.GroupBox();
            this.btnWriteMappings = new System.Windows.Forms.Button();
            this.btnImportMappings = new System.Windows.Forms.Button();
            this.btnApplyCatagory = new System.Windows.Forms.Button();
            this.dgvCatagoryMapping = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsCatagoryMappings = new System.Windows.Forms.BindingSource(this.components);
            this.pdsCatagoryMapping = new BankParser.CatagoryMapping();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCalculateCategory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpRoyalBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordList)).BeginInit();
            this.cmsAll.SuspendLayout();
            this.grpCatagoryMappings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatagoryMapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCatagoryMappings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdsCatagoryMapping)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRetrieveCSV
            // 
            this.btnRetrieveCSV.Location = new System.Drawing.Point(9, 19);
            this.btnRetrieveCSV.Name = "btnRetrieveCSV";
            this.btnRetrieveCSV.Size = new System.Drawing.Size(121, 22);
            this.btnRetrieveCSV.TabIndex = 0;
            this.btnRetrieveCSV.Text = "Retrieve CSV";
            this.btnRetrieveCSV.UseVisualStyleBackColor = true;
            this.btnRetrieveCSV.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpRoyalBank
            // 
            this.grpRoyalBank.Controls.Add(this.dgvRecordList);
            this.grpRoyalBank.Controls.Add(this.btnRetrieveCSV);
            this.grpRoyalBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRoyalBank.Location = new System.Drawing.Point(0, 0);
            this.grpRoyalBank.Name = "grpRoyalBank";
            this.grpRoyalBank.Size = new System.Drawing.Size(573, 1005);
            this.grpRoyalBank.TabIndex = 0;
            this.grpRoyalBank.TabStop = false;
            // 
            // dgvRecordList
            // 
            this.dgvRecordList.AllowUserToAddRows = false;
            this.dgvRecordList.AllowUserToDeleteRows = false;
            this.dgvRecordList.AllowUserToResizeRows = false;
            this.dgvRecordList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecordList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecordList.ContextMenuStrip = this.cmsAll;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecordList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecordList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRecordList.Location = new System.Drawing.Point(3, 58);
            this.dgvRecordList.MultiSelect = false;
            this.dgvRecordList.Name = "dgvRecordList";
            this.dgvRecordList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecordList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecordList.RowHeadersVisible = false;
            this.dgvRecordList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRecordList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecordList.ShowEditingIcon = false;
            this.dgvRecordList.Size = new System.Drawing.Size(567, 944);
            this.dgvRecordList.StandardTab = true;
            this.dgvRecordList.TabIndex = 1;
            this.dgvRecordList.TabStop = false;
            // 
            // cmsAll
            // 
            this.cmsAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decalreGroupToolStripMenuItem});
            this.cmsAll.Name = "cmsAll";
            this.cmsAll.Size = new System.Drawing.Size(150, 26);
            this.cmsAll.Opening += new System.ComponentModel.CancelEventHandler(this.cmsAll_Opening);
            // 
            // decalreGroupToolStripMenuItem
            // 
            this.decalreGroupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foodToolStripMenuItem,
            this.travelToolStripMenuItem,
            this.restaurantToolStripMenuItem,
            this.fitnessToolStripMenuItem,
            this.entertainmentToolStripMenuItem,
            this.productToolStripMenuItem,
            this.clothingToolStripMenuItem,
            this.fixedCostToolStripMenuItem,
            this.miscToolStripMenuItem,
            this.drugStoreToolStripMenuItem,
            this.hairToolStripMenuItem});
            this.decalreGroupToolStripMenuItem.Name = "decalreGroupToolStripMenuItem";
            this.decalreGroupToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.decalreGroupToolStripMenuItem.Text = "Decalre Group";
            // 
            // foodToolStripMenuItem
            // 
            this.foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            this.foodToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.foodToolStripMenuItem.Text = "Food";
            this.foodToolStripMenuItem.Click += new System.EventHandler(this.foodToolStripMenuItem_Click);
            // 
            // travelToolStripMenuItem
            // 
            this.travelToolStripMenuItem.Name = "travelToolStripMenuItem";
            this.travelToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.travelToolStripMenuItem.Text = "Travel";
            this.travelToolStripMenuItem.Click += new System.EventHandler(this.travelToolStripMenuItem_Click);
            // 
            // restaurantToolStripMenuItem
            // 
            this.restaurantToolStripMenuItem.Name = "restaurantToolStripMenuItem";
            this.restaurantToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.restaurantToolStripMenuItem.Text = "Restaurant";
            this.restaurantToolStripMenuItem.Click += new System.EventHandler(this.restaurantToolStripMenuItem_Click);
            // 
            // fitnessToolStripMenuItem
            // 
            this.fitnessToolStripMenuItem.Name = "fitnessToolStripMenuItem";
            this.fitnessToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.fitnessToolStripMenuItem.Text = "Fitness";
            this.fitnessToolStripMenuItem.Click += new System.EventHandler(this.fitnessToolStripMenuItem_Click);
            // 
            // entertainmentToolStripMenuItem
            // 
            this.entertainmentToolStripMenuItem.Name = "entertainmentToolStripMenuItem";
            this.entertainmentToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.entertainmentToolStripMenuItem.Text = "Entertainment";
            this.entertainmentToolStripMenuItem.Click += new System.EventHandler(this.entertainmentToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // clothingToolStripMenuItem
            // 
            this.clothingToolStripMenuItem.Name = "clothingToolStripMenuItem";
            this.clothingToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.clothingToolStripMenuItem.Text = "Clothing";
            this.clothingToolStripMenuItem.Click += new System.EventHandler(this.clothingToolStripMenuItem_Click);
            // 
            // fixedCostToolStripMenuItem
            // 
            this.fixedCostToolStripMenuItem.Name = "fixedCostToolStripMenuItem";
            this.fixedCostToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.fixedCostToolStripMenuItem.Text = "Fixed Cost";
            this.fixedCostToolStripMenuItem.Click += new System.EventHandler(this.fixedCostToolStripMenuItem_Click);
            // 
            // miscToolStripMenuItem
            // 
            this.miscToolStripMenuItem.Name = "miscToolStripMenuItem";
            this.miscToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.miscToolStripMenuItem.Text = "Misc.";
            this.miscToolStripMenuItem.Click += new System.EventHandler(this.miscToolStripMenuItem_Click);
            // 
            // drugStoreToolStripMenuItem
            // 
            this.drugStoreToolStripMenuItem.Name = "drugStoreToolStripMenuItem";
            this.drugStoreToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.drugStoreToolStripMenuItem.Text = "Drug Store";
            this.drugStoreToolStripMenuItem.Click += new System.EventHandler(this.drugStoreToolStripMenuItem_Click);
            // 
            // hairToolStripMenuItem
            // 
            this.hairToolStripMenuItem.Name = "hairToolStripMenuItem";
            this.hairToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.hairToolStripMenuItem.Text = "Hair";
            this.hairToolStripMenuItem.Click += new System.EventHandler(this.hairToolStripMenuItem_Click);
            // 
            // grpCatagoryMappings
            // 
            this.grpCatagoryMappings.Controls.Add(this.btnWriteMappings);
            this.grpCatagoryMappings.Controls.Add(this.btnImportMappings);
            this.grpCatagoryMappings.Controls.Add(this.btnApplyCatagory);
            this.grpCatagoryMappings.Controls.Add(this.dgvCatagoryMapping);
            this.grpCatagoryMappings.Controls.Add(this.btnDelete);
            this.grpCatagoryMappings.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCatagoryMappings.Location = new System.Drawing.Point(0, 0);
            this.grpCatagoryMappings.Name = "grpCatagoryMappings";
            this.grpCatagoryMappings.Size = new System.Drawing.Size(547, 343);
            this.grpCatagoryMappings.TabIndex = 0;
            this.grpCatagoryMappings.TabStop = false;
            this.grpCatagoryMappings.Text = "Catagory Mappings";
            // 
            // btnWriteMappings
            // 
            this.btnWriteMappings.Location = new System.Drawing.Point(413, 175);
            this.btnWriteMappings.Name = "btnWriteMappings";
            this.btnWriteMappings.Size = new System.Drawing.Size(128, 22);
            this.btnWriteMappings.TabIndex = 3;
            this.btnWriteMappings.Text = "Write Mappings";
            this.btnWriteMappings.UseVisualStyleBackColor = true;
            this.btnWriteMappings.Click += new System.EventHandler(this.btnWriteMappings_Click);
            // 
            // btnImportMappings
            // 
            this.btnImportMappings.Location = new System.Drawing.Point(6, 147);
            this.btnImportMappings.Name = "btnImportMappings";
            this.btnImportMappings.Size = new System.Drawing.Size(152, 22);
            this.btnImportMappings.TabIndex = 1;
            this.btnImportMappings.Text = "Import Category Mappings";
            this.btnImportMappings.UseVisualStyleBackColor = true;
            this.btnImportMappings.Click += new System.EventHandler(this.btnImportMappings_Click);
            // 
            // btnApplyCatagory
            // 
            this.btnApplyCatagory.Location = new System.Drawing.Point(6, 194);
            this.btnApplyCatagory.Name = "btnApplyCatagory";
            this.btnApplyCatagory.Size = new System.Drawing.Size(285, 22);
            this.btnApplyCatagory.TabIndex = 4;
            this.btnApplyCatagory.Text = "Apply Catagory To Items";
            this.btnApplyCatagory.UseVisualStyleBackColor = true;
            this.btnApplyCatagory.Click += new System.EventHandler(this.btnApplyCatagory_Click);
            // 
            // dgvCatagoryMapping
            // 
            this.dgvCatagoryMapping.AllowUserToAddRows = false;
            this.dgvCatagoryMapping.AllowUserToDeleteRows = false;
            this.dgvCatagoryMapping.AllowUserToResizeRows = false;
            this.dgvCatagoryMapping.AutoGenerateColumns = false;
            this.dgvCatagoryMapping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatagoryMapping.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCatagoryMapping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.catagoryDataGridViewTextBoxColumn});
            this.dgvCatagoryMapping.ContextMenuStrip = this.cmsAll;
            this.dgvCatagoryMapping.DataSource = this.bdsCatagoryMappings;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatagoryMapping.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCatagoryMapping.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCatagoryMapping.Location = new System.Drawing.Point(3, 16);
            this.dgvCatagoryMapping.MultiSelect = false;
            this.dgvCatagoryMapping.Name = "dgvCatagoryMapping";
            this.dgvCatagoryMapping.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatagoryMapping.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCatagoryMapping.RowHeadersVisible = false;
            this.dgvCatagoryMapping.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCatagoryMapping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatagoryMapping.ShowEditingIcon = false;
            this.dgvCatagoryMapping.Size = new System.Drawing.Size(541, 125);
            this.dgvCatagoryMapping.StandardTab = true;
            this.dgvCatagoryMapping.TabIndex = 0;
            this.dgvCatagoryMapping.TabStop = false;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // catagoryDataGridViewTextBoxColumn
            // 
            this.catagoryDataGridViewTextBoxColumn.DataPropertyName = "Catagory";
            this.catagoryDataGridViewTextBoxColumn.HeaderText = "Catagory";
            this.catagoryDataGridViewTextBoxColumn.Name = "catagoryDataGridViewTextBoxColumn";
            this.catagoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsCatagoryMappings
            // 
            this.bdsCatagoryMappings.DataMember = "ttiCatagories";
            this.bdsCatagoryMappings.DataSource = this.pdsCatagoryMapping;
            // 
            // pdsCatagoryMapping
            // 
            this.pdsCatagoryMapping.DataSetName = "CatagoryMapping";
            this.pdsCatagoryMapping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(413, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 22);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Category";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(6, 349);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(152, 22);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCalculateCategory
            // 
            this.btnCalculateCategory.Location = new System.Drawing.Point(164, 349);
            this.btnCalculateCategory.Name = "btnCalculateCategory";
            this.btnCalculateCategory.Size = new System.Drawing.Size(248, 24);
            this.btnCalculateCategory.TabIndex = 2;
            this.btnCalculateCategory.Text = "Calculate Category";
            this.btnCalculateCategory.UseVisualStyleBackColor = true;
            this.btnCalculateCategory.Click += new System.EventHandler(this.btnCalculateCategory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1136, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 411);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpRoyalBank);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCalculateCategory);
            this.splitContainer1.Panel2.Controls.Add(this.grpCatagoryMappings);
            this.splitContainer1.Panel2.Controls.Add(this.btnCalculate);
            this.splitContainer1.Size = new System.Drawing.Size(1124, 1005);
            this.splitContainer1.SplitterDistance = 573;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1130, 1024);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 1024);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpRoyalBank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordList)).EndInit();
            this.cmsAll.ResumeLayout(false);
            this.grpCatagoryMappings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatagoryMapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCatagoryMappings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdsCatagoryMapping)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetrieveCSV;
        private System.Windows.Forms.GroupBox grpRoyalBank;
        protected System.Windows.Forms.DataGridView dgvRecordList;
        private System.Windows.Forms.ContextMenuStrip cmsAll;
        private System.Windows.Forms.ToolStripMenuItem decalreGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entertainmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem travelToolStripMenuItem;
        private CatagoryMapping pdsCatagoryMapping;
        private System.Windows.Forms.GroupBox grpCatagoryMappings;
        protected System.Windows.Forms.DataGridView dgvCatagoryMapping;
        private System.Windows.Forms.BindingSource bdsCatagoryMappings;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnWriteMappings;
        private System.Windows.Forms.Button btnImportMappings;
        private System.Windows.Forms.Button btnApplyCatagory;
        private System.Windows.Forms.ToolStripMenuItem restaurantToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem fitnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixedCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drugStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hairToolStripMenuItem;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCalculateCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

