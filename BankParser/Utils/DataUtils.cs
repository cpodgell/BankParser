using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BankParser.Model.DataSets;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BankParser.Utils
{
    static class DataUtils
    {
        internal static void ConsolidateDataTableToExpenses(DataTable t, ref Expenses dtsExpenses, string bankName, ref List<string> errorlog)
        {
           bool noBankFound = true;
           if(bankName.Contains("RBC"))
            {
                ConsolidateRBCDataTableToExpenses(t, ref dtsExpenses, ref errorlog);
                noBankFound = false;
            }
           if(bankName.Contains("BMO"))
            {
                ConsolidateBMODataTableToExpenses(t, ref dtsExpenses, ref errorlog);
                noBankFound = false;

            }
           if(noBankFound)
            {
                errorlog.Add("No bank found for file: " + bankName);
            }
        }

        private static void ConsolidateRBCDataTableToExpenses(DataTable t, ref Expenses dtsExpenses, ref List<string> errorlog)
        {
            foreach (DataRow dtrRow in t.Rows)
            {
                string ChequeNumber = "";
                string Description1 = "";
                string Description2 = "";
                decimal CAD = 0;
                decimal USD = 0;

                bool errorEncountered = false;
                CultureInfo MyCultureInfo = new CultureInfo("en-US");
                string AccountType = dtrRow[0].ToString();
                string AccountNumber = dtrRow[1].ToString();
                string dateString = dtrRow[2].ToString();

                DateTime TransactionDate = new DateTime(); 

                string[] dateFormats = new string[] { "MM/dd/yyyy", "MM/d/yyyy", "M/dd/yyyy", "M/d/yyyy" };

                if (!DateTime.TryParseExact(dateString, dateFormats, new CultureInfo("en-US"), DateTimeStyles.None, out TransactionDate))
                {
                    errorlog.Add("ERror parsing date: " + dateString);
                    errorEncountered = true;
                }
                //if(!DateTime.ParseExact(dtrRow[2].ToString(), "D", out TransactionDate))
                //{
                //    Trace.WriteLine("NOPE!");

                //}

                if (!errorEncountered)
                {
                    ChequeNumber = dtrRow[3].ToString();
                    Description1 = dtrRow[4].ToString();
                    Description2 = dtrRow[5].ToString();
                    decimal.TryParse(dtrRow[6].ToString(), out CAD);
                    decimal.TryParse(dtrRow[7].ToString(), out USD);

                    string Catagory = "";

                    if (!Description1.ToLower().Contains("payment"))
                    {
                        dtsExpenses.tttExpenses.AddtttExpensesRow(AccountType, AccountNumber, TransactionDate, ChequeNumber, Description1, Description2, CAD, USD, Catagory, GenerateUniqueString());
                    }
                }
                else
                {
                    string itemString = "";
                    for (int i = 0; i < dtrRow.ItemArray.Length; i++)
                    {
                        itemString += "\"" + dtrRow[i] + "\"";
                    }
                    errorlog.Add("ERror encountered - what do you wish to do with this string? " + itemString);
                }
            }
        }

        private static void ConsolidateBMODataTableToExpenses(DataTable t, ref Expenses dtsExpenses, ref List<string> errorlog)
        {
            foreach (DataRow dtrRow in t.Rows)
            {
                string ChequeNumber = "";
                string Description1 = "";
                string Description2 = "";
                decimal CAD = 0;
                decimal USD = 0;

                bool errorEncountered = false;
                CultureInfo MyCultureInfo = new CultureInfo("en-US");
                ChequeNumber = dtrRow[0].ToString();
                string AccountNumber = dtrRow[1].ToString();
                string AccountType = "BMO";
                string dateString = dtrRow[3].ToString();

                DateTime TransactionDate = new DateTime();

                string[] dateFormats = new string[] { "yyyyMMdd" };

                if (!DateTime.TryParseExact(dateString, dateFormats, new CultureInfo("en-US"), DateTimeStyles.None, out TransactionDate))
                {
                    errorlog.Add("ERror parsing date: " + dateString);
                    errorEncountered = true;
                }
                //if(!DateTime.ParseExact(dtrRow[2].ToString(), "D", out TransactionDate))
                //{
                //    Trace.WriteLine("NOPE!");

                //}

                if (!errorEncountered)
                {
                    ChequeNumber = dtrRow[3].ToString();
                    Description1 = dtrRow[5].ToString();
                    decimal.TryParse(dtrRow[4].ToString(), out CAD);
                    USD = 0;

                    string Catagory = "";

                    if (!Description1.ToLower().Contains("payment"))
                    {
                        dtsExpenses.tttExpenses.AddtttExpensesRow(AccountType, AccountNumber, TransactionDate, ChequeNumber, Description1, Description2, CAD, USD, Catagory, GenerateUniqueString());
                    }
                }
                else
                {
                    string itemString = "";
                    for (int i = 0; i < dtrRow.ItemArray.Length; i++)
                    {
                        itemString += "\"" + dtrRow[i] + "\"";
                    }
                    errorlog.Add("ERror encountered - what do you wish to do with this string? " + itemString);
                }
            }
        }

        internal static void PopulateContextMenu(ContextMenuStrip cmsBudgetItems)
        {
            BudgetItems bi = new BudgetItems();

            Model.BudgetFormModel.GetBudgetData(ref bi);
            foreach (BudgetItems.tttBudgetItemsRow dtrB in bi.tttBudgetItems.Rows)
            {
                cmsBudgetItems.Items.Add(dtrB[bi.tttBudgetItems.ItemNameColumn.ColumnName].ToString());
            }
        }

        public static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            //string[] columnNames = new string[] { "Date", "ProductName", "Cost", "Deposit" };

            DataTable csvDataTable = new DataTable();
            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    AddDataColumns(csvReader, csvDataTable);

                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvDataTable.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EXCEPTION: " + ex.Message);
            }

            //// Then add one last column for catagory
            //DataColumn datacolumn = new DataColumn();
            //datacolumn.AllowDBNull = true;
            //datacolumn.ColumnName = "Category";
            //csvDataTable.Columns.Add(datacolumn);

            return csvDataTable;
        }

        static private void AddDataColumns(Microsoft.VisualBasic.FileIO.TextFieldParser csvReader, DataTable table)
        {
            string[] columns = csvReader.ReadFields();

            //If table has columns already, we don't want to add any.
            if (table.Columns.Count == 0)
            {
                for (int i = 0; i < columns.Length; i++)
                {
                    DataColumn dtcCol = new DataColumn();
                    dtcCol.AllowDBNull = true;
                    dtcCol.ColumnName = columns[i];
                    table.Columns.Add(dtcCol);
                }

                DataColumn dtcCol2 = new DataColumn();
                dtcCol2.AllowDBNull = true;
                dtcCol2.ColumnName = "Empty";
                table.Columns.Add(dtcCol2);
            }
        }

        static public void FixRoyalBankPDFCSV()
        {

            ModalForm.PromptPathBox prbForm = new ModalForm.PromptPathBox();
            if (prbForm.ShowDialog() == DialogResult.OK)
            {
                int year = prbForm.Year;
                TextFieldParser csvReader = new TextFieldParser(prbForm.ImportFilePath  + ".csv");
                csvReader.SetDelimiters(new string[] { "," });
                csvReader.HasFieldsEnclosedInQuotes = true;

                string month = "";
                string day = "";
                decimal amount = 0;
                string name = "";

                int count = 0;
                string csv = "Account Type,Account Number,Transaction Date,Cheque Number,Description 1,Description 2,CAD$,USD$,\r\n";

                while (!csvReader.EndOfData)
                {
                    string[] fieldData = csvReader.ReadFields();
                    //Making empty value as null
                    for (int i = 0; i < fieldData.Length; i++)
                    {
                        if (!ContainsMonth(fieldData[i]).Equals("") && !fieldData[i].ToLower().Contains("statement") && !fieldData[i].ToLower().Contains("payment"))
                        {
                            count++;
                            month = ContainsMonth(fieldData[i]);
                            string removedAlphanumberic = Regex.Replace(fieldData[i], "[^0-9.]", "");
                            day = removedAlphanumberic.Substring(0, 2);
                            name = fieldData[i].Substring(14);
                        }
                        if (fieldData[i].Contains("$") && !fieldData[i].Contains("-") && !month.Equals("") && !name.Equals(""))
                        {
                            string removedAlphanumberic = Regex.Replace(fieldData[i], "[^0-9.]", "");
                            decimal cad;
                            if (Decimal.TryParse(removedAlphanumberic.Replace(" ", ""), out cad))
                            {
                                amount = cad;
                                count++;
                            }
                            else
                            {
                                MessageBox.Show("Error " + fieldData[i]);
                            }
                        }

                        if (count == 2)
                        {
                            //Trace.WriteLine(year + "\\" + month + "\\" + day + " " + amount + " " + name);
                            //"Account Type,Account Number,Transaction Date,Cheque Number,Description 1,Description 2,CAD$,USD$,\r\n";
                            int monthNumber = GetMonthNumber(month);
                            csv += "Visa,4510000000000000," + monthNumber + "/" + day + "/" + year + ",," + name + "," + "" + "," + (-1 * amount).ToString() + ",,\r\n";
                            month = "";
                            day = "";
                            amount = 0;
                            name = "";
                            count = 0;
                        }
                    }
                } // while
                Trace.WriteLine(csv);
                System.IO.StreamWriter file = new System.IO.StreamWriter(prbForm.OutputFilePath +".csv");
                file.WriteLine(csv);

                file.Close();
            }
        }

        static public void FixMasterCardPDFCSV()
        {
            ModalForm.PromptPathBox prbForm = new ModalForm.PromptPathBox();
            if (prbForm.ShowDialog() == DialogResult.OK)
            {
                int year = prbForm.Year;
                TextFieldParser csvReader = new TextFieldParser(prbForm.ImportFilePath + ".csv");
                csvReader.SetDelimiters(new string[] { "," });
                csvReader.HasFieldsEnclosedInQuotes = true;

                string month = "";
                string day = "";
                decimal amount = 0;
                string name = "";

                string csv = "Account Type,Account Number,Transaction Date,Cheque Number,Description 1,Description 2,CAD$,USD$,\r\n";

                while (!csvReader.EndOfData)
                {
                    string[] fieldData = csvReader.ReadFields();

                    string monthDay = fieldData[0];


                    month = monthDay.Substring(0, 3);

                    day = monthDay.Replace(month + ".", "").Replace(" ", "");

                    if (day.Length == 1)
                    {
                        day = "0" + day;
                    }


                    name = fieldData[1];

                    decimal.TryParse(fieldData[2], out amount);

                    //Trace.WriteLine(year + "\\" + month + "\\" + day + " " + amount + " " + name);
                    //"Account Type,Account Number,Transaction Date,Cheque Number,Description 1,Description 2,CAD$,USD$,\r\n";
                    int monthNumber = GetMonthNumber(month);
                    csv += "MasterCard,4510000000000000," + monthNumber + "/" + day + "/" + year + ",," + name + "," + "" + "," + (amount).ToString() + ",,\r\n";
                    month = "";
                    day = "";
                    amount = 0;
                    name = "";
                } // while
                Trace.WriteLine(csv);
                System.IO.StreamWriter file = new System.IO.StreamWriter(prbForm.OutputFilePath + ".csv");
                file.WriteLine(csv);

                file.Close();
            }
        }

        private static string ContainsMonth(string str)
        {
            string[] months = GetMonths();

            foreach (string month in months)
            {
                if (str.ToLower().Contains(month + " "))
                {
                    return month;
                }
            }
            return "";

        }

        public static string[] GetMonths()
        {
            string[] Months = { "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec" };
            return Months;
        }

        public static int GetMonthNumber(string monthName)
        {
            return DateTime.ParseExact(monthName, "MMM", CultureInfo.CurrentCulture).Month;
        }

        public static string GetMonthFromNumber(int month)
        {
            return GetMonths()[month - 1];
        }

        public static string GenerateUniqueString()
        {
            return Guid.NewGuid().ToString("N");
        }

        public static string BuildXMLFileName(string xmlBase)
        {
            return xmlBase + "-" + Controller.FormattingUtils.GetDateStamp() + ".xsd";
        }

        public static void PopulateContextMenu()
        {

        }
    }
}
