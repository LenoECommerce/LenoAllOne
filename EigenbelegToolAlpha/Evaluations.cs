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
        public string fileName = "Evaluation_config.txt";
        public string newPath = "";
        string result = "";
        public string month = "";
        public string year = "";
        public static double ebayOutCome = 0;
        public static double ebayTaxGetBack = 0;
        private void EvaluationsFirstPage_Load(object sender, EventArgs e)
        {
            CreateConfigTXT();
            lbl_BackMarketNormal1.Text = lineSearchAndGetValue("BackMarket normal 1:",20);
            lbl_BackMarketNormal2.Text = lineSearchAndGetValue("BackMarket normal 2:", 20);
            lbl_BackMarketNormal3.Text = lineSearchAndGetValue("BackMarket normal 3:", 20);
            lbl_BackMarketPayPal1.Text = lineSearchAndGetValue("BackMarket PayPal 1:", 20);
            lbl_eetad.Text = lineSearchAndGetValue("BackMarket PayPal 2:", 20);
            lbl_BackMarketPayPal3.Text = lineSearchAndGetValue("BackMarket PayPal 3:", 20);
            lbl_ebayReport.Text = lineSearchAndGetValue("Ebay Report:", 12);
            lbl_ebayInvoice.Text = lineSearchAndGetValue("Ebay Rechnung:",14);
            comboBox_MonthOfEvaluation.Text = lineSearchAndGetValue("Monat:", 6);
            comboBox_Years.Text = lineSearchAndGetValue("Jahr:", 5);
        }
        public void CreateConfigTXT()
        {
            string path = "Evaluation_config.txt";
            FileStream stream = File.Create(path);
            stream.Close();
            File.WriteAllText(path, "\r\nBackMarket normal 1: kein Wert\r\nBackMarket normal 2: kein Wert\r\nBackMarket normal 3: kein Wert\r\nBackMarket PayPal 1: kein Wert\r\nBackMarket PayPal 2: kein Wert\r\nBackMarket PayPal 3: kein Wert\r\nEbay Report: kein Wert\r\nEbay Rechnung: kein Wert\r\nMonat: kein Wert\r\nJahr: kein Wert");
            
        }
        public void lineSearchAndInsert(string searchValue)
        {
            string[] lines = File.ReadAllLines(fileName);
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
            using (StreamWriter writer = new StreamWriter(fileName))
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
            string[] lines = File.ReadAllLines(fileName);
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
            using (StreamWriter writer = new StreamWriter(fileName))
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
            string[] lines = File.ReadAllLines(fileName);
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
            using (StreamWriter writer = new StreamWriter(fileName))
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
            string[] lines = File.ReadAllLines(fileName);
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
            lbl_eetad.Text = newPath;
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
            EbayPDFAlgorithm();
            EbayPDFInvoiceAlgorithm();
            EvaluationSecondForm frm = new EvaluationSecondForm();
            frm.Show();
            this.Hide();
        }

        private void comboBox_MonthOfEvaluation_SelectedIndexChanged(object sender, EventArgs e)
        {
            month = comboBox_MonthOfEvaluation.Text;
            LineSearchAndInsertFixValue("Monat:");
        }

        private void lbl_ebayInvoice_Click(object sender, EventArgs e)
        {
            newPath = getOpenFileDialog();
            lineSearchAndInsert("Ebay Rechnung:");
            lbl_ebayInvoice.Text = newPath;
        }

        private void comboBox_Years_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = comboBox_Years.Text;
            LineSearchAndInsertFixValue2("Jahr:");
        }
    }
}
