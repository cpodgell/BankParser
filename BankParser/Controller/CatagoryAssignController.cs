using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankParser.View;
using BankParser.Model;
using BankParser.Model.DataSets;
using BankParser.ModalForm;
using BankParser.Utils;

namespace BankParser.Controller
{
    class CatagoryAssignController
    {
        internal static void OpenCatagoryAssignForm()
        {
            CatagoryAssigningForm ca = new CatagoryAssigningForm();
            ca.Show();
        }


        internal static void PopulateContentMenuStrip(ContextMenuStrip cmsBudgetItems)
        {
            DataUtils.PopulateContextMenu(cmsBudgetItems);
        }

        internal static void GetData(ref Catagory dtsCatagory)
        {
            Model.CatagoryAssigningModel.GetData(ref dtsCatagory);
        }

        internal static void AssignCataGory(string description, string item, ref Catagory dtsCatagory)
        {
           
        }

        internal static bool AssignCatagory(string description, string item, ref Catagory dtsCatagory, ref Expenses dtsExpenses, string subCatagory, string ID)
        {
            ModalForm.ModalAssignCatagory mac = new ModalAssignCatagory();
            mac.Description = description;
            mac.Item = item;
            mac.UniqueID = ID;

            if (mac.ShowDialog() == DialogResult.OK)
            {
                if(!mac.UseUniqueID)
                {
                    ID = "";
                }
                dtsCatagory.tttCatagory.AddtttCatagoryRow(mac.Description, "S", mac.Item, mac.Description, mac.SubCatagory, ID);
                return true;
            }
            return false;
        }

        //Go through each catagory and assign the catagory in the expense table.  (shows what catagor each expense is part of).
        internal static void PropogateExpenseCatagory(Expenses dtsExpenses, Catagory dtsCatagory)
        {
            foreach (Catagory.tttCatagoryRow dtrCat in dtsCatagory.tttCatagory.Rows)
            {
                string description = dtrCat[dtsCatagory.tttCatagory.DescriptionColumn.Ordinal].ToString();
                string item = dtrCat[dtsCatagory.tttCatagory.BudgetItemNameColumn.Ordinal].ToString();
                string uniqueID = dtrCat[dtsCatagory.tttCatagory.UniqueExpenseIDColumn.Ordinal].ToString();

                foreach (Expenses.tttExpensesRow dtrExp in dtsExpenses.tttExpenses.Rows)
                {
                    if (dtrExp[dtsExpenses.tttExpenses.Description_1Column.Ordinal].ToString().Contains(description))
                    {
                        //If uniqueID is specified, only assign to the unique ID and not every one.
                        if (uniqueID == "" || uniqueID == null)
                        {
                            dtrExp[dtsExpenses.tttExpenses.CatagoryColumn.Ordinal] = item;
                        }
                        else
                        {
                            //If not unique item then do nothing.
                            if (dtrExp[dtsExpenses.tttExpenses.UniqueExpenseIDColumn.Ordinal].ToString() == uniqueID)
                            {
                                dtrExp[dtsExpenses.tttExpenses.CatagoryColumn.Ordinal] = item;
                            }
                        }
                    }
                }
            }
        }

        internal static void SaveData(ref Catagory dtsCatagory)
        {
            Model.CatagoryAssigningModel.SaveData(dtsCatagory);
        }

        internal static void DeleteCatagoryRow(ref Catagory dtsCatagory)
        {
            
        }
    }
}
