using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.CompilerServices;
using ExcelLibrary.SpreadSheet;
using System.Windows.Forms;
using MySqlX.XDevAPI.Common;
using System.Linq.Expressions;

namespace EigenbelegToolAlpha
{
    public class RegularSalesAlgoXSL
    {
        public static Microsoft.Office.Interop.Excel.Application xlApp;
        public static Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
        public static Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
        public static Microsoft.Office.Interop.Excel.Range xlRange;
        public static DateTime currentDate = DateTime.Now;
        //public static DateTime currentDate = Convert.ToDateTime("24.06.2022");
        public static DateTime lastTimeSpaceBegin;
        public static double lastSalesVolume = 0;
        public static double currentSalesVolume = 0;
        public static double foreCastSalesVolume = 0;
        public static double amountLeft = 0;
        public static double amountAtLeast = 0;
        public static int NonPayPalShare = 70;
        public static void Analyse(string path)
        {
            //gives back the beginning day of the current time space
            DateTime currentTimeSpace = GiveTimeSpace(currentDate.ToString());
            lastTimeSpaceBegin = SetLastTimeSpaceBegin(currentTimeSpace);
            int xlrow = 0;
            DateTime checkDate;
            try
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(path);
                xlWorksheet = xlWorkbook.Worksheets["Worksheet"];
                xlRange = xlWorksheet.UsedRange;
                for (xlrow = 2; xlrow <= xlRange.Rows.Count; xlrow++)
                {
                    string temp = xlRange.Cells[xlrow, 52].Text;
                    if (temp != "")
                    {
                        temp = temp.Substring(0, 10);
                        checkDate = Convert.ToDateTime(temp);
                        string payment = xlRange.Cells[xlrow, 8].Text;
                        double amount = Convert.ToDouble(xlRange.Cells[xlrow, 6].Text);
                        if (payment != "PAYPAL")
                        {
                            if (DateTime.Compare(checkDate,currentTimeSpace) >= 0)
                            {
                                currentSalesVolume += amount;
                            }
                            else if (DateTime.Compare(checkDate,currentTimeSpace) < 0 && DateTime.Compare(checkDate, lastTimeSpaceBegin) >= 0)
                            {
                                lastSalesVolume += amount;
                            }
                        }
                    }
                }
                foreCastSalesVolume = CalculateForeCastVolume();
                amountLeft = CalculateAmountLeft();
                amountAtLeast = CalculateAmoundAtLeast();
                
                xlWorkbook.Close();
                xlApp.Quit();
            }

            catch (Exception e)
            {
                MessageBox.Show("Es gab einen Fehler in Reihe " + xlrow + e.Message);
            }
        }

        public static DateTime GiveTimeSpace (string checkValue)
        {
            var date = DateTime.Now;
            int day = Convert.ToInt32(checkValue.Substring(0, 2));
            string currentMonth = checkValue.Substring(3, 2);
            var lastMonth = date.AddMonths(-1).Month;

            if (day < 6)
            {
                return Convert.ToDateTime("26."+lastMonth+".2022");
            }
            else if (day < 16)
            {
                return Convert.ToDateTime("06." + currentMonth + ".2022");
            }
            else if (day < 26)
            {
                return Convert.ToDateTime("16." + currentMonth + ".2022");
            }
            else 
            {
                return Convert.ToDateTime("26." + currentMonth + ".2022");
            }
        }
        public static DateTime SetLastTimeSpaceBegin(DateTime endOfTimeSpace)
        {
            if (endOfTimeSpace.Day != 06)
            {
                return endOfTimeSpace.AddDays(-10);
            }
            else
            {
                DateTime tempDate = endOfTimeSpace.AddMonths(-1);
                string returnValue = "26" + tempDate.ToString().Substring(2,8);
                return Convert.ToDateTime(returnValue);
            }
        }
        public static double CalculateForeCastVolume()
        {
            return lastSalesVolume * 1.2;
        }
        public static double CalculateAmountLeft()
        {
            //Dreisatz
            double temp = foreCastSalesVolume - currentSalesVolume;
            double result = (temp / NonPayPalShare) * 100+temp;
            return result;
        }
        public static double CalculateAmoundAtLeast()
        {
            //Logik: 10% Sales Drop wäre verkraftbar
            double tenPercentDropNiveau = (lastSalesVolume-currentSalesVolume) / 100 * 90;
            return (tenPercentDropNiveau / NonPayPalShare) * 100+tenPercentDropNiveau;
        }

    }
}
