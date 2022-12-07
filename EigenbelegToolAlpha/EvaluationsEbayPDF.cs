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
    public class EvaluationsEbayPDF
    {
        EvaluationsFirstPage EvaluationsFirstPage = new EvaluationsFirstPage();
        public void Main()
        {
            BuildTextFiles();
        }
        public string GetSalesVolume(string orderId)
        {
            string salesReturnValue = "";
            string reportTxtPath = "ebayreport.txt";
            string[] allLines = File.ReadAllLines(reportTxtPath);
            string searchValueMain = "Bestellungen";
            int indexGrossSalesList = FindLineWithSpecificBegin(allLines, searchValueMain, 30);

            for (int i = indexGrossSalesList + 1; i < allLines.Count(); i++)
            {
                if (allLines[i].Contains(orderId))
                {
                    salesReturnValue = getValueOfOneLine(i, allLines, 1, "€").ToString();
                    OrderRelationPDF.beginLineEbay = i;
                    return salesReturnValue;
                }
            }
            return "N/A";
        }
        public double GetSellerCommission(string orderId)
        {
            string reportTxtPath = "ebayreport.txt";
            string[] allLines = File.ReadAllLines(reportTxtPath);
            string searchValueFees = "Gebühren";
            int begin = OrderRelationPDF.beginLineEbay;
            for (int i = begin; i < allLines.Count(); i++)
            {
                if (allLines[i].Contains(searchValueFees))
                {
                    double test = getValueOfOneLine(i, allLines, 1, "€");
                    return test;
                }
            }
            return 0;
        }
        public double getValueOfOneLine(int index, string[] array, int lengthOfTheFirstPos, string firstPos)
        {
            string newValue = "";
            string tempSave = array[index].ToString();
            var fullLength = tempSave.Length;
            var posFirst = tempSave.IndexOf(firstPos);
            string tempValue = tempSave.Substring(posFirst+lengthOfTheFirstPos,fullLength-lengthOfTheFirstPos-posFirst);
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
        public int FindLineWithSpecificBegin(string[] array, string searchValue, int beginIndex)
        {
            int backValue = 0;
            for (int i = beginIndex; i < array.Count(); i++)
            {
                if (array[i].Contains(searchValue))
                {
                    backValue = i + 1;
                    break;
                }
            }
            return backValue;
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

        private void BuildTextFiles()
        {

            EvaluationsFirstPage eval = new EvaluationsFirstPage();
            string buildPath = "ebayreport.txt";
            string path = eval.lineSearchAndGetValue("Ebay Report:", 12);
            FileStream stream = File.Create(buildPath);
            stream.Close();
            File.WriteAllText(buildPath, ExtractTextFromPdf(path));
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
