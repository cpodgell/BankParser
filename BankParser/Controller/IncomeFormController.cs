using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankParser.View;
using BankParser.Model;
using BankParser.Model.DataSets;
using System.Windows.Forms;

namespace BankParser.Controller
{
    public static class IncomeFormController
    {

        static public void OpenIncomeForm()
        {
            IncomeForm incomeForm = new IncomeForm();
            incomeForm.Show();
        }

        static public void GetData(ref Income dtsIncome)
        {
            Model.IncomeFormModel.GetData(ref dtsIncome);
        }

        internal static void GenerateYear(ref Income dtsIncome, string yearStr, string amountStr)
        {
            Int16 year;
            decimal amount;
            bool fail = false;
            if (!Int16.TryParse(yearStr, out year))
            {
                MessageBox.Show("INVALID YEAR!");
                fail = true;
            }
            if (!Decimal.TryParse(amountStr, out amount))
            {
                MessageBox.Show("INVALID AMOUNT!");
                fail = true;
            }

            //check if year exists
            if (!fail)
            {
                bool yearFound = false;
                foreach (BankParser.Model.DataSets.Income.tttIncomeRow dtrTmp in dtsIncome.tttIncome.Rows)
                {
                    Type g = dtrTmp[dtsIncome.tttIncome.YearColumn.ColumnName].GetType();
                    Int16 yearCompare = (Int16)dtrTmp[dtsIncome.tttIncome.YearColumn.ColumnName];
                    if (yearCompare == year)
                    {
                        yearFound = true;
                    }
                }
                if (yearFound)
                {
                    MessageBox.Show("Year already exists for: " + year);
                }
                else
                {
                    for (int i = 1; i < 13; i++)
                    {
                        Income.tttIncomeRow dtr = dtsIncome.tttIncome.NewtttIncomeRow();
                        dtr[dtsIncome.tttIncome.YearColumn.Ordinal] = year;
                        dtr[dtsIncome.tttIncome.AmountColumn.Ordinal] = amount;
                        dtr[dtsIncome.tttIncome.MonthColumn.Ordinal] = i;
                        dtr[dtsIncome.tttIncome.IsCPPColumn.Ordinal] = false;
                        dtsIncome.tttIncome.Rows.Add(dtr);
                    }
                }
            }
        }
        

        internal static void SaveData(ref Income dtsIncome)
        {
            Model.IncomeFormModel.SaveData(dtsIncome);
        }



        internal static void ClearData(ref Income dtsIncome)
        {
            dtsIncome.Clear();
        }
    }
}
