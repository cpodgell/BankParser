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
    public partial class PromptPathBox : Form
    {
        int year;

        public PromptPathBox()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public int Year
        {
            get
            {
                Int32.TryParse(txtYear.Text, out year);
                return year;
            }
        }

        public string ImportFilePath
        {
            get
            {
                return @"" + txtFileToConvert.Text;
            }
        }

        public string OutputFilePath
        {
            get
            {
                return @"" + txtOutput.Text;
            }
        }


    }
}
