using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankParser.ModalForm
{
    public partial class ModalAssignCatagory : Form
    {
        public ModalAssignCatagory()
        {
            InitializeComponent();
        }

        public string Description
        {
            get
            {
                return txtDescription.Text;
            }
            set
            {
                txtDescription.Text = value;
            }
        }

        public string Item
        {
            get
            {
                return txtCatagory.Text;
            }
            set
            {
                txtCatagory.Text = value;
            }
        }

        public string UniqueID
        {
            get
            {
                return txtUniqueID.Text;
            }
            set
            {
                txtUniqueID.Text = value;
            }
        }

        public string SubCatagory
        {
            get
            {
                return cmbSubCatagory.Text;
            }
            set
            {
                cmbSubCatagory.Text = value;
            }
        }

        public bool UseUniqueID
        {
            get
            {
                return chkUniqueID.Checked;
            }
            set
            {
                chkUniqueID.Checked = value;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ModalAssignCatagory_Load(object sender, EventArgs e)
        {
            Controller.SubCatagoryFormController.GetData(ref dtsSubCatagory);

            bdsSubCatagory.Filter = "Catagory = '" + txtCatagory.Text + "'";


        }
    }
}
