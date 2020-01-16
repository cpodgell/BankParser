using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankParser
{
    public partial class TextSelection : Form
    {
        public string ProductName
        {
            get
            {
                return txtProduct.Text;
            }
            set
            {
                txtProduct.Text = value;
            }
        }

        public TextSelection()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
