namespace BankParser.View
{
    partial class IncomeForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCPPDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bdsIncome = new System.Windows.Forms.BindingSource(this.components);
            this.dtsIncome = new BankParser.Model.DataSets.Income();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveIncome = new System.Windows.Forms.Button();
            this.btnClearIncome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.isCPPDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bdsIncome;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(910, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // isCPPDataGridViewCheckBoxColumn
            // 
            this.isCPPDataGridViewCheckBoxColumn.DataPropertyName = "IsCPP";
            this.isCPPDataGridViewCheckBoxColumn.HeaderText = "IsCPP";
            this.isCPPDataGridViewCheckBoxColumn.Name = "isCPPDataGridViewCheckBoxColumn";
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
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsIncome, "Year", true));
            this.textBox1.Location = new System.Drawing.Point(68, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsIncome, "Amount", true));
            this.textBox2.Location = new System.Drawing.Point(233, 309);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 6;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(33, 312);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(184, 312);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generate Year";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveIncome
            // 
            this.btnSaveIncome.Location = new System.Drawing.Point(5, 248);
            this.btnSaveIncome.Name = "btnSaveIncome";
            this.btnSaveIncome.Size = new System.Drawing.Size(151, 22);
            this.btnSaveIncome.TabIndex = 1;
            this.btnSaveIncome.Text = "Save Income";
            this.btnSaveIncome.UseVisualStyleBackColor = true;
            this.btnSaveIncome.Click += new System.EventHandler(this.btnSaveIncome_Click);
            // 
            // btnClearIncome
            // 
            this.btnClearIncome.Location = new System.Drawing.Point(187, 249);
            this.btnClearIncome.Name = "btnClearIncome";
            this.btnClearIncome.Size = new System.Drawing.Size(151, 22);
            this.btnClearIncome.TabIndex = 2;
            this.btnClearIncome.Text = "Clear Income";
            this.btnClearIncome.UseVisualStyleBackColor = true;
            this.btnClearIncome.Click += new System.EventHandler(this.btnClearIncome_Click);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 503);
            this.Controls.Add(this.btnClearIncome);
            this.Controls.Add(this.btnSaveIncome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BankParser.Model.DataSets.Income dtsIncome;
        private System.Windows.Forms.BindingSource bdsIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCPPDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSaveIncome;
        private System.Windows.Forms.Button btnClearIncome;
    }
}