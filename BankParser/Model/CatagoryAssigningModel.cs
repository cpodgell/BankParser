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
    class CatagoryAssigningModel
    {

        internal static void GetData(ref Catagory dtsCatagory)
        {
            PopulateCatagory(ref dtsCatagory);
        }

        private static void PopulateCatagory(ref Catagory dtsCatagory)
        {
            if (File.Exists(Model.ModelBusinessRules.GetCatagoryFileLocation()))
            {
                dtsCatagory.ReadXml(Model.ModelBusinessRules.GetCatagoryFileLocation());
            }
            else
            {
                MessageBox.Show("ERROR NOT FOUND Path: " + Model.ModelBusinessRules.GetCatagoryFileLocation());
            }
        }

        internal static void SaveData(BankParser.Model.DataSets.Catagory dtsCatagory)
        {
            Model.ModelBusinessRules.catagoryXMLFileName = DataUtils.BuildXMLFileName(Model.ModelBusinessRules.CATAGORYXMLBASE);
            dtsCatagory.WriteXml(Model.ModelBusinessRules.GetCatagoryFileLocation());
            Controller.ConfigurationReader.WriteConfigurationFile();
        }

    }
}
