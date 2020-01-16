using BankParser.ModalForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankParser.Utils
{
    public static class PathUtils
    {
        public static string FindXMLDialog(string xmlFileName)
        {
            MessageBox.Show("ERROR NOT FOUND Path: " + xmlFileName);
            XMLFinder xf = new XMLFinder(xmlFileName);
            xf.ShowDialog();

            return xf.SelectedFile;

        }
    }
}
