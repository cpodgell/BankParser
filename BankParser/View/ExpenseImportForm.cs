using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using BankParser.Controller;

namespace BankParser.View
{
    public partial class ExpenseForm : Form
    {

        public ExpenseForm()
        {
            InitializeComponent();
        }

        private void btnRetreiveCSVData_Click(object sender, EventArgs e)
        {
            List<string> errorlog = new List<string>();
            ExpenseFormController.GetCSVData(ref dtsExpenses, ref errorlog);
            foreach (string s in errorlog)
            {
                rtbErrors.Text += s + "\n";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<string> errorlog = new List<string>();
            ExpenseFormController.ImportCSV(ref dtsExpenses, ref errorlog);
            foreach(string s in errorlog)
            {
                rtbErrors.Text += s + "\n";
            }
        }
    }
}
