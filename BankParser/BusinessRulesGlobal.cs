using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankParser
{
    static class BusinessRulesGlobal
    {
        static public void DataGridRules(Form frm)
        {
            foreach(Control ctrl in frm.Controls)
            {
                if(ctrl.GetType().Equals(typeof(DataGridView)))
                {
                    DataGridView tmpDataGrid = (DataGridView)ctrl;
                    tmpDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }


    }
}
