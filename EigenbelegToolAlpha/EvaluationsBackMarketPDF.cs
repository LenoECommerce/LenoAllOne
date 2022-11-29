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
        public void Main()
        {
            BuildTextFiles("Normal","BackMarket normal ");
            BuildTextFiles("PayPal", "BackMarket PayPal ");
        }
        public string GetSalesVolume (string orderID, string pdf)
        {
            return "N/A";
        }
        public string FindPDFViaOrderNumber (string orderID)
        {
            string[] numbers = new string[3] { "1", "2", "3" };
            string pathPreset = "BackmarketNormal";
            string searchValueForGrossSalesList = " 1 ";
            string searchValueForGrossSalesList2 = " 2 ";
            string searchValueHeadingGrossSalesList = "MONTANT DES COMMANDES EXPEDIÉES DU";
            int arrayIndexerPDF = 0;
            int arrayIndexerSales = 0;
            foreach (string number in numbers)
            {
                string buildPath = pathPreset + numbers[arrayIndexerPDF] + ".txt";
                arrayIndexerPDF++;
                string[] salesList = new string[1000];
                string[] allLines = File.ReadAllLines(buildPath);
                int indexGrossSalesList = findLine(allLines, searchValueHeadingGrossSalesList);
                //Alle Orders in Array auflisten | sozusagen ein Filter von allLines[]
                for (int i = indexGrossSalesList + 1; i < allLines.Count(); i++)
                {
                    if (allLines[i].Contains(searchValueForGrossSalesList) || allLines[i].Contains(searchValueForGrossSalesList2))
                    {
                        salesList[arrayIndexerSales] = allLines[i];
                        arrayIndexerSales++;
                    }
                    else
                    {
                        break;
                    }
                }
                // hier abfragen ob die hauptorder vorhanden ist
                foreach (string line in salesList)
                {
                    if (line != null)
                    {
                        if (line.Contains(orderID))
                        {
                            return buildPath;
                        }
                    }
                }
            }
            //PayPal
            string[] numbers2 = new string[3] { "1", "2", "3" };
            string pathPreset2 = "BackmarketPayPal";
            int arrayIndexerPDF2 = 0;
            foreach (string number in numbers)
            {
                string buildPath = pathPreset2 + numbers2[arrayIndexerPDF2] + ".txt";
                arrayIndexerPDF2++;
                string[] salesList = new string[1000];
                string[] allLines = File.ReadAllLines(buildPath);
                int indexGrossSalesList = findLine(allLines, searchValueHeadingGrossSalesList);
                //Alle Orders in Array auflisten | sozusagen ein Filter von allLines[]
                for (int i = indexGrossSalesList + 1; i < allLines.Count(); i++)
                {
                    if (allLines[i].Contains(searchValueForGrossSalesList) || allLines[i].Contains(searchValueForGrossSalesList2))
                    {
                        salesList[arrayIndexerSales] = allLines[i];
                        arrayIndexerSales++;
                    }
                    else
                    {
                        break;
                    }
                }
                // hier abfragen ob die hauptorder vorhanden ist
                foreach (string line in salesList)
                {
                    if (line != null)
                    {
                        if (line.Contains(orderID))
                        {
                            return buildPath;
                        }
                    }
                }
            }
            return "N/A";

        }
        public double getValueOfOneLine(int index, string[] array, int lengthOfTheFirstPos, string firstPos, string secondPos)
        {
            string newValue = "";
            string tempSave = array[index].ToString();
            var fullLength = tempSave.Length;
            var posFirst = tempSave.IndexOf(firstPos);
            var posSecond = tempSave.IndexOf(secondPos);
            string tempValue = tempSave.Substring(posFirst + lengthOfTheFirstPos, posSecond - posFirst - lengthOfTheFirstPos - 1);
            //Erweiterung für Tausenderbeträge mit Leerzeichen
            if (checkSpaceSign(tempValue) == true)
            {
                if (checkMinusSign(tempValue) == true)
                {
                    var posSpace = tempValue.IndexOf(" ");
                    var length = tempValue.Length;
                    string temp1 = tempValue.Substring(1, 1);
                    string temp2 = tempValue.Substring(posSpace + 1, length - posSpace - 1);
                    tempValue = temp1 + temp2;
                }
                else
                {
                    var posSpace = tempValue.IndexOf(" ");
                    var length = tempValue.Length;
                    string temp1 = tempValue.Substring(0, 1);
                    string temp2 = tempValue.Substring(posSpace + 1, length - posSpace - 1);
                    tempValue = temp1 + temp2;
                }
            }
            if (checkMinusSign(tempValue) == true)
            {
                var length2 = tempValue.Length;
                tempValue = tempValue.Substring(0, length2 - 1);
            }
            if (tempValue == "0,00")
            {
                tempValue = "0";
            }

            newValue = tempValue;
            double value = Convert.ToDouble(newValue);
            return value;
        }
        public bool checkMinusSign(string tempValue)
        {
            if (tempValue.Contains("-"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkSpaceSign(string tempValue)
        {
            if (tempValue.Contains(" "))
            {
                return true;
            }
            else
            {
                return false;
            }
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
