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
    public class ExcelManager
    {
        public static Microsoft.Office.Interop.Excel.Application xlApp;
        public static Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
        public static Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
        public static Microsoft.Office.Interop.Excel.Range xlRange;
        public static Microsoft.Office.Interop.Excel.Range xlRangeColumns;
        public ExcelManager()
        {

        }
        public static void CreateNewExcelFileCommissionRefund(string fileName, string[] columns, int rowsQuantity, string[]orderIds,string[] intern, string[] imeis, string[] videoLinks, string[] certificates)
        {
            try
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlApp.Visible = false;
                xlApp.DisplayAlerts = false;
                xlWorkbook = xlApp.Workbooks.Add(Type.Missing);
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.ActiveSheet; xlWorksheet.Name = "Main";
                xlWorksheet.Range[xlWorksheet.Cells[1, 1], xlWorksheet.Cells[100,100]]();
                xlWorksheet.Cells[1, 1] = fileName;
                xlWorksheet.Cells.Font.Size = 15;

                int counter = 1;
                foreach (var item in columns)
                {
                    xlWorksheet.Cells[2, counter] = item.ToString();
                    counter++;
                }

                int rowInsertCounter = 3;
                int arrayCounter = 0;
                foreach (var item in orderIds)
                {
                    if (item  != null)
                    {
                        xlWorksheet.Cells[rowInsertCounter, 1] = orderIds[arrayCounter];
                        xlWorksheet.Cells[rowInsertCounter, 2] = intern[arrayCounter];
                        xlWorksheet.Cells[rowInsertCounter, 3] = imeis[arrayCounter];
                        xlWorksheet.Cells[rowInsertCounter, 4] = videoLinks[arrayCounter];
                        xlWorksheet.Cells[rowInsertCounter, 5] = certificates[arrayCounter];
                        arrayCounter++; 
                        rowInsertCounter++; 
                    }
                }
                xlRange = xlWorksheet.Range[xlWorksheet.Cells[1, 1], xlWorksheet.Cells[100, 100]];
                xlRangeColumns = xlWorksheet.Range[xlWorksheet.Cells[2, 1], xlWorksheet.Cells[2, columns.Count()]];
                xlRangeColumns.Font.Bold = true;
                xlRange.EntireColumn.AutoFit();
                xlRange.HorizontalAlignment = XlHAlign.xlHAlignRight;
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
                string fullPath = desktopPath + fileName;
                xlWorkbook.SaveAs(fullPath);
                xlWorkbook.Close();
                xlApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void CreateNewExcelFile(string fileName, string[]columns, int rowsQuantity)
        {
            try
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlApp.Visible = false;
                xlApp.DisplayAlerts = false;
                xlWorkbook = xlApp.Workbooks.Add(Type.Missing);
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.ActiveSheet; xlWorksheet.Name = "Main";
                xlWorksheet.Range[xlWorksheet.Cells[1, 1], xlWorksheet.Cells[rowsQuantity + 1, columns.Count()]]();
                xlWorksheet.Cells[1, 1] = fileName;
                xlWorksheet.Cells.Font.Size = 15;

                int counter = 1;
                foreach (var item in columns)
                {
                    xlWorksheet.Cells[2, counter] = item.ToString();
                    counter++;
                }
                xlRange = xlWorksheet.Range[xlWorksheet.Cells[1, 1], xlWorksheet.Cells[rowsQuantity + 1,columns.Count()]];
                xlRangeColumns = xlWorksheet.Range[xlWorksheet.Cells[2, 1], xlWorksheet.Cells[2, columns.Count()]];
                xlRangeColumns.Font.Bold = true;
                xlRange.EntireColumn.AutoFit();


                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
                string fullPath = desktopPath + fileName;
                xlWorkbook.SaveAs(fullPath);
                xlWorkbook.Close();
                xlApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
