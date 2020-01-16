using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.VisualBasic.FileIO;
using BankParser.Utils;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using BankParser.Model.DataSets;

namespace BankParser.Model
{
    static class ExpenseImportFormModel
    {

        public static void GetCSVData(ref Expenses dtsExpenses, ref List<string> errorlog)
        {
            string[] csvFiles = Directory.GetFiles(Model.ModelBusinessRules.GetCSVLocation());

            foreach (string csvFile in csvFiles)
            {
                MessageBox.Show("" + csvFile);
                DataTable t = DataUtils.GetDataTabletFromCSVFile(csvFile);

                DataUtils.ConsolidateDataTableToExpenses(t, ref dtsExpenses, csvFile, ref errorlog);
            }
        }

        //Take the CSV dtsExpensesExport data set, compare it to the earlier XML, add rows to ConsolidatedExpenseXML and then save the Consolidated
        internal static void ImportCSV(ref Expenses dtsExpensesToExport, ref List<string> errorlog)
        {
            //dtsExpensesToExport are the proposed ones to export, lets compare it against dtsExpense to only add new rows.

            Expenses consolidatedExpenseXML = new Expenses();
            PopulateExpense(ref consolidatedExpenseXML);

            int duplicates = 0;
            Expenses dtsExpenseXMLData = new Expenses();
            DeletedExpenses dtsDeletedXMLExpenses = new DeletedExpenses();

            PopulateDeletedExpenses(ref dtsDeletedXMLExpenses);

            if (PopulateExpense(ref dtsExpenseXMLData))
            {
                foreach (Expenses.tttExpensesRow dtrCSVRow in dtsExpensesToExport.tttExpenses.Rows)
                {
                    bool rowIsDuplicate = false;
                    foreach (Expenses.tttExpensesRow dtrRow in dtsExpenseXMLData.tttExpenses.Rows)
                    {
                        DateTime xmlTransactionDate = (DateTime)dtrRow[dtsExpenseXMLData.tttExpenses.TransactionDateColumn.Ordinal];
                        DateTime csvTransactionDate = (DateTime)dtrCSVRow[dtsExpenseXMLData.tttExpenses.TransactionDateColumn.Ordinal];

                        Decimal xmlCAD = (decimal)dtrRow[dtsExpenseXMLData.tttExpenses._CAD_Column.Ordinal];
                        Decimal csvCAD = (decimal)dtrCSVRow[dtsExpenseXMLData.tttExpenses._CAD_Column.Ordinal];

                        string xmlDescr = dtrRow[dtsExpenseXMLData.tttExpenses.Description_1Column.Ordinal].ToString();
                        string csvDescr = dtrCSVRow[dtsExpenseXMLData.tttExpenses.Description_1Column.Ordinal].ToString();

                        if (xmlTransactionDate == csvTransactionDate && xmlCAD == csvCAD && xmlDescr == csvDescr)
                        {
                            rowIsDuplicate = true;
                            duplicates++;
                            break;
                        }
                    }
                    foreach (DeletedExpenses.tttDeletedExpensesRow dtrRow in dtsDeletedXMLExpenses.tttDeletedExpenses.Rows)
                    {
                        DateTime xmlTransactionDate = (DateTime)dtrRow[dtsDeletedXMLExpenses.tttDeletedExpenses.TransactionDateColumn.Ordinal];
                        DateTime csvTransactionDate = (DateTime)dtrCSVRow[dtsExpenseXMLData.tttExpenses.TransactionDateColumn.Ordinal];

                        Decimal xmlCAD = (decimal)dtrRow[dtsDeletedXMLExpenses.tttDeletedExpenses._CAD_Column.Ordinal];
                        Decimal csvCAD = (decimal)dtrCSVRow[dtsExpenseXMLData.tttExpenses._CAD_Column.Ordinal];

                        string xmlDescr = dtrRow[dtsDeletedXMLExpenses.tttDeletedExpenses.Description_1Column.Ordinal].ToString();
                        string csvDescr = dtrCSVRow[dtsExpenseXMLData.tttExpenses.Description_1Column.Ordinal].ToString();

                        if (xmlTransactionDate == csvTransactionDate && xmlCAD == csvCAD && xmlDescr == csvDescr)
                        {
                            rowIsDuplicate = true;
                            duplicates++;
                            break;
                        }
                    }

                    if (!rowIsDuplicate)
                    {
                        
                        consolidatedExpenseXML.tttExpenses.ImportRow(dtrCSVRow);
                    }
                }
            }

            errorlog.Add("Duplicates: " + duplicates.ToString() + "  RowsImported: " + (consolidatedExpenseXML.tttExpenses.Rows.Count - dtsExpenseXMLData.tttExpenses.Rows.Count));
            SaveExpenseData(consolidatedExpenseXML);

        }

        internal static void GetExpenseData(ref Expenses dtsExpenses)
        {
            dtsExpenses.Clear();
            PopulateExpense(ref dtsExpenses);
        }

        internal static void GetDeletedExpenseData(ref DeletedExpenses dtsDeletedExpenses)
        {
            dtsDeletedExpenses.Clear();
            PopulateDeletedExpenses(ref dtsDeletedExpenses);
        }

        internal static void GetData(ref Expenses dtsExpenses, int year)
        {

        }

        private static bool PopulateExpense(ref Expenses dtsExpenses)
        {
            if (File.Exists(Model.ModelBusinessRules.GetExpenseFileLocation()))
            {
                dtsExpenses.ReadXml(Model.ModelBusinessRules.GetExpenseFileLocation());
                return true;
            }
            else
            {
                MessageBox.Show("ERROR NOT FOUND Path: " + Model.ModelBusinessRules.GetExpenseFileLocation());
                return false;
            }
        }

        private static bool PopulateDeletedExpenses(ref DeletedExpenses dtsDeletedExpenses)
        {
            if (File.Exists(Model.ModelBusinessRules.GetDeletedExpenseFileLocation()))
            {
                dtsDeletedExpenses.ReadXml(Model.ModelBusinessRules.GetDeletedExpenseFileLocation());
                return true;
            }
            else
            {
                MessageBox.Show("ERROR NOT FOUND Path: " + Model.ModelBusinessRules.GetDeletedExpenseFileLocation());
                return false;
            }
        }



        internal static void SaveExpenseData(Expenses dtsExpenses)
        {
            Model.ModelBusinessRules.expenseXMLFileName = DataUtils.BuildXMLFileName(Model.ModelBusinessRules.EXPENSEXMLBASE);
            dtsExpenses.WriteXml(Model.ModelBusinessRules.GetExpenseFileLocation());
            Controller.ConfigurationReader.WriteConfigurationFile();
        }

        internal static void SaveDeletedExpenseData(DeletedExpenses dtsDeletedExpenses)
        {
            Model.ModelBusinessRules.deletedExpenseXMLFilename = DataUtils.BuildXMLFileName(Model.ModelBusinessRules.DELETEDEXPENSEXMLBASE);
            dtsDeletedExpenses.WriteXml(Model.ModelBusinessRules.GetDeletedExpenseFileLocation());
            Controller.ConfigurationReader.WriteConfigurationFile();
        }
    }
}
