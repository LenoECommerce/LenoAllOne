using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;
using MySqlX.XDevAPI.Common;
using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;


namespace EigenbelegToolAlpha
{
    public partial class EvaluationsFirstPage : Form
    {
        public EvaluationsFirstPage()
        {
            InitializeComponent();
            month = lineSearchAndGetValue("Monat:", 6);
            year = lineSearchAndGetValue("Jahr:", 5);
        }
        public string basePath = Environment.CurrentDirectory + @"\Evaluation_config.txt";
        public string newPath = "";
        string result = "";
        public static string month = "";
        public string year = "";
        public static double ebayOutCome = 0;
        public static double ebayTaxGetBack = 0;
        private void EvaluationsFirstPage_Load(object sender, EventArgs e)
        {
            CreateConfigTXT();
            lbl_BackMarketNormal1.Text = lineSearchAndGetValue("BackMarket normal 1:",20);
            lbl_BackMarketNormal2.Text = lineSearchAndGetValue("BackMarket normal 2:", 20);
            lbl_BackMarketNormal3.Text = lineSearchAndGetValue("BackMarket normal 3:", 20);
            lbl_backmarketAllOrdersCSV.Text = lineSearchAndGetValue("BackMarket XLS:", 15);
            lbl_BackMarketPayPal1.Text = lineSearchAndGetValue("BackMarket PayPal 1:", 20);
            lbl_paypal2.Text = lineSearchAndGetValue("BackMarket PayPal 2:", 20);
            lbl_BackMarketPayPal3.Text = lineSearchAndGetValue("BackMarket PayPal 3:", 20);
            lbl_ebayReport.Text = lineSearchAndGetValue("Ebay Report:", 12);
            comboBox_MonthOfEvaluation.Text = lineSearchAndGetValue("Monat:", 6);
            comboBox_Years.Text = lineSearchAndGetValue("Jahr:", 5);
            lbl_ebayInvoice.Text = lineSearchAndGetValue("Ebay Rechnung:", 14);
        }
        public void CreateConfigTXT()
        {
            FileStream fs = new FileStream(basePath,FileMode.Create);
            fs.Close();
            string table = "Evaluations";
            string whereColumn = "Monat";
            string backMarketNormal1 = CheckIfClear(CRUDQueries.ExecuteQueryWithResultString(table, "BackMarketNormal1", whereColumn, month));
            string backMarketNormal2 = CheckIfClear(CRUDQueries.ExecuteQueryWithResultString(table, "BackMarketNormal2", whereColumn, month));
            string backMarketNormal3 = CheckIfClear(CRUDQueries.ExecuteQueryWithResultString(table, "BackMarketNormal3", whereColumn, month));
            string backMarketPayPal1 = CheckIfClear(CRUDQueries.ExecuteQueryWithResultString(table, "BackMarketPayPal1", whereColumn, month));
            string backMarketPayPal2 = CheckIfClear(CRUDQueries.ExecuteQueryWithResultString(table, "BackMarketPayPal2", whereColumn, month));
            string backMarketPayPal3 = CheckIfClear(CRUDQueries.ExecuteQueryWithResultString(table, "BackMarketPayPal3", whereColumn, month));
            string backMarketOrders = CheckIfClear(CRUDQueries.ExecuteQueryWithResultString(table, "BackMarketOrders", whereColumn, month));
            string ebayReport = CheckIfClear(CRUDQueries.ExecuteQueryWithResultString(table, "EbayReport", whereColumn, month));
            string ebayInvoice = CheckIfClear(CRUDQueries.ExecuteQueryWithResultString(table, "EbayInvoice", whereColumn, month));
            File.WriteAllText(basePath, "\r\nBackMarket normal 1:"+backMarketNormal1+"\r\nBackMarket normal 2:" + backMarketNormal2 + "\r\nBackMarket normal 3:" + backMarketNormal3 + "\r\nBackMarket XLS:" + backMarketOrders + "\r\nBackMarket PayPal 1:" + backMarketPayPal1 + "\r\nBackMarket PayPal 2:" + backMarketPayPal2 + "\r\nBackMarket PayPal 3:" + backMarketPayPal3 + "\r\nEbay Report:" + ebayReport + "\r\nEbay Rechnung:" + ebayInvoice + "\r\nMonat: kein Wert\r\nJahr: kein Wert");
        }
        public string CheckIfClear(string checkValue)
        {
            string returnValue = "Kein Wert hinterlegt.";
            if (checkValue == "")
            {
                return returnValue;
            }
            return checkValue;
        }
        public void lineSearchAndInsert(string searchValue)
        {
            string[] lines = File.ReadAllLines(basePath);
            int lineToEdit = 2;
            string lineToWrite = newPath;
            
            for (int i = 1; i < lines.Count(); i++)
            {
                    if (lines[i].Contains(searchValue))
                    {
                         lineToEdit = i+1;
                    }
            }

            //Neuen Path eintragen
            string line = null;
            using (StreamWriter writer = new StreamWriter(basePath))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    if (currentLine == lineToEdit)
                    {
                        writer.WriteLine(searchValue+lineToWrite);
                    }
                    else
                    {
                        writer.WriteLine(lines[currentLine - 1]);
                    }
                }
            }
         
        }

        public void LineSearchAndInsertFixValue(string searchValue)
        {
            string[] lines = File.ReadAllLines(basePath);
            int lineToEdit = 2;
            string lineToWrite = month;

            for (int i = 1; i < lines.Count(); i++)
            {
                if (lines[i].Contains(searchValue))
                {
                    lineToEdit = i + 1;
                }
            }

            //Neuen Path eintragen
            string line = null;
            using (StreamWriter writer = new StreamWriter(basePath))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    if (currentLine == lineToEdit)
                    {
                        writer.WriteLine(searchValue + lineToWrite);
                    }
                    else
                    {
                        writer.WriteLine(lines[currentLine - 1]);
                    }
                }
            }

        }
        public void LineSearchAndInsertFixValue2(string searchValue)
        {
            string[] lines = File.ReadAllLines(basePath);
            int lineToEdit = 2;
            string lineToWrite = year;

            for (int i = 1; i < lines.Count(); i++)
            {
                if (lines[i].Contains(searchValue))
                {
                    lineToEdit = i + 1;
                }
            }

            //Neuen Path eintragen
            string line = null;
            using (StreamWriter writer = new StreamWriter(basePath))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    if (currentLine == lineToEdit)
                    {
                        writer.WriteLine(searchValue + lineToWrite);
                    }
                    else
                    {
                        writer.WriteLine(lines[currentLine - 1]);
                    }
                }
            }

        }

        public string lineSearchAndGetValue(string searchValue, int charCount)
        {
            string[] lines = File.ReadAllLines(basePath);
            foreach (string line in lines)
            {
                if (line.Contains(searchValue))
                {
                    var length = line.Length;
                    var posDoublePoint = line.IndexOf(":");
                    result = line.Substring(charCount, length - charCount);
                    return result;
                }
            }
            return "";
        }
        public void EbayPDFAlgorithm ()
        {
            EvaluationsFirstPage eval = new EvaluationsFirstPage();
            TextOperations textOperations = new TextOperations();   

            string searchValueOrderValue = "Bestellungen (Gesamtbetrag abzügl. Gebühren)";
            string searchValueRefunds = "Rückerstattungen (Gesamtbetrag abzügl. Gebühren und Gutschriften)";
            string searchValueRestFees = "Sonstige Gebühren";

            double tempOrderValue = 0;
            double tempValueRefunds = 0;
            double tempRestFees = 0;

            string path = eval.lineSearchAndGetValue("Ebay Report:",12);
            string tempPath = "ebaydata.txt";
            FileStream stream = File.Create(tempPath);
            stream.Close();
            File.WriteAllText(tempPath, ExtractTextFromPdf(path));
            string[] allLines = File.ReadAllLines(tempPath);

            //Order Value
            int indexOrderValue = TextOperations.findLine(allLines, searchValueOrderValue)-1;
            tempOrderValue = TextOperations.getValueOfOneLineEbayFormat(indexOrderValue, allLines, 15, "Gebühren)");
            //Return Value
            int indexValueRefunds = TextOperations.findLine(allLines, searchValueRefunds) - 1;
            tempValueRefunds = TextOperations.getValueOfOneLineEbayFormat(indexValueRefunds, allLines, 19, "Gutschriften)");
            //RestFees
            int indexRestFees = TextOperations.findLine(allLines, searchValueRestFees) - 1;
            tempRestFees = TextOperations.getValueOfOneLineEbayFormat(indexRestFees, allLines, 14, "Gebühren");

            ebayOutCome = tempOrderValue-tempValueRefunds-tempRestFees;

        }
        public void EbayPDFInvoiceAlgorithm()
        {
            EvaluationsFirstPage eval = new EvaluationsFirstPage();
            TextOperations textOperations = new TextOperations();

            string searchValueOrderValue = "USt zu 19 %";
            double tempTaxGetBack = 0;

            string path = eval.lineSearchAndGetValue("Ebay Rechnung:", 14);
            string tempPath = "ebaydata2.txt";
            FileStream stream = File.Create(tempPath);
            stream.Close();
            File.WriteAllText(tempPath, ExtractTextFromPdf(path));
            string[] allLines = File.ReadAllLines(tempPath);

            int indexTaxGetBack = TextOperations.findLine(allLines, searchValueOrderValue) - 1;
            tempTaxGetBack = TextOperations.getValueOfOneLineEbayFormat(indexTaxGetBack, allLines, 7, "19 % ");

            ebayTaxGetBack = tempTaxGetBack;
        }
        public static string ExtractTextFromPdf(string path)
        {
            using (PdfReader reader = new PdfReader(path))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }

                return text.ToString();
            }
        }
        public string getOpenFileDialog ()
        {
            openFD.ShowDialog();
            return openFD.FileName;
        }

        private void lbl_BackMarketNormal1_Click(object sender, EventArgs e)
        {
            newPath = getOpenFileDialog();
            lineSearchAndInsert("BackMarket normal 1:");
            lbl_BackMarketNormal1.Text = newPath;
        }
        private void lbl_BackMarketNormal2_Click(object sender, EventArgs e)
        {
            newPath = getOpenFileDialog();
            lineSearchAndInsert("BackMarket normal 2:");
            lbl_BackMarketNormal2.Text = newPath;
        }

        private void lbl_BackMarketNormal3_Click(object sender, EventArgs e)
        {
            newPath = getOpenFileDialog();
            lineSearchAndInsert("BackMarket normal 3:");
            lbl_BackMarketNormal3.Text = newPath;
        }

        private void lbl_BackMarketPayPal1_Click(object sender, EventArgs e)
        {
            newPath = getOpenFileDialog();
            lineSearchAndInsert("BackMarket PayPal 1:");
            lbl_BackMarketPayPal1.Text = newPath;
        }

        private void lbl_BackMarketPayPal2_Click(object sender, EventArgs e)
        {
            newPath = getOpenFileDialog();
            lineSearchAndInsert("BackMarket PayPal 2:");
            lbl_paypal2.Text = newPath;
        }

        private void lbl_BackMarketPayPal3_Click(object sender, EventArgs e)
        {
            newPath = getOpenFileDialog();
            lineSearchAndInsert("BackMarket PayPal 3:");
            lbl_BackMarketPayPal3.Text = newPath;
        }

        private void lbl_ebayReport_Click(object sender, EventArgs e)
        {
            newPath = getOpenFileDialog();
            lineSearchAndInsert("Ebay Report:");
            lbl_ebayReport.Text = newPath;
        }


        private void btn_ContinueWithEvaluation2_Click(object sender, EventArgs e)
        {
            string backMarketNormal123 = lbl_BackMarketNormal1.Text;
            string backMarketNormal1 = lbl_BackMarketNormal1.Text.Replace(@"\", @"\\");
            string backMarketNormal2 = lbl_BackMarketNormal2.Text.Replace(@"\", @"\\");
            string backMarketNormal3 = lbl_BackMarketNormal3.Text.Replace(@"\", @"\\");
            string backMarketPayPal1 = lbl_BackMarketPayPal1.Text.Replace(@"\", @"\\");
            string backMarketPayPal2 = lbl_paypal2.Text.Replace(@"\", @"\\");
            string backMarketPayPal3 = lbl_BackMarketPayPal3.Text.Replace(@"\", @"\\");
            string backMarketOrders = lbl_backmarketAllOrdersCSV.Text.Replace(@"\", @"\\");
            string ebayInvoice = lbl_ebayInvoice.Text.Replace(@"\", @"\\");
            string ebayReport = lbl_ebayReport.Text.Replace(@"\", @"\\");

            string query = string.Format("UPDATE `Evaluations` SET `BackMarketNormal1` = '{0}', `BackMarketNormal2` = '{1}', `BackMarketNormal3` = '{2}', `BackMarketPayPal1` = '{3}', `BackMarketPayPal2` = '{4}', `BackMarketPayPal3` = '{5}', `BackMarketOrders` = '{6}', `EbayReport` = '{7}', `EbayInvoice` = '{8}' WHERE `Monat` = '" + month+"'"
                                        , backMarketNormal1, backMarketNormal2, backMarketNormal3, backMarketPayPal1, backMarketPayPal2, backMarketPayPal3,backMarketOrders, ebayReport, ebayInvoice);
            CRUDQueries.ExecuteQuery(query);
            File.WriteAllText(basePath, "\r\nBackMarket normal 1:" +backMarketNormal1 + "\r\nBackMarket normal 2:" + backMarketNormal2 + "\r\nBackMarket normal 3:" + backMarketNormal3 + "\r\nBackMarket XLS:" + backMarketOrders + "\r\nBackMarket PayPal 1:" + backMarketPayPal1 + "\r\nBackMarket PayPal 2:" + backMarketPayPal2 + "\r\nBackMarket PayPal 3:" + backMarketPayPal3 + "\r\nEbay Report:" + ebayReport + "\r\nEbay Rechnung:" + ebayInvoice + "\r\nMonat:" + month + "\r\nJahr:" + year);
            EbayPDFInvoiceAlgorithm();
            EvaluationSecondForm frm = new EvaluationSecondForm();
            frm.Show();
            this.Hide();
        }

        private void comboBox_MonthOfEvaluation_SelectedIndexChanged(object sender, EventArgs e)
        {
            month = comboBox_MonthOfEvaluation.Text;
            LineSearchAndInsertFixValue("Monat:");
            EvaluationsFirstPage_Load(sender, e);
        }


        private void comboBox_Years_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = comboBox_Years.Text;
            LineSearchAndInsertFixValue2("Jahr:");
        }

        private void lbl_backmarketAllOrdersCSV_Click(object sender, EventArgs e)
        {
            newPath = getOpenFileDialog();
            lineSearchAndInsert("BackMarket XLS:");
            lbl_backmarketAllOrdersCSV.Text = newPath;
        }

        private void lbl_ebayInvoice_Click(object sender, EventArgs e)
        {
            newPath = getOpenFileDialog();
            lineSearchAndInsert("Ebay Rechnung:");
            lbl_ebayInvoice.Text = newPath;
        }
    }
}
