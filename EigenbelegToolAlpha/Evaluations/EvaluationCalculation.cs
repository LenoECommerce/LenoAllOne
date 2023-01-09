using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Reflection;
using System.Security.Permissions;

namespace EigenbelegToolAlpha
{
    public partial class EvaluationCalculation : Form
    {
        public static double backMarketGrossSalesVolumeMarginalVat = 0;
        public static double backMarketGrossSalesVolumeNormalVat = 0;
        public static double backMarketReturnsMarginalVat = 0;
        public static double backMarketReturnsNormalVat = 0;
        public static double backMarketDefferedPayout = 0;
        public static double backMarketOutcome;
        public static double backMarketGrossSalesTotal;
        public static double backMarketReturnsTotal;

        public static double backMarketPayPalGrossSalesVolumeTotal = 0;
        public static double backMarketPayPalGrossSalesVolumeMarginalVat = 0;
        public static double backMarketPayPalGrossSalesVolumeNormalVat = 0;
        public static double backMarketPayPalReturnsTotal = 0;
        public static double backMarketPayPalReturnsNormalVat = 0;
        public static double backMarketPayPalReturnsMarginalVat = 0;
        public static double backMarketPayPalOutcome = 0;
        public static double backMarketPayPalFees = 0;

        public static double inputOfGoodsREG = 0;
        public static double inputOfGoodsDIFF = 0;
        public static double inputOfExternalCosts = 0;

        public static double taxesREG = 0;
        public static double taxesDIFF = 0;
        public static double taxesGetBack = 0;
        public static double taxesHaveToPay = 0;

        public static double donorDevicesAmount = 0;
        public static int donorDevicesCounter = 0;

        public static int kpiDevicesPerMonthSold = 0;
        public static int kpiDevicesPerMonth = 0;
        public static int kpiSourceCounterEbay = 0;
        public static int kpiSourceCounterEbayKleinanzeigen = 0;
        public static int kpiSourceCounterBackMarket = 0;
        public static int checkValueAddedDevicesToMatching = 0;
        public static int checkValueDevicesCountedInput = 0;

        public string[] dataSetOrder = new string[10];
        //Data Set variables
        public string orderID = "";
        public string internalNumber = "";
        public string amount = "";
        public string externalCosts = "";
        public string externalCostsDIFF = "";
        public string taxesType = "";
        public string taxesAmount = "";
        public string marketplaceFees = "";
        public string revenue = "";
        public string margin = "";

        string idS = "";

        Protokollierung prot = new Protokollierung();
        Reparaturen rep = new Reparaturen();
        Matching match = new Matching();
        EvaluationsFirstPage eval = new EvaluationsFirstPage();
        OrderRelationPDF orderRelationPDF = new OrderRelationPDF();
        public string month = "";
        public EvaluationCalculation()
        {
            InitializeComponent();
            month = eval.lineSearchAndGetValue("Monat:", 6);
        }
        
