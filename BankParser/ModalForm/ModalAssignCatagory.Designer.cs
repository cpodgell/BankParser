namespace BankParser.ModalForm
{
    partial class ModalAssignCatagory
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatagory = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUniqueID = new System.Windows.Forms.TextBox();
            this.lblUniqueID = new System.Windows.Forms.Label();
            this.cmbSubCatagory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtsSubCatagory = new BankParser.Model.DataSets.SubCatagory();
            this.bdsSubCatagory = new System.Windows.Forms.BindingSource(this.components);
            this.chkUniqueID = new System.Windows.Forms.CheckBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtsSubCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubCatagory)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(137, 20);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(574, 20);
            this.txtDescription.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(71, 23);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item";
            // 
            // txtCatagory
            // 
            this.txtCatagory.Location = new System.Drawing.Point(137, 73);
            this.txtCatagory.Name = "txtCatagory";
            this.txtCatagory.ReadOnly = true;
            this.txtCatagory.Size = new System.Drawing.Size(272, 20);
            this.txtCatagory.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(334, 168);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(429, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUniqueID
            // 
            this.txtUniqueID.Location = new System.Drawing.Point(137, 99);
            this.txtUniqueID.Name = "txtUniqueID";
            this.txtUniqueID.ReadOnly = true;
            this.txtUniqueID.Size = new System.Drawing.Size(272, 20);
            this.txtUniqueID.TabIndex = 6;
            // 
            // lblUniqueID
            // 
            this.lblUniqueID.AutoSize = true;
            this.lblUniqueID.Location = new System.Drawing.Point(76, 102);
            this.lblUniqueID.Name = "lblUniqueID";
            this.lblUniqueID.Size = new System.Drawing.Size(55, 13);
            this.lblUniqueID.TabIndex = 7;
            this.lblUniqueID.Text = "Unique ID";
            // 
            // cmbSubCatagory
            // 
            this.cmbSubCatagory.DataSource = this.bdsSubCatagory;
            this.cmbSubCatagory.DisplayMember = "SubCatagoryName";
            this.cmbSubCatagory.FormattingEnabled = true;
            this.cmbSubCatagory.Location = new System.Drawing.Point(137, 46);
            this.cmbSubCatagory.Name = "cmbSubCatagory";
            this.cmbSubCatagory.Size = new System.Drawing.Size(304, 21);
            this.cmbSubCatagory.TabIndex = 8;
            this.cmbSubCatagory.ValueMember = "SubCatagoryCode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sub Catagory";
            // 
            // dtsSubCatagory
            // 
            this.dtsSubCatagory.DataSetName = "SubCatagory";
            this.dtsSubCatagory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSubCatagory
            // 
            this.bdsSubCatagory.DataMember = "tttSubCatagory";
            this.bdsSubCatagory.DataSource = this.dtsSubCatagory;
            // 
            // chkUniqueID
            // 
            this.chkUniqueID.AutoSize = true;
            this.chkUniqueID.Location = new System.Drawing.Point(415, 99);
            this.chkUniqueID.Name = "chkUniqueID";
            this.chkUniqueID.Size = new System.Drawing.Size(93, 17);
            this.chkUniqueID.TabIndex = 10;
            this.chkUniqueID.Text = "Use UniqueID";
            this.chkUniqueID.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(134, 122);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(466, 13);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = "Using unique ID will apply the catagory to this specific item instead of propogat" +
    "ing to all instances.";
            // 
            // ModalAssignCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 203);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.chkUniqueID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSubCatagory);
            this.Controls.Add(this.lblUniqueID);
            this.Controls.Add(this.txtUniqueID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCatagory);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Name = "ModalAssignCatagory";
            this.Text = "ModalAssignCatagory";
            this.Load += new System.EventHandler(this.ModalAssignCatagory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsSubCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubCatagory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatagory;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtUniqueID;
        private System.Windows.Forms.Label lblUniqueID;
        private System.Windows.Forms.ComboBox cmbSubCatagory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bdsSubCatagory;
        private Model.DataSets.SubCatagory dtsSubCatagory;
        private System.Windows.Forms.CheckBox chkUniqueID;
        private System.Windows.Forms.Label lblInfo;
    }
}