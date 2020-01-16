using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankParser.Controller;

namespace BankParser.View
{
    public partial class IncomeForm : Form
    {
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.IncomeFormController.GenerateYear(ref dtsIncome, textBox1.Text, textBox2.Text);
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            IncomeFormController.GetData(ref dtsIncome);
        }

        private void btnSaveIncome_Click(object sender, EventArgs e)
        {
            Controller.IncomeFormController.SaveData(ref dtsIncome);
        }

        private void btnClearIncome_Click(object sender, EventArgs e)
        {
            Controller.IncomeFormController.ClearData(ref dtsIncome);
        }
    }
}
