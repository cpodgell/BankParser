using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankParser.Model.DataSets;
using System.IO;
using System.Windows.Forms;
using BankParser.Utils;

namespace BankParser.Model
{
    public static class SubCatagoryFormModel
    {
        internal static void GetData(ref SubCatagory dtsSubCatagory)
        {
            dtsSubCatagory.Clear();
            PopulateIncome(ref dtsSubCatagory);
        }

        private static void PopulateIncome(ref SubCatagory dtsSubCatagory)
        {
            if (!File.Exists(Model.ModelBusinessRules.GetSubCatagoryFileLocation()))
            {
                string subCatagoryFileLocation = Utils.PathUtils.FindXMLDialog(Model.ModelBusinessRules.SUBCATAGORYXMLBASE);
                Model.ModelBusinessRules.subCatagoryXMLFileName = subCatagoryFileLocation;
            }
            try
            {
                dtsSubCatagory.ReadXml(Model.ModelBusinessRules.GetSubCatagoryFileLocation());
            } catch (System.IO.DirectoryNotFoundException e)
            {
                MessageBox.Show("ERROR file not found: " + e.Message);
            }
            Controller.ConfigurationReader.WriteConfigurationFile();
        }

        internal static void SaveData(SubCatagory dtsSubCatagory)
        {
            Model.ModelBusinessRules.subCatagoryXMLFileName = DataUtils.BuildXMLFileName(Model.ModelBusinessRules.SUBCATAGORYXMLBASE);
            dtsSubCatagory.WriteXml(Model.ModelBusinessRules.GetSubCatagoryFileLocation());
            Controller.ConfigurationReader.WriteConfigurationFile();
        }
    }
}
