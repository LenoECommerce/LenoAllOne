using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;


namespace EigenbelegToolAlpha
{
    public class EigenbelegePayPalImport
    {
        public int counterExecutedQueries = 0;
        int xlrow = 0;
        public int beginEigenbelegNumber = CRUDQueries.ExecuteQueryWithResult("Config", "Nummer", "Typ", "Eigenbelegnummer");
        public string tempSeller = "";
        Microsoft.Office.Interop.Excel.Application xlApp;
        Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
        Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
        Microsoft.Office.Interop.Excel.Range xlRange;
        public void MainAlgorithm (string chosenFile)
        { 
            try
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(chosenFile);
                xlWorksheet = xlWorkbook.Worksheets["Worksheet"];
                xlRange = xlWorksheet.UsedRange;

                for (xlrow = 2; xlrow <= xlRange.Rows.Count; xlrow++)
                {
                    tempSeller = xlRange.Cells[xlrow, 4].Text;
                    var doesSellerExist = CRUDQueries.ExecuteQueryWithResult("Eigenbelege", "Id", "Verkaeufername", tempSeller);
                    string transactionText = xlRange.Cells[xlrow, 17].Text;
                    string tempSenderMail = xlRange.Cells[xlrow, 11].Text;
                    if (transactionText.Contains("Ebay") && tempSenderMail == "dange.businessebay@gmail.com" && !tempSeller.Contains("@"))
                    {
                        if (doesSellerExist == 0)
                        {
                            CreateNewEntry();
                        }
                        else
                        {
                            double tempValue = Convert.ToDouble(xlRange.Cells[xlrow, 8].Text) * (-1);
                            string referToAmount = tempValue.ToString();
                            string compareAmount = CheckEuroSign(CRUDQueries.ExecuteQueryWithResultString("Eigenbelege", "Kaufbetrag", "Id", doesSellerExist.ToString()));
                            if (referToAmount != compareAmount)
                            {
                                CreateNewEntry();
                            }
                        }
                    }
                }
                xlWorkbook.Close();
                xlApp.Quit();
                MessageBox.Show("Es wurden erfolgreich "+counterExecutedQueries+" Eigenbeleg Einträge hinzugefügt.");
                CRUDQueries.ExecuteQuery("UPDATE `Config` SET `Nummer` = "+beginEigenbelegNumber+" WHERE `Typ` = 'Eigenbelegnummer'");
            }
            catch (Exception e)
            {
                MessageBox.Show("Es gab einen Fehler in Reihe: " + xlrow +e.Message);
            }
        }
        public void CreateNewEntry()
        {
            string tempDate = xlRange.Cells[xlrow, 1].Text;
            double tempAmountAdpation = Convert.ToDouble(xlRange.Cells[xlrow, 8].Text) * (-1);
            string tempAmount = tempAmountAdpation.ToString() + "€";
            string tempFullTransactionText = xlRange.Cells[xlrow, 17].Text;
            string tempMail = xlRange.Cells[xlrow, 12].Text;
            string tempPlatform = CheckPlatform(tempFullTransactionText);
            string[] positions = GivePositionsFromTransactionText(tempFullTransactionText);
            string tempReference = tempFullTransactionText.Substring(0, Convert.ToInt32(positions[0]) - 1);
            string tempDevice = tempFullTransactionText.Substring(Convert.ToInt32(positions[3]) + 2, Convert.ToInt32(positions[1]) - Convert.ToInt32(positions[3]) - 3);
            string tempStorage = tempFullTransactionText.Substring(Convert.ToInt32(positions[1]) + 7, Convert.ToInt32(positions[2]) - Convert.ToInt32(positions[1]) - 8);
            beginEigenbelegNumber++;
            counterExecutedQueries++;
            string query = string.Format("INSERT INTO `Eigenbelege` (`Eigenbelegnummer`, `Verkaeufername`,`Referenz`,`Modell`,`Kaufdatum`,`Kaufbetrag`,`E-Mail`,`Plattform`,`Zahlungsmethode`,`Adresse`,`Erstellt?`,`Angekommen?`,`Transaktionstext`,`Speicher`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')"
            , beginEigenbelegNumber, tempSeller, tempReference, tempDevice, tempDate, tempAmount, tempMail, tempPlatform, "PayPal", "", "Nein", "Nein", tempFullTransactionText, tempStorage);
            CRUDQueries.ExecuteQuery(query);
        }
        public string CheckEuroSign(string checkValue)
        {
            if (checkValue.Contains("€"))
            {
                var length = checkValue.Length;
                checkValue = checkValue.Substring(0,length-1);
            }
            return checkValue;
        }
        public string CheckPlatform (string checkValue)
        {
            string platform = "";
            if (checkValue.Contains("Ebay Kleinanzeigen"))
            {
                platform = "Ebay Kleinanzeigen";
            }
            else if (checkValue.Contains("Ebay"))
            {
                platform = "Ebay";
            }
            else if (checkValue.Contains("BackMarket"))
            {
                platform = "BackMarket";
            }
            else if (checkValue.Contains("Ankaufanzeige"))
            {
                platform = "Ebay Kleinanzeigen Ankaufanzeige";
            }
            return platform;
        }

        public string [] GivePositionsFromTransactionText(string modifyValue)
        {
            var posTrenn = modifyValue.IndexOf("trenn");
            var posTrenn2 = modifyValue.IndexOf("trenn2");
            var posTrenn3 = modifyValue.IndexOf("trenn3");
            var posDoublePoint = modifyValue.IndexOf(":");

            string[] positions = new string[4] { posTrenn.ToString(), posTrenn2.ToString(), posTrenn3.ToString(), posDoublePoint.ToString() };
            return positions;
        }

    }
}
