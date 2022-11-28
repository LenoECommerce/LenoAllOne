using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;

namespace EigenbelegToolAlpha
{
    public class EvaluationsBackMarketPDF
    {
        private void Main()
        {
            BuildTextFiles("Normal","BackMarket normal ");
            BuildTextFiles("PayPal", "BackMarket PayPal ");
        }
        private string FindPDFViaOrderNumber (string orderID)
        {
            string[] numbers = new string[3] { "1", "2", "3" };
            string pathPreset = "BackmarketNormal";
            string searchValueHeadingGrossSalesList = "MONTANT DES COMMANDES EXPEDIÉES DU";
            int arrayIndexer = 0;
            foreach (string number in numbers)
            {
                string buildPath = pathPreset + numbers[arrayIndexer] + ".txt";
                arrayIndexer++;
                string[] allLines = File.ReadAllLines(buildPath);
                int indexGrossSalesList = findLine(allLines, searchValueHeadingGrossSalesList);
                // hier abfragen ob die hauptorder vorhanden ist
                foreach (string line in allLines)
                {
                    if (line.Contains(orderID))
                    {
                        return buildPath;
                    }
                }
            }


            //hier nochmal anpassen!!
            string[] numbers2 = new string[3] { "1", "2", "3" };
            string pathPreset2 = "BackmarketPayPal";
            int arrayIndexer2 = 0;
            foreach (string number in numbers2)
            {
                string buildPath2 = pathPreset2 + numbers2[arrayIndexer2] + ".txt";
                arrayIndexer2++;
                if (File.ReadAllText(buildPath2).Contains(orderID))
                {
                    return buildPath2;
                }
            }
            return "";
        }
        public int findLine(string[] array, string searchValue)
        {
            int backValue = 0;
            for (int i = 1; i < array.Count(); i++)
            {
                if (array[i].Contains(searchValue))
                {
                    backValue = i + 1;
                    break;
                }
            }
            return backValue;
        }
        private void BuildTextFiles(string type, string preSet)
        {
            EvaluationsFirstPage eval = new EvaluationsFirstPage();
            string[] numbers = new string[3] { "1", "2", "3" };
            string pathPreset = preSet;
            string buildPath = "";
            //build 3 .txt files
            int arrayIndexer = 0;
            foreach (string number in numbers)
            {
                buildPath = pathPreset + numbers[arrayIndexer] + ":";
                arrayIndexer++;
                string path = eval.lineSearchAndGetValue(buildPath, 20);
                string tempPath = "Backmarket" + type +arrayIndexer + ".txt";
                FileStream stream = File.Create(tempPath);
                stream.Close();
                File.WriteAllText(tempPath, ExtractTextFromPdf(path));
                if (File.Exists(path) != true)
                {
                    break;
                }
                
            }
        }

        public static string ExtractTextFromPdf(string path)
        {
            try
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
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message);
            }
        }
    }
       
}
