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

namespace EigenbelegToolAlpha
{
    public class BackMarketXLSAnalysis
    {
        public static Microsoft.Office.Interop.Excel.Application xlApp;
        public static Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
        public static Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
        public static Microsoft.Office.Interop.Excel.Range xlRange;

        public static string Main(string filePath, string orderID)
        {
            int xlrow = 0;
            string country = "";
            try
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(filePath);
                xlWorksheet = xlWorkbook.Worksheets["Worksheet"];
                xlRange = xlWorksheet.UsedRange;

                for (xlrow = 2; xlrow <= xlRange.Rows.Count; xlrow++)
                {
                    if (xlRange.Cells[xlrow, 1].Text == orderID)
                    {
                        country = xlRange.Cells[xlrow, 47].Text;
                        break;
                    }
                }
                xlWorkbook.Close();
                xlApp.Quit();
            }

            catch (Exception e)
            {
                MessageBox.Show("Es gab einen Fehler in Reihe: " + xlrow + e.Message);
            }
            return country;
        }
    }
}