        public void GetFullDataSetOrder ()
        {
            foreach (DataGridViewRow row in match.matchingDGV.Rows)
            {
                // check if month is relevant
                string monthCheck = row.Cells[9].Value.ToString();
                string orderCheck = row.Cells[1].Value.ToString();
                if (monthCheck == month)
                {
                    var id = CRUDQueries.ExecuteQueryWithResult("Matching","Id","Bestellnummer", orderCheck);
                    FetchDataFromMatching(id);
                    orderRelationPDF.Main(orderID,internalNumber, amount, externalCosts, externalCostsDIFF,taxesType);
                }
            }
        }
        private void FetchDataFromMatching(int id)
        {
            try
            {
                string table = "Matching";
                string searchTerm = "Id";
                idS = id.ToString();
                orderID = CRUDQueries.ExecuteQueryWithResultString(table, "Bestellnummer", searchTerm, idS);
                internalNumber = CRUDQueries.ExecuteQueryWithResultString(table, "Intern", searchTerm, idS);
                amount = AdaptNumber(CRUDQueries.ExecuteQueryWithResultString(table, "Kaufbetrag", searchTerm, idS));
                externalCosts = AdaptNumber(CRUDQueries.ExecuteQueryWithResultString(table, "Externe Kosten", searchTerm, idS));
                externalCostsDIFF = AdaptNumber(CRUDQueries.ExecuteQueryWithResultString(table, "ExterneKostenDIFF", searchTerm, idS));
                taxesType = CRUDQueries.ExecuteQueryWithResultString(table, "Besteuerung", searchTerm, idS);
                if (taxesType.Contains("Diff"))
                {
                    taxesType = "DIFF";
                }
                else if (taxesType.Contains("Reg"))
                {
                    taxesType = "REG";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Es gibt ein Problem mit FetchDataFromMatching\r\nMatching Id: " +idS + "\r\nFehler: "+e.Message);
            }
        }

   

        private void MatchingAlgorithm ()
        {
            string searchIntern = "";
            string searchOrderID = "";
            string newIMEI = "";
            string newMonth = "";
            string marketplace = "";
            string taxes = "";
            string related = "";
            double rowsInTotal = prot.protokollierungDGV.RowCount;
            double approvedRows = 0;
            int addedRows = 0;
            EvaluationsFirstPage eval = new EvaluationsFirstPage();
            string month = eval.lineSearchAndGetValue("Monat:", 6);
            string[] alreadyExisting = new string[1000];
            int alreadyExistsCounter = 0;
            int alreadyExistsCounterButMatchingMonth = 0;

            foreach (DataGridViewRow row in prot.protokollierungDGV.Rows)
            {
                approvedRows++;
                searchOrderID = row.Cells[1].Value.ToString();
                newMonth = row.Cells[5].Value.ToString();
                searchIntern = row.Cells[3].Value.ToString();
                var resultExistsInMatching = CRUDQueries.ExecuteQueryWithResult("Matching", "Id", "Bestellnummer", searchOrderID);
                var resultExistsInternInMatching = CRUDQueries.ExecuteQueryWithResult("Matching", "Id", "Intern", searchIntern);
                //Überprüfen ob der Datensatz schon in Matching vorhanden ist + Ob Monat relevant ist + ob Intern schon vorhanden ist!
                if (resultExistsInMatching == 0 && newMonth == month && resultExistsInternInMatching == 0)
                {
                    //Data Pull aus Protokollierung
                    newIMEI = row.Cells[2].Value.ToString();
                    marketplace = row.Cells[4].Value.ToString();
                    related = "Ja";
                    //Data Pull aus Reparaturen
                    var id = CRUDQueries.ExecuteQueryWithResult("Reparaturen", "Id", "Intern", searchIntern);
                    string tempAmount = AdaptNumber(CRUDQueries.ExecuteQueryWithResultString("Reparaturen", "Kaufbetrag", "Id", id.ToString()));
                    string tempExternalCosts = AdaptNumber(CRUDQueries.ExecuteQueryWithResultString("Reparaturen", "ExterneKosten", "Id", id.ToString()));
                    string tempExternalCostsDiff = AdaptNumber(CRUDQueries.ExecuteQueryWithResultString("Reparaturen", "ExterneKostenDIFF", "Id", id.ToString()));
                    taxes = CRUDQueries.ExecuteQueryWithResultString("Reparaturen", "Besteuerung", "Id", id.ToString());
                    string query = String.Format("INSERT INTO `Matching`(`Bestellnummer`,`IMEI`,`Intern`,`Kaufbetrag`,`Externe Kosten`,`ExterneKostenDIFF`,`Marktplatz`,`Besteuerung`,`Monat`,`Zugeordnet?`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')"
                                    , searchOrderID, newIMEI, searchIntern, tempAmount, tempExternalCosts,tempExternalCostsDiff, marketplace, taxes, newMonth, related);
                    addedRows++;
                    CRUDQueries.ExecuteQuery(query);
                }
                else if (newMonth != month)
                {
                    alreadyExisting[alreadyExistsCounter] = searchOrderID;
                    alreadyExistsCounter++;
                }
                else if (newMonth == month)
                {
                    alreadyExistsCounterButMatchingMonth++;
                }
            }
            checkValueAddedDevicesToMatching = addedRows;
            MessageBox.Show("Der Matching Algorithmus wurde mit folgendem Ergebnis ausgeführt: \r\n- Einträge insgesamt: "+rowsInTotal+"\r\n- Durchlaufen: "+approvedRows+ "\r\n- Passende Einträge: " + addedRows+ "\r\n- Bereits existierende Aufträge: " + alreadyExistsCounter + "\r\n- Bereits existierende Aufträge (Monat matcht): "+alreadyExistsCounterButMatchingMonth);
        }
        private string AdaptNumber(string checkValue)
        {
            string amount = checkValue;
            if (checkValue == "")
            {
                amount = "0";
            }
            if (checkValue.Contains("€"))
            {
                var length = checkValue.Length;
                amount = checkValue.Substring(0, length - 1);
            }
            return amount;
        }

        //old algorithms;
        private void DonorDevicesAlgorithm()
        {
            foreach (DataGridViewRow row in rep.reparaturenDGV.Rows)
            {
                string testingMonth = row.Cells[23].Value.ToString();
                if (testingMonth == month)
                {
                    double tempAmountDevice = Convert.ToDouble(AdaptNumber(row.Cells[4].Value.ToString()));
                    donorDevicesAmount += tempAmountDevice;
                    donorDevicesCounter++;
                }
            }
            MessageBox.Show("Der Spender Algorithmus wurde mit folgendem Ergebnis ausgeführt: \r\n- Betrag insgesamt: " + donorDevicesAmount + "\r\n- Geräte insgesamt: " + donorDevicesCounter);
        }



        public double getValueOfOneLine(int index, string[] array,int lengthOfTheFirstPos, string firstPos, string secondPos)
            {
            string newValue = "";
            string tempSave = array[index].ToString();
            var fullLength = tempSave.Length;
            var posFirst = tempSave.IndexOf(firstPos);
            var posSecond = tempSave.IndexOf(secondPos);
            string tempValue = tempSave.Substring(posFirst + lengthOfTheFirstPos, posSecond - posFirst - lengthOfTheFirstPos-1);
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
            if (checkMinusSign(tempValue)==true)
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
        public string getValueOfOneLineDefferedPayOut(int index, string[] array, int lengthOfTheFirstPos, string firstPos, string secondPos)
        {
            string newValue = "";
            string tempSave = array[index].ToString();
            var fullLength = tempSave.Length;
            var posFirst = tempSave.IndexOf(firstPos);
            var posSecond = tempSave.IndexOf(secondPos);
            string tempValue = tempSave.Substring(posFirst + lengthOfTheFirstPos, posSecond - posFirst - lengthOfTheFirstPos - 1);
            return tempValue;
        }
        public bool checkZeroAmount(string tempValue)
        {
            if (tempValue == "0,00")
            {
                return true;
            }
            else
            {
                return false;
            }
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
        public bool checkReg (string[] array,int index)
        {
            string tempSave = array[index].ToString();
            if (tempSave.Contains("REG"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int findLine (string[] array, string searchValue)
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

        public string EuroCheck (string checkValue)
        {
            if (checkValue.Contains("€"))
            {
                var length = checkValue.Length;
                var newValue = checkValue.Substring(0,length-1);
                return newValue;
            }
            else
            {
                return checkValue;
            }
        }
        public bool CheckTaxesForInputs (string checkValue)
        {
            if (checkValue == "Differenzbesteuerung")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void DevicesPerMonthAlgorithm()
        {
            Reparaturen rep = new Reparaturen();
            EvaluationsFirstPage eval = new EvaluationsFirstPage();
            Eigenbelege eigenbelege = new Eigenbelege();
            Matching matching = new Matching();
            string month = eval.lineSearchAndGetValue("Monat:", 6);
            foreach (DataGridViewRow row in rep.reparaturenDGV.Rows)
            {
                string ebReference = row.Cells[22].Value.ToString();
                string tempValue = row.Cells[2].Value.ToString().Substring(3, 2);
                string compareMonth = monthOverview[tempValue];
                var id = CRUDQueries.ExecuteQueryWithResult("Eigenbelege", "Id", "Eigenbelegnummer", ebReference);

                if (month == compareMonth)
                {
                    kpiDevicesPerMonth++;
                    //Get Source via Eigenbelege Sheet
                    string source = CRUDQueries.ExecuteQueryWithResultString("Eigenbelege", "Plattform", "Id", id.ToString());
                    if (source == "Ebay Kleinanzeigen")
                    {
                        kpiSourceCounterEbayKleinanzeigen++;
                    }
                    else if (source == "Ebay")
                    {
                        kpiSourceCounterEbay++;
                    }
                    else if (source == "BackMarket")
                    {
                        kpiSourceCounterBackMarket++;
                    }
                }
            }
            //Verkaufte Geräte pro Monat
            foreach (DataGridViewRow row in matching.matchingDGV.Rows)
            {
                if (row.Cells[9].Value.ToString() == month)
                {
                    kpiDevicesPerMonthSold++;   
                }
            }
            MessageBox.Show("Der weitere KPI Algorithmus wurde erfolgreich ausgeführt.");
        }
        private void btn_TaxCalculation_Click(object sender, EventArgs e)
        {
            
        }

        public string RoundNumber(string tempNumber)
        {
            var length = tempNumber.Length;
            var indexComma = tempNumber.IndexOf(",");
            string preComma = tempNumber.Substring(0, indexComma);
            string afterComma = tempNumber.Substring(indexComma+1,2);
            string newNumber = preComma + "," + afterComma;
            return newNumber;
        }
        Dictionary<string, string> monthOverview = new Dictionary<string, string>
        {
            { "01", "Januar" },
            { "02", "Februar" },
            { "03", "März" },
            { "04", "April" },
            { "05", "Mai" },
            { "06", "Juni" },
            { "07", "Juli" },
            { "08", "August" },
            { "09", "September" },
            { "10", "Oktober" },
            { "11", "November" },
            { "12", "Dezember" },
        };
        private void EvaluationCalculation_Load(object sender, EventArgs e)
        {

        }

        
        public void UploadPDF()
        {
            string year = "2022";
            var returnValue = CRUDQueries.ExecuteQueryWithResult("Evaluations", "Id", "Monat", month);
            GoogleDrive drive = new GoogleDrive(MonthlyReportPDF.monthlyReportFinishedPath, "pdf");
            if (returnValue == 0)
            {
                string query = string.Format("INSERT INTO `Evaluations` (`Monat`,`Jahr`,`Link`) VALUES ('{0}','{1}','{2}')"
                                , month, year, GoogleDrive.currentLink);
                CRUDQueries.ExecuteQuery(query);
                MessageBox.Show("Der Monat " + month + " wurde erstmalig angelegt.");
            }
            else
            {
                string query = "UPDATE `Evaluations` SET `Link` = '" + GoogleDrive.currentLink + "' WHERE `Id` = " + returnValue;
                CRUDQueries.ExecuteQuery(query);
                MessageBox.Show("Der Monat " + month + " wurde überschrieben.");
            }
            this.Close();
        }
        private void btn_ExecuteAllAlgorithms_Click(object sender, EventArgs e)
        {
            try
            {
                MatchingAlgorithm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Der Matching Algorithmus hat ein Problem: " + ex.Message);
            }
            try
            {
                DonorDevicesAlgorithm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Der Spendergeräte Algorithmus hat ein Problem: " + ex.Message);
            }
            try
            {
                DevicesPerMonthAlgorithm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Der Geräte pro Monat Algorithmus hat ein Problem: " + ex.Message);
            }

            GetFullDataSetOrder();

            try
            {
                MonthlyReportPDF.CreatePDFFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erstellung der Monthly Report PDF Datei hat ein Problem: " + ex.Message);
            }
            try
            {
                UploadPDF();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uploading Methode hat ein Problem: " + ex.Message);
            }
        }
    }
}