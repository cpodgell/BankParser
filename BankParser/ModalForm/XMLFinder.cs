using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BankParser.ModalForm
{
    public partial class XMLFinder : Form
    {
        string selectedFile = "";
        string[] fileNames;

        public XMLFinder(string xmlName)
        {
            InitializeComponent();
            GetFileNames(xmlName);
        }


        private void GetFileNames(string xmlName)
        {
            string[] fileNames = Directory.GetFiles(Model.ModelBusinessRules.GetXMLLocation());

            bool foundFileName = false;
            foreach(string filename in fileNames)
            {
                if (filename.Contains(xmlName))
                {
                    listBox1.Items.Add(Path.GetFileName(filename));
                    foundFileName = true;
                }
            }

            if(!foundFileName)
            {
                MessageBox.Show("No file for: " + xmlName + " exists at xml location: " + Model.ModelBusinessRules.GetXMLLocation());
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public string SelectedFile
        {
            get
            {
                return (string)listBox1.Text;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
