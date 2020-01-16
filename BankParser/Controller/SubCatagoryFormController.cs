using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankParser.View;
using BankParser.Model;
using BankParser.Model.DataSets;
using System.Windows.Forms;
using BankParser.Utils;

namespace BankParser.Controller
{
    public static class SubCatagoryFormController
    {

        static public void OpenSubCatagoryForm()
        {
            SubCatagoryForm subCatagoryForm = new SubCatagoryForm();
            subCatagoryForm.Show();
        }

        internal static void GetData(ref SubCatagory dtsSubCatagory)
        {
            Model.SubCatagoryFormModel.GetData(ref dtsSubCatagory);
        }

        internal static void PopulateContentMenuStrip(ContextMenuStrip cmsBudgetItems)
        {
            DataUtils.PopulateContextMenu(cmsBudgetItems);
        }

        internal static void SaveData(ref SubCatagory dtsSubCatagory)
        {
            Model.SubCatagoryFormModel.SaveData(dtsSubCatagory);
        }
    }


}
