namespace BankParser
{
    partial class EntryForm
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
            this.btnSubCatagory = new System.Windows.Forms.Button();
            this.btnExpenseEditForm = new System.Windows.Forms.Button();
            this.btnOpenAnalysis = new System.Windows.Forms.Button();
            this.btnCatagoryAssign = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnExpenseImportForm = new System.Windows.Forms.Button();
            this.btnOpenBudgetForm = new System.Windows.Forms.Button();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmTools = new System.Windows.Forms.ToolStripMenuItem();
            this.convertMastercardBankCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converrtRoyalBankCSVPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.setupToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubCatagory
            // 
            this.btnSubCatagory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubCatagory.Image = global::BankParser.Properties.Resources.advanced_data_grid;
            this.btnSubCatagory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubCatagory.Location = new System.Drawing.Point(8, 118);
            this.btnSubCatagory.Name = "btnSubCatagory";
            this.btnSubCatagory.Size = new System.Drawing.Size(176, 27);
            this.btnSubCatagory.TabIndex = 9;
            this.btnSubCatagory.Text = "Open SubCatagory Form";
            this.btnSubCatagory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubCatagory.UseVisualStyleBackColor = true;
            this.btnSubCatagory.Click += new System.EventHandler(this.btnSubCatagory_Click);
            // 
            // btnExpenseEditForm
            // 
            this.btnExpenseEditForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpenseEditForm.Image = global::BankParser.Properties.Resources.ruby_gear;
            this.btnExpenseEditForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenseEditForm.Location = new System.Drawing.Point(7, 217);
            this.btnExpenseEditForm.Name = "btnExpenseEditForm";
            this.btnExpenseEditForm.Size = new System.Drawing.Size(177, 27);
            this.btnExpenseEditForm.TabIndex = 7;
            this.btnExpenseEditForm.Text = "Open Expense Editting Form";
            this.btnExpenseEditForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpenseEditForm.UseVisualStyleBackColor = true;
            this.btnExpenseEditForm.Click += new System.EventHandler(this.btnExpenseEditForm_Click);
            // 
            // btnOpenAnalysis
            // 
            this.btnOpenAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenAnalysis.Image = global::BankParser.Properties.Resources.chart_line;
            this.btnOpenAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAnalysis.Location = new System.Drawing.Point(8, 151);
            this.btnOpenAnalysis.Name = "btnOpenAnalysis";
            this.btnOpenAnalysis.Size = new System.Drawing.Size(175, 27);
            this.btnOpenAnalysis.TabIndex = 5;
            this.btnOpenAnalysis.Text = "Open Analysis Form";
            this.btnOpenAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenAnalysis.UseVisualStyleBackColor = true;
            this.btnOpenAnalysis.Click += new System.EventHandler(this.btnOpenAnalysis_Click);
            // 
            // btnCatagoryAssign
            // 
            this.btnCatagoryAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCatagoryAssign.Image = global::BankParser.Properties.Resources.data_grid;
            this.btnCatagoryAssign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatagoryAssign.Location = new System.Drawing.Point(7, 85);
            this.btnCatagoryAssign.Name = "btnCatagoryAssign";
            this.btnCatagoryAssign.Size = new System.Drawing.Size(177, 27);
            this.btnCatagoryAssign.TabIndex = 4;
            this.btnCatagoryAssign.Text = "Open Catagory Assign";
            this.btnCatagoryAssign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCatagoryAssign.UseVisualStyleBackColor = true;
            this.btnCatagoryAssign.Click += new System.EventHandler(this.btnCatagoryAssign_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncome.Image = global::BankParser.Properties.Resources.money_dollar;
            this.btnIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncome.Location = new System.Drawing.Point(7, 52);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(176, 27);
            this.btnIncome.TabIndex = 1;
            this.btnIncome.Text = "Open Income Form";
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnExpenseImportForm
            // 
            this.btnExpenseImportForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpenseImportForm.Image = global::BankParser.Properties.Resources.ruby_go;
            this.btnExpenseImportForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenseImportForm.Location = new System.Drawing.Point(8, 184);
            this.btnExpenseImportForm.Name = "btnExpenseImportForm";
            this.btnExpenseImportForm.Size = new System.Drawing.Size(176, 27);
            this.btnExpenseImportForm.TabIndex = 2;
            this.btnExpenseImportForm.Text = "Open Expense Import Form";
            this.btnExpenseImportForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpenseImportForm.UseVisualStyleBackColor = true;
            this.btnExpenseImportForm.Click += new System.EventHandler(this.btnExpenseImportForm_Click);
            // 
            // btnOpenBudgetForm
            // 
            this.btnOpenBudgetForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenBudgetForm.Image = global::BankParser.Properties.Resources.bubblechart;
            this.btnOpenBudgetForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenBudgetForm.Location = new System.Drawing.Point(6, 19);
            this.btnOpenBudgetForm.Name = "btnOpenBudgetForm";
            this.btnOpenBudgetForm.Size = new System.Drawing.Size(178, 27);
            this.btnOpenBudgetForm.TabIndex = 0;
            this.btnOpenBudgetForm.Text = "Open Budget Form";
            this.btnOpenBudgetForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenBudgetForm.UseVisualStyleBackColor = true;
            this.btnOpenBudgetForm.Click += new System.EventHandler(this.btnOpenBudgetForm_Click);
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.btnOpenBudgetForm);
            this.grpMain.Controls.Add(this.btnSubCatagory);
            this.grpMain.Controls.Add(this.btnExpenseImportForm);
            this.grpMain.Controls.Add(this.btnIncome);
            this.grpMain.Controls.Add(this.btnExpenseEditForm);
            this.grpMain.Controls.Add(this.btnCatagoryAssign);
            this.grpMain.Controls.Add(this.btnOpenAnalysis);
            this.grpMain.Location = new System.Drawing.Point(12, 36);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(200, 255);
            this.grpMain.TabIndex = 10;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Main";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(226, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmTools
            // 
            this.tsmTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertMastercardBankCSVToolStripMenuItem,
            this.converrtRoyalBankCSVPdfToolStripMenuItem,
            this.toolStripSeparator1,
            this.setupToolToolStripMenuItem});
            this.tsmTools.Name = "tsmTools";
            this.tsmTools.Size = new System.Drawing.Size(47, 20);
            this.tsmTools.Text = "Tools";
            // 
            // convertMastercardBankCSVToolStripMenuItem
            // 
            this.convertMastercardBankCSVToolStripMenuItem.Name = "convertMastercardBankCSVToolStripMenuItem";
            this.convertMastercardBankCSVToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.convertMastercardBankCSVToolStripMenuItem.Text = "Convert Mastercard Bank CSV pdf";
            this.convertMastercardBankCSVToolStripMenuItem.Click += new System.EventHandler(this.convertMastercardBankCSVToolStripMenuItem_Click);
            // 
            // converrtRoyalBankCSVPdfToolStripMenuItem
            // 
            this.converrtRoyalBankCSVPdfToolStripMenuItem.Name = "converrtRoyalBankCSVPdfToolStripMenuItem";
            this.converrtRoyalBankCSVPdfToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.converrtRoyalBankCSVPdfToolStripMenuItem.Text = "Converrt Royal Bank CSV pdf";
            this.converrtRoyalBankCSVPdfToolStripMenuItem.Click += new System.EventHandler(this.converrtRoyalBankCSVPdfToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // setupToolToolStripMenuItem
            // 
            this.setupToolToolStripMenuItem.Image = global::BankParser.Properties.Resources.database;
            this.setupToolToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setupToolToolStripMenuItem.Name = "setupToolToolStripMenuItem";
            this.setupToolToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.setupToolToolStripMenuItem.Text = "Setup Tool";
            this.setupToolToolStripMenuItem.Click += new System.EventHandler(this.setupToolToolStripMenuItem_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 330);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EntryForm";
            this.Text = "EntryForm";
            this.grpMain.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenBudgetForm;
        private System.Windows.Forms.Button btnExpenseImportForm;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnCatagoryAssign;
        private System.Windows.Forms.Button btnOpenAnalysis;
        private System.Windows.Forms.Button btnExpenseEditForm;
        private System.Windows.Forms.Button btnSubCatagory;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmTools;
        private System.Windows.Forms.ToolStripMenuItem convertMastercardBankCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem converrtRoyalBankCSVPdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}