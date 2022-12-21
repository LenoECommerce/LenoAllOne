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
        public double CollectMarketPlaceFess(string salesVolume)
        {
            double marketPlaceFeesInTotal = 0;
            marketPlaceFeesInTotal += RoundOneDigit(CalculateSellerCommission(salesVolume));
            return marketPlaceFeesInTotal;
        }
        public double CalculateSellerCommission(string salesVolume)
        {
            if (salesVolume == "N/A")
            {
                return 0;
            }
            double sellerCommission = Convert.ToDouble(salesVolume)*0.1;
            return sellerCommission;
        }
        public double CollectPaymentFeesAndBackCare()
        {
            double sumup = 0;
            string[] numbers = new string[3] { "1", "2", "3" };
            string pathPreset = "BackmarketNormal";
            string searchValue1 = "Frais Paiement en x fois";
            string searchValue2 = "Frais Paiement Klarna";
            string searchValueBackCare1 = "MONTANT DES COMMANDES FACTUREES BACKCARE";
            string searchValueBackCare2 = "MONTANT DES COMMANDES FACTUREES CCBM";
            string searchValueBegin = "Montant des commandes expédiées par le marchand";
            int arrayIndexerPDF = 0;
            foreach (string number in numbers)
            {
                //payment fees part
                string buildPath = pathPreset + numbers[arrayIndexerPDF] + ".txt";
                string[] allLines = File.ReadAllLines(buildPath);
                arrayIndexerPDF++;
                int indexBegin = findLine(allLines,searchValueBegin);
                int index1 = FindLineWithSpecificBegin(allLines, searchValue1, indexBegin)-1;
                int index2 = FindLineWithSpecificBegin(allLines, searchValue2, indexBegin)-1;
                int indexBackCare1 = findLine(allLines, searchValueBackCare1)+3;
                int indexBackCare2 = findLine(allLines, searchValueBackCare2)+3;
                double internationalFees = 0;
                double klarnaFees = 0;
                if (index1 != -1)
                {
                    internationalFees = getValueOfOneLine(index1, allLines, 5, "fois", "€");
                }
                if (index2 != -1)
                {
                    klarnaFees = getValueOfOneLine(index2, allLines, 7, "Klarna", "€");
                }
                sumup += internationalFees + klarnaFees;
                //back care fees part
                if (indexBackCare1 != 3)
                {
                    double temp = getValueOfOneLine(indexBackCare1, allLines, 3, " 1 ", "€");
                    AllocateBackCareFee(number, temp);
                }
                if (indexBackCare2 != 3)
                {
                    double temp = getValueOfOneLine(indexBackCare2, allLines, 3, " 1 ", "€");
                }
            }
            return RemoveMinus(sumup);
        }
        public double CollectReturnAmount()
        {
            double returnAmount = 0;
            string[] numbers = new string[3] { "1", "2", "3" };
            string pathPreset = "BackmarketNormal";
            string pathPreset2 = "BackmarketPayPal";
            string searchValue = "MONTANT DES COMMANDES REMBOURSÉES";
            string searchValueTotal = "TOTAL";
            int arrayIndexerPDF = 0;
            foreach (string number in numbers)
            {
                string buildPath = pathPreset + numbers[arrayIndexerPDF] + ".txt";
                string[] allLines = File.ReadAllLines(buildPath);
                arrayIndexerPDF++;
                int indexReturnList = findLine(allLines, searchValue);
                //Alle Orders in Array auflisten | sozusagen ein Filter von allLines[]
                for (int i = indexReturnList + 1; i < allLines.Count(); i++)
                {
                    if (!allLines[i].Contains(searchValueTotal))
                    {
                        double temp = GetReturnValueOfOneLine(i,allLines);
                        returnAmount += temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            arrayIndexerPDF = 0;
            foreach (string number in numbers)
            {
                string buildPath = pathPreset2 + numbers[arrayIndexerPDF] + ".txt";
                string[] allLines = File.ReadAllLines(buildPath);
                arrayIndexerPDF++;
                int indexReturnList = findLine(allLines, searchValue);
                //Alle Orders in Array auflisten | sozusagen ein Filter von allLines[]
                for (int i = indexReturnList + 1; i < allLines.Count(); i++)
                {
                    if (!allLines[i].Contains(searchValueTotal))
                    {
                        double temp = GetReturnValueOfOneLine(i, allLines);
                        returnAmount += temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return returnAmount;
        }
        public void AllocateBackCareFee (string numberPDF, double value)
        {
            if (numberPDF == "1")
            {
                OrderRelationPDF.backCareFees1 = value;
            }
            else if (numberPDF == "2")
            {
                OrderRelationPDF.backCareFees2 = value;
            }
            else if (numberPDF == "3")
            {
                OrderRelationPDF.backCareFees3 = value;
            }
        }
        public double RoundOneDigit (double adaptValue)
        {
            string tempValue = adaptValue.ToString();
            if (tempValue.Contains(","))
            {
                var pos = tempValue.IndexOf(",");
                tempValue = tempValue.Substring(0, pos+2);
                adaptValue = Convert.ToDouble(tempValue);
            }
            return adaptValue;
        }
        public double RemoveMinus (double fixValue)
        {
            double newValue = -fixValue;
            return newValue;
        }
        public string GetSalesVolume (string orderID, string pdf)
        {
            if (pdf == "N/A")
            {
                return "N/A";
            }
            string[] salesList = new string[1000];
            string[] allLines = File.ReadAllLines(pdf);
            string searchValueForGrossSalesList = " 1 ";
            string searchValueForGrossSalesList2 = " 2 ";
            string searchValueForGrossSalesList3 = "TOTAL";
            string searchValueHeadingGrossSalesList = "MONTANT DES COMMANDES EXPEDIÉES DU";
            int indexGrossSalesList = findLine(allLines, searchValueHeadingGrossSalesList);
            int arrayIndexerSales = 0;
            //Alle Orders in Array auflisten | sozusagen ein Filter von allLines[]
            for (int i = indexGrossSalesList + 1; i < allLines.Count(); i++)
            {
                if (allLines[i].Contains(searchValueForGrossSalesList) || allLines[i].Contains(searchValueForGrossSalesList2) || !allLines[i].Contains(searchValueForGrossSalesList3))
                {
                    salesList[arrayIndexerSales] = allLines[i];
                    arrayIndexerSales++;
                }
                else
                {
                    break;
                }
            }
            //Umsatz holen
            int lineCounter = 0;
            foreach(string line in salesList)
            {
                if (line != null)
                {
                    if (line.Contains(orderID))
                    {
                        string salesVolume = getValueOfOneLine(lineCounter, salesList, 3, searchValueForGrossSalesList, "€").ToString();
                        return salesVolume;
                    }
                }
                lineCounter++;
            }
            return "N/A";
        }
        public double CountNotPayPalOrders()
        {
            int count = 0;
            string[] numbers = new string[3] { "1", "2", "3" };
            string pathPreset = "BackmarketNormal";
            string searchValueForGrossSalesList = " 1 ";
            string searchValueForGrossSalesList2 = " 2 ";
            string searchValueForGrossSalesList3 = "TOTAL";
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
                    if (allLines[i].Contains(searchValueForGrossSalesList) || allLines[i].Contains(searchValueForGrossSalesList2) && !allLines[i].Contains(searchValueForGrossSalesList3))
                    {
                        salesList[arrayIndexerSales] = allLines[i];
                        arrayIndexerSales++;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return count;
        }
        public bool CheckPDFTypeIfNormal (string pdfPath)
        {
            if (pdfPath.ToLower().Contains("paypal"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string FindPDFViaOrderNumber (string orderID)
        {
            if (orderID.Contains("€"))
            {
                return "";
            }
            string[] numbers = new string[3] { "1", "2", "3" };
            string pathPreset = "BackmarketNormal";
            string searchValueForGrossSalesList = " 1 ";
            string searchValueForGrossSalesList2 = " 2 ";
            string searchValueForGrossSalesList3 = "TOTAL";
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
                    if (allLines[i].Contains(searchValueForGrossSalesList) || allLines[i].Contains(searchValueForGrossSalesList2) || !allLines[i].Contains(searchValueForGrossSalesList3))
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
                            AssignFinallyBackCareValue(number);
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
                    if (allLines[i].Contains(searchValueForGrossSalesList) || allLines[i].Contains(searchValueForGrossSalesList2) || !allLines[i].Contains(searchValueForGrossSalesList3))
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
                            AssignFinallyBackCareValue(number);
                            return buildPath;
                        }
                    }
                }
            }
            return "N/A";

        }
        public void AssignFinallyBackCareValue(string numberPDF)
        {
            if (numberPDF == "1")
            {
                OrderRelationPDF.backCareFee = OrderRelationPDF.backCareFees1;
            }
            else if (numberPDF == "2")
            {
                OrderRelationPDF.backCareFee = OrderRelationPDF.backCareFees2;
            }
            else if (numberPDF == "3")
            {
                OrderRelationPDF.backCareFee = OrderRelationPDF.backCareFees3;
            }
        }
        public double GetReturnValueOfOneLine(int index, string[] array)
        {
            double value = 0;
            string temp = array[index].ToString();
            string space = " ";
            string euroSign = "€";
            int posEuroSign = temp.IndexOf(euroSign);
            int fullLength = temp.Length;
            string newTemp = temp.Substring(posEuroSign-10,fullLength-posEuroSign+10);
            int lengthNewTemp = newTemp.Length;
            int posSpace = newTemp.IndexOf(space);
            newTemp = newTemp.Substring(posSpace,lengthNewTemp-posSpace-1);
            value = Convert.ToDouble(newTemp);
            return value;
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
