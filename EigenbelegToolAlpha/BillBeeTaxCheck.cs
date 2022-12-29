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
using System;

namespace EigenbelegToolAlpha
{
    public class BillBeeTaxCheck
    {
        public static Microsoft.Office.Interop.Excel.Application xlApp;
        public static Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
        public static Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
        public static Microsoft.Office.Interop.Excel.Range xlRange;
        public static double tresholdAmount = 0;
        public static void Analyse(string path)
        {
            int xlrow = 0;
            try
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(path);
                xlWorksheet = xlWorkbook.Worksheets["Worksheet"];
                xlRange = xlWorksheet.UsedRange;
                for (xlrow = 2; xlrow <= xlRange.Rows.Count; xlrow++)
                {
                    double taxAmount = Convert.ToDouble(xlRange.Cells[xlrow, 17].Text);
                    string country = xlRange.Cells[xlrow, 11].Text;
                    if (taxAmount >0 && country != "DE")
                    {
                        tresholdAmount += Convert.ToDouble(xlRange.Cells[xlrow, 5].Text);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Es gab einen Fehler in Reihe " + xlrow + e.Message);
            }
            MessageBox.Show("Betrag "+ tresholdAmount.ToString() +" €");
        }
    }
}
