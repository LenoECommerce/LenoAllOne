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
        public EvaluationCalculation()
        {
            InitializeComponent();
            //string tempNumber = EvaluationThirdForm.RunningCostsSum.ToString();
            //lbl_RunningCostsSum.Text = RoundNumber(tempNumber);
            //string tempNumber2 = EvaluationThirdForm.RunningCostsTaxGetBack.ToString();
            //lbl_RunningCostsTaxGetBack.Text = RoundNumber(tempNumber2);
            //string tempNumber3 = EvaluationThirdForm.RunningCostsFinal.ToString();
            //lbl_RunningCostsAtAll.Text = RoundNumber(tempNumber3);
        }
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
        public static double backMarketPayPalReturnsTotal;
        public static double backMarketPayPalReturnsNormalVat = 0;
        public static double backMarketPayPalReturnsMarginalVat = 0;
        public static double backMarketPayPalOutcome;
        public static double backMarketPayPalFees;

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
        private void DonorDevicesAlgorithm()
        {
            Reparaturen rep = new Reparaturen();
            EvaluationsFirstPage eval = new EvaluationsFirstPage();
            string month = eval.lineSearchAndGetValue("Monat:", 6);
            foreach (DataGridViewRow row in rep.reparaturenDGV.Rows)
            {
                string testingMonth = row.Cells[22].Value.ToString();
                if (testingMonth == month)
                {
                    double tempAmountDevice = Convert.ToDouble(row.Cells[4].Value);
                    donorDevicesAmount += tempAmountDevice;
                    donorDevicesCounter++;
                }
            }
            MessageBox.Show("Der Spender Algorithmus wurde mit folgendem Ergebnis ausgeführt: \r\n- Betrag insgesamt: " + donorDevicesAmount + "\r\n- Geräte insgesamt: " + donorDevicesCounter);
        }
        private void CalculateInputAlgorithm()
        {
            progressBar1.Value = 0;
            Matching match = new Matching();
            EvaluationsFirstPage eval = new EvaluationsFirstPage();
            string month = eval.lineSearchAndGetValue("Monat:", 6);
            int arrayIndex = 0;
            double rowsInTotal = match.matchingDGV.RowCount;
            double approvedRows = 0;
            foreach (DataGridViewRow row in match.matchingDGV.Rows)
            {
                approvedRows++;
                double progress = approvedRows / rowsInTotal * 100;
                progressBar1.Value = Convert.ToInt32(progress);
                string monthOfMatching = row.Cells[8].Value.ToString();
                string tempIntern = row.Cells[3].Value.ToString();
                if (monthOfMatching == month)
                {
                        arrayIndex++;
                        string checkValue = row.Cells[5].Value.ToString();
                        if (checkValue == "")
                        {
                            inputOfExternalCosts += 0;
                        }
                        else
                        {
                            inputOfExternalCosts += Convert.ToDouble(EuroCheck(checkValue));
                        }
                        string checkTaxValue = Convert.ToString(row.Cells[7].Value);
                        if (CheckTaxesForInputs(checkTaxValue) == true)
                        {
                            string checkValue2 = row.Cells[4].Value.ToString();
                            inputOfGoodsDIFF += Convert.ToDouble(EuroCheck(checkValue2));
                        }
                        else
                        {
                            string checkValue3 = row.Cells[4].Value.ToString();
                            inputOfGoodsREG += Convert.ToDouble(EuroCheck(checkValue3));
                        }
                }
            }
            lbl_inputOfExternalCosts.Text = inputOfExternalCosts.ToString();
            lbl_inputOfGoodsDIFF.Text = inputOfGoodsDIFF.ToString();
            lbl_inputOfGoodsREG.Text = inputOfGoodsREG.ToString();
            checkValueDevicesCountedInput = arrayIndex;
            MessageBox.Show("Der Einsatz Algorithmus wurde mit folgendem Ergebnis ausgeführt: \r\n- Einträge insgesamt: " + rowsInTotal + "\r\n- Durchlaufen: " + approvedRows + "\r\n- Passende Einträge: " + arrayIndex);
        }
        private void MatchingAlgorithm ()
        {
            Protokollierung prot = new Protokollierung();
            Reparaturen rep = new Reparaturen();
            Matching match = new Matching();
            string searchIntern = "";
            string importNewIMEI = "";
            string searchOrderID = "";
            string newIMEI = "";
            double newAmount = 0;
            double newExternalCosts = 0;
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

            //Abfrage wenn IMEI nicht vorhanden sein sollte!
            foreach (DataGridViewRow row in rep.reparaturenDGV.Rows)
            {
                if (row.Cells[5].Value.Equals(""))
                {
                    foreach (DataGridViewRow row2 in prot.protokollierungDGV.Rows)
                    {
                        searchIntern = row.Cells[1].Value.ToString();
                        if (row2.Cells[3].Value.Equals(searchIntern))
                        {
                            importNewIMEI = row2.Cells[2].Value.ToString();
                            string query = "UPDATE `Reparaturen` SET `IMEI` = '" + importNewIMEI + "' WHERE `Intern` = '" + searchIntern + "'";
                            CRUDQueries.ExecuteQuery(query);
                        }
                    }
                }
            }
            //Der eigentliche Matchingprozess
            foreach (DataGridViewRow row3 in prot.protokollierungDGV.Rows)
            {
                approvedRows++;
                double progress = approvedRows / rowsInTotal*100;
                progressBar1.Value = Convert.ToInt32(progress);
                searchOrderID = row3.Cells[1].Value.ToString();
                newMonth = row3.Cells[5].Value.ToString();
                searchIntern = row3.Cells[3].Value.ToString();
                var resultExistsInMatching = CRUDQueries.ExecuteQueryWithResult("Matching", "Id", "Bestellnummer", searchOrderID);
                var resultExistsInternInMatching = CRUDQueries.ExecuteQueryWithResult("Matching", "Id", "Intern", searchIntern);
                //Überprüfen ob der Datensatz schon in Matching vorhanden ist + Ob Monat relevant ist + ob Intern schon vorhanden ist!
                if (resultExistsInMatching == 0 && newMonth == month && resultExistsInternInMatching == 0)
                {
                    //Data Pull aus Protokollierung
                    searchOrderID = row3.Cells[1].Value.ToString();
                    newIMEI = row3.Cells[2].Value.ToString();
                    marketplace = row3.Cells[4].Value.ToString();
                    related = "Ja";
                    //Data Pull aus Reparaturen
                    var id = CRUDQueries.ExecuteQueryWithResult("Reparaturen", "Id", "Intern", searchIntern);
                    //Unterscheidung ob € Zeichen vorhanden ist.
                    string tempAmount = AdaptNumber(CRUDQueries.ExecuteQueryWithResultString("Reparaturen", "Kaufbetrag", "Id", id.ToString()));
                    string tempExternalCosts = AdaptNumber(CRUDQueries.ExecuteQueryWithResultString("Reparaturen", "ExterneKosten", "Id", id.ToString()));
                    string tempExternalCostsDiff = AdaptNumber(CRUDQueries.ExecuteQueryWithResultString("Reparaturen", "ExterneKostenDIFF", "Id", id.ToString()));
                    taxes = CRUDQueries.ExecuteQueryWithResultString("Reparaturen", "Besteuerung", "Id", id.ToString());
                    string query2 = String.Format("INSERT INTO `Matching`(`Bestellnummer`,`IMEI`,`Intern`,`Kaufbetrag`,`Externe Kosten``ExterneKostenDIFF`,`Marktplatz`,`Besteuerung`,`Monat`,`Zugeordnet?`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')"
                                    , searchOrderID, newIMEI, searchIntern, tempAmount, tempExternalCosts,tempExternalCostsDiff, marketplace, taxes, newMonth, related);
                    addedRows++;
                    CRUDQueries.ExecuteQuery(query2);
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
            string amount = "";
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
        private void BackMarketInvoicesChecking ()
        {
            BackMarketNormalInvoicesAlgorithm();
            BackMarketPayPalInvoicesAlgorithm();
            backMarketGrossSalesVolumeNormalVat = backMarketGrossSalesVolumeNormalVat + backMarketPayPalReturnsNormalVat;
            backMarketGrossSalesVolumeMarginalVat = backMarketGrossSalesVolumeMarginalVat + backMarketReturnsMarginalVat;
            backMarketPayPalGrossSalesVolumeMarginalVat = backMarketPayPalGrossSalesVolumeMarginalVat + backMarketPayPalReturnsMarginalVat;
            backMarketPayPalGrossSalesVolumeNormalVat = backMarketPayPalGrossSalesVolumeNormalVat + backMarketPayPalReturnsNormalVat;
            backMarketGrossSalesTotal = backMarketGrossSalesTotal + backMarketReturnsTotal;
        }

        public void BackMarketPayPalInvoicesAlgorithm()
        {
            EvaluationsFirstPage eval = new EvaluationsFirstPage();
            string[] numbers = new string[3] { "1", "2", "3" };
            string pathPreset = "BackMarket PayPal ";
            string buildPath = "";


            string[] salesList = new string[1000];
            string[] returnsList = new string[1000];

            string searchValueHeadingGrossSalesList = "MONTANT DES COMMANDES EXPEDIÉES DU";
            string searchValueForGrossSalesList = " 1 ";
            string searchValueForGrossSalesList2 = " 2 ";
            string searchValueMainGrossSalesTotal = "Montant des commandes expédiées par le marchand";
            string searchValueForReturnsList = "MONTANT DES COMMANDES REMBOURSÉES AVANT";
            string searchValueMainReturnsTotal = "Commandes remboursées";
            string searchValueOutcome = "Montant à créditer";


            //Große Forschleife!
            int arrayIndexer = 0;
            foreach (string number in numbers)
            {
                double tempGrossSalesVolumeMarginalVat = 0;
                double tempGrossSalesVolumeNormalVat = 0;
                double tempReturnsMarginalVat = 0;
                double tempReturnsNormalVat = 0;
                double tempOutcome = 0;
                double tempGrossSalesTotal = 0;
                double tempReturnsTotal = 0;
                buildPath = pathPreset + numbers[arrayIndexer] + ":";
                arrayIndexer++;
                string path = eval.lineSearchAndGetValue(buildPath,20);
                string tempPath = "backmarketdata.txt";
                FileStream stream = File.Create(tempPath);
                stream.Close();
                File.WriteAllText(tempPath, ExtractTextFromPdf(path));
                if (File.Exists(path) != true)
                {
                    break;
                }
                string[] allLines = File.ReadAllLines(tempPath);

                //Index herausfinden von Hauptumsatzzeile + Wert Pull
                int indexGrossSalesTotal = findLine(allLines, searchValueMainGrossSalesTotal);
                tempGrossSalesTotal = getValueOfOneLine(indexGrossSalesTotal, allLines, 9, "marchand", "€");
                //Index herausfinden von Hauterstattungen + Wert Pull
                int indexReturnsTotal = findLine(allLines, searchValueMainReturnsTotal) - 1;
                tempReturnsTotal = getValueOfOneLine(indexReturnsTotal, allLines, 12, "remboursées", "€");
                //Index von Outcome + Wert Pull
                int indexOutcome = findLine(allLines, searchValueOutcome) - 1;
                tempOutcome = getValueOfOneLine(indexOutcome, allLines, 23, "créditer", "€");
                //Index herausfinden von Umsatzlist
                int indexGrossSalesList = findLine(allLines, searchValueHeadingGrossSalesList);
                //Einzelne REG-Umsätze in Array speichern
                int arrayIndex = 0;
                int numberOfAllSales = 0;
                for (int i = indexGrossSalesList + 1; i < allLines.Count(); i++)
                {
                    if (allLines[i].Contains(searchValueForGrossSalesList))
                    {
                        if (checkReg(allLines, i) == true)
                        {
                            salesList[arrayIndex] = getValueOfOneLine(i, allLines, 3, searchValueForGrossSalesList, "€").ToString();
                        }
                        arrayIndex++;
                    }
                    else if (allLines[i].Contains(searchValueForGrossSalesList2))
                    {
                        if (checkReg(allLines, i) == true)
                        {
                            salesList[arrayIndex] = getValueOfOneLine(i, allLines, 3, searchValueForGrossSalesList2, "€").ToString();
                        }
                        arrayIndex++;
                    }
                    else
                    {
                        break;
                    }
                }
                //Index herausfinden von Returnlist
                int indexReturnList = findLine(allLines, searchValueForReturnsList);
                //Einzelne REG-Umsätze in Array speichern
                int arrayIndex2 = 0;
                for (int i = indexReturnList + 1; i < allLines.Count(); i++)
                {
                    if (allLines[i].Contains(searchValueForGrossSalesList))
                    {
                        if (checkReg(allLines, i) == true)
                        {
                            returnsList[arrayIndex2] = getValueOfOneLine(i, allLines, 3, searchValueForGrossSalesList, "€").ToString();
                        }
                        arrayIndex2++;
                    }
                    else if (allLines[i].Contains(searchValueForGrossSalesList2))
                    {
                        if (checkReg(allLines, i) == true)
                        {
                            returnsList[arrayIndex2] = getValueOfOneLine(i, allLines, 3, searchValueForGrossSalesList2, "€").ToString();
                        }
                        arrayIndex2++;
                    }
                    else
                    {
                        break;
                    }
                }
                //Alle Werte zusammenrechnen: UmsatzREG
                for (int i = 0; i < salesList.Length; i++)
                {
                    tempGrossSalesVolumeNormalVat += Convert.ToDouble(salesList[i]);
                }
                //Alle Werte zusammenrechnen: ErstattungenREG
                for (int i = 0; i < returnsList.Length; i++)
                {
                    tempReturnsNormalVat += Convert.ToDouble(returnsList[i]);
                }
                //Temp werte zu globalen dazurechnen
                backMarketPayPalGrossSalesVolumeTotal += tempGrossSalesTotal;
                backMarketPayPalGrossSalesVolumeNormalVat += tempGrossSalesVolumeNormalVat;
                backMarketPayPalGrossSalesVolumeMarginalVat += tempGrossSalesTotal - tempGrossSalesVolumeNormalVat;
                backMarketPayPalReturnsTotal += tempReturnsTotal;
                backMarketPayPalReturnsNormalVat += tempReturnsNormalVat;
                backMarketPayPalReturnsMarginalVat += tempReturnsTotal - tempReturnsNormalVat;
                backMarketPayPalFees += tempGrossSalesTotal * 0.029 + (arrayIndex * 0.39);
                backMarketPayPalOutcome += tempOutcome;

            }
            backMarketPayPalOutcome = backMarketPayPalOutcome - backMarketPayPalFees;

            lbl_backMarketPayPalTotalGrossSales.Text = backMarketPayPalGrossSalesVolumeTotal.ToString();
            lbl_backMarketPayPalGrossSalesREG.Text = backMarketPayPalGrossSalesVolumeNormalVat.ToString();
            lbl_backMarketPayPalGrossSalesDIFF.Text = backMarketPayPalGrossSalesVolumeMarginalVat.ToString();
            lbl_backMarketPayPalReturnsREG.Text = backMarketPayPalReturnsNormalVat.ToString();
            lbl_backMarketPayPalReturnsDIFF.Text = backMarketPayPalReturnsMarginalVat.ToString();
            lbl_backMarketPayPalOutcome.Text = backMarketPayPalOutcome.ToString();
            lbl_backMarketPayPalFees.Text = backMarketPayPalFees.ToString();
            progressBar1.Value = 100;
            MessageBox.Show("Der BackMarket Algorithmus wurde erfolgreich ausgeführt.");
        }

        public void BackMarketNormalInvoicesAlgorithm()
        {
            progressBar1.Value = 0;
            EvaluationsFirstPage eval = new EvaluationsFirstPage();
            string[] numbers = new string[3] { "1", "2", "3" };
            string pathPreset = "BackMarket normal ";
            string buildPath = "";

            string[] salesList = new string[1000];
            string[] returnsList = new string[1000];

            string searchValueHeadingGrossSalesList = "MONTANT DES COMMANDES EXPEDIÉES DU";
            string searchValueForGrossSalesList = " 1 ";
            string searchValueForGrossSalesList2 = " 2 ";
            string searchValueMainGrossSalesTotal = "Montant des commandes expédiées par le marchand";
            string searchValueForReturnsList = "MONTANT DES COMMANDES REMBOURSÉES AVANT";
            string searchValueMainReturnsTotal = "Commandes remboursées";
            string searchValueDefferedPayout = "Variation de dépôt de garantie";
            string searchValueOutcomeCheck1 = "Montant à créditer";
            string searchValueOutcomeCheck2 = "Montant dû par le marchand";


            //Große Forschleife!
            int arrayIndexer = 0;
            foreach (string number in numbers)
            {
                double tempGrossSalesVolumeMarginalVat = 0;
                double tempGrossSalesVolumeNormalVat = 0;
                double tempReturnsMarginalVat = 0;
                double tempReturnsNormalVat = 0;
                double tempDefferedPayout = 0;
                double tempOutcome;
                double tempGrossSalesTotal;
                double tempReturnsTotal;
                buildPath = pathPreset + numbers[arrayIndexer] + ":";
                arrayIndexer++;
                string path = eval.lineSearchAndGetValue(buildPath,20);
                string tempPath = "backmarketdata.txt";
                FileStream stream = File.Create(tempPath);
                stream.Close();
                File.WriteAllText(tempPath, ExtractTextFromPdf(path));
                if (File.Exists(path) != true)
                {
                    break;
                }
                string[] allLines = File.ReadAllLines(tempPath);

                //Index herausfinden von Hauptumsatzzeile + Wert Pull
                int indexGrossSalesTotal = findLine(allLines, searchValueMainGrossSalesTotal);
                tempGrossSalesTotal = getValueOfOneLine(indexGrossSalesTotal, allLines, 9, "marchand", "€");
                //Index herausfinden von Hauterstattungen + Wert Pull
                int indexReturnsTotal = findLine(allLines, searchValueMainReturnsTotal) - 1;
                tempReturnsTotal = getValueOfOneLine(indexReturnsTotal, allLines, 12, "remboursées", "€");
                //Deffered Pay Out (Wert Pull + Unterscheidung ob negativ oder positiv!)



                int indexDefferedPayout = findLine(allLines, searchValueDefferedPayout) - 1;
                bool variationDefferedPayout = checkMinusSign(getValueOfOneLineDefferedPayOut(indexDefferedPayout, allLines, 9, "garantie", "€"));
                tempDefferedPayout = getValueOfOneLine(indexDefferedPayout, allLines, 9, "garantie", "€");

                //Deffered Payout | Unterscheidung ob Geld erhalten oder nicht + Unterscheidung ob + oder -
                int indexOutcome = findLine(allLines, searchValueOutcomeCheck1) - 1;
                int indexOutcome2 = findLine(allLines, searchValueOutcomeCheck2) - 1;
                if (variationDefferedPayout == true)
                {
                    if (indexOutcome != -1)
                    {
                        tempOutcome = getValueOfOneLine(indexOutcome, allLines, 23, "créditer", "€") + tempDefferedPayout;
                    }
                    else
                    {
                        tempOutcome = getValueOfOneLine(indexOutcome2, allLines, 23, "marchand", "€");
                        string tempChange = "-" + tempOutcome.ToString();
                        tempOutcome = Convert.ToDouble(tempChange) + tempDefferedPayout;
                    }
                }
                else
                {
                    if (indexOutcome != -1)
                    {
                        tempOutcome = getValueOfOneLine(indexOutcome, allLines, 23, "créditer", "€") - tempDefferedPayout;
                    }
                    else
                    {
                        tempOutcome = getValueOfOneLine(indexOutcome2, allLines, 23, "marchand", "€");
                        string tempChange = "-" + tempOutcome.ToString();
                        tempOutcome = Convert.ToDouble(tempChange) - tempDefferedPayout;
                    }
                }
                

               
                //Index herausfinden von Umsatzlist
                int indexGrossSalesList = findLine(allLines, searchValueHeadingGrossSalesList);
                //Einzelne REG-Umsätze in Array speichern
                int arrayIndex = 0;
                for (int i = indexGrossSalesList + 1; i < allLines.Count(); i++)
                {
                    if (allLines[i].Contains(searchValueForGrossSalesList))
                    {
                        if (checkReg(allLines, i) == true)
                        {
                            salesList[arrayIndex] = getValueOfOneLine(i, allLines, 3, searchValueForGrossSalesList, "€").ToString();
                        }
                        arrayIndex++;
                    }
                    else if (allLines[i].Contains(searchValueForGrossSalesList2))
                    {
                        if (checkReg(allLines, i) == true)
                        {
                            salesList[arrayIndex] = getValueOfOneLine(i, allLines, 3, searchValueForGrossSalesList2, "€").ToString();
                        }
                        arrayIndex++;
                    }
                    else
                    {
                        break;
                    }
                }
                //Index herausfinden von Returnlist
                int indexReturnList = findLine(allLines, searchValueForReturnsList);
                //Einzelne REG-Returns in Array speichern
                int arrayIndex2 = 0;
                for (int i = indexReturnList + 1; i < allLines.Count(); i++)
                {
                    if (allLines[i].Contains(searchValueForGrossSalesList))
                    {
                        if (checkReg(allLines, i) == true)
                        {
                            returnsList[arrayIndex2] = getValueOfOneLine(i, allLines, 3, searchValueForGrossSalesList, "€").ToString();
                        }
                        arrayIndex2++;
                    }
                    else if (allLines[i].Contains(searchValueForGrossSalesList2))
                    {
                        if (checkReg(allLines, i) == true)
                        {
                            returnsList[arrayIndex2] = getValueOfOneLine(i, allLines, 3, searchValueForGrossSalesList2, "€").ToString();
                        }
                        arrayIndex2++;
                    }
                    else
                    {
                        break;
                    }
                }
                //Alle Werte zusammenrechnen: UmsatzREG
                for (int i = 0; i < salesList.Length; i++)
                {
                    tempGrossSalesVolumeNormalVat += Convert.ToDouble(salesList[i]);
                }
                //Alle Werte zusammenrechnen: ErstattungenREG
                for (int i = 0; i < returnsList.Length; i++)
                {
                    tempReturnsNormalVat += Convert.ToDouble(returnsList[i]);
                }
                //Temp werte zu globalen dazurechnen
                //Temp werte zu globalen dazurechnen
                backMarketGrossSalesTotal += tempGrossSalesTotal;
                backMarketGrossSalesVolumeNormalVat += tempGrossSalesVolumeNormalVat;
                backMarketGrossSalesVolumeMarginalVat += tempGrossSalesTotal - tempGrossSalesVolumeNormalVat;
                backMarketReturnsTotal += tempReturnsTotal;
                backMarketReturnsNormalVat += tempReturnsNormalVat;
                backMarketReturnsMarginalVat += tempReturnsTotal - tempReturnsNormalVat;
                backMarketOutcome += tempOutcome;
                backMarketDefferedPayout += tempDefferedPayout;
            }

            lbl_GrossSalesTotalVolume.Text = backMarketGrossSalesTotal.ToString();
            lbl_BackMarketUmsatzREG.Text = backMarketGrossSalesVolumeNormalVat.ToString();
            lbl_BackMarketUmsatzDIFF.Text = backMarketGrossSalesVolumeMarginalVat.ToString();
            lbl_BackMarketErstattungREG.Text = backMarketReturnsNormalVat.ToString();
            lbl_BackMarketErstattungDIFF.Text = backMarketReturnsMarginalVat.ToString();
            lbl_BackMarketDefferedPayout.Text = backMarketDefferedPayout.ToString();
            lbl_BackMarketOutcome.Text = backMarketOutcome.ToString();
            progressBar1.Value = 50;
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
        private void TaxCalculationAlgorithm ()
        {
            progressBar1.Value = 0;
            double tempBMNormalREG = backMarketGrossSalesVolumeNormalVat;
            double tempBMPayPalREG = backMarketPayPalGrossSalesVolumeNormalVat;
            double tempEbayREG = EvaluationSecondForm.ebayGrossSalesMarginalVat;
            double tempSparePartsREG = EvaluationSecondForm.sparepartsGrossSalesNormalVat;
            double tempSumREG = tempBMNormalREG + tempBMPayPalREG + tempEbayREG + tempSparePartsREG;
            progressBar1.Value = 25;
            double tempBMNormalDIFF = backMarketGrossSalesVolumeMarginalVat;
            double tempBMPayPalDIFF = backMarketPayPalGrossSalesVolumeMarginalVat;
            double tempEbayDIFF = EvaluationSecondForm.ebayGrossSalesMarginalVat;
            double tempSparePartsDIFF = EvaluationSecondForm.sparepartsGrossSalesMarginalVat;
            double tempSumDIFF = tempBMNormalDIFF + tempBMPayPalDIFF + tempEbayDIFF + tempSparePartsDIFF;
            progressBar1.Value = 50;
            double tempInputOfGoodsDIFF = inputOfGoodsDIFF;
            double tempInputOfGoodsREG = inputOfGoodsREG;
            double tempInputExternalCosts = inputOfExternalCosts;
            double tempMoreExternal = 0;
            //Endberechnungen
            progressBar1.Value = 75;
            double finalREG = tempSumREG / 1.19 * 0.19;
            double finalDIFF = (tempSumDIFF - tempInputOfGoodsDIFF) / 1.19 * 0.19;
            double finalGetBack = (tempInputExternalCosts + tempInputOfGoodsREG + tempMoreExternal) / 1.19 * 0.19;
            double finalHaveToPay = finalREG + finalDIFF - finalGetBack;
            progressBar1.Value = 100;
            //Runden + Label ändern
            string newFinalREG = RoundNumber(finalREG.ToString());
            lbl_TaxesREG.Text = newFinalREG.ToString();
            string newFinalDIFF = RoundNumber(finalDIFF.ToString());
            lbl_TaxesDIFF.Text = newFinalDIFF.ToString();
            string newFinalGetBack = RoundNumber(finalGetBack.ToString());
            lbl_TaxesGetBack.Text = newFinalGetBack.ToString();
            string newFinalHaveToPay = RoundNumber(finalHaveToPay.ToString());
            taxesHaveToPay = Convert.ToDouble(newFinalHaveToPay);
            lbl_TaxesTaxesHaveToPay.Text = newFinalHaveToPay.ToString();
            MessageBox.Show("Der Steuerberechnung Algorithmus wurde erfolgreich ausgeführt.");
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
                string ebReference = row.Cells[21].Value.ToString();
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
                if (row.Cells[8].Value.ToString() == month)
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

        private void btn_ContinueToSumUp_Click(object sender, EventArgs e)
        {
            EvaluationSumUp window = new EvaluationSumUp();
            window.Show();
            this.Hide();
        }

        private void btn_ExecuteAllAlgorithms_Click(object sender, EventArgs e)
        {
            OrderRelationPDF orderRelationPDF = new OrderRelationPDF();
            orderRelationPDF.Main();
            //try
            //{
            //    MatchingAlgorithm();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Der Matching Algorithmus hat ein Problem: " + ex.Message);
            //}
            //try
            //{
            //    CalculateInputAlgorithm();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Der Algorithmus für die Berechnung des Einsatzes hat ein Problem: " + ex.Message);
            //}
            //MessageBox.Show("Zwischenüberprüfung: \r\n- Zu Matching hinzugefügte Einträge: "+checkValueAddedDevicesToMatching + "\r\n- Anzahl der Geräte Input gezählt: "+checkValueDevicesCountedInput + "\r\nDiese Werte müssen übereinstimmen, ansonsten ist ein Fehler unterlaufen.");
            //try
            //{
            //    BackMarketInvoicesChecking();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Der BackMarket Algorithmus hat ein Problem: " + ex.Message);
            //}
            //try
            //{
            //    TaxCalculationAlgorithm();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Der Steuerberechnung Algorithmus hat ein Problem: " + ex.Message);
            //}
            //try
            //{
            //    DonorDevicesAlgorithm();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Der Spendergeräte Algorithmus hat ein Problem: " + ex.Message);
            //}
            //try
            //{
            //    DevicesPerMonthAlgorithm();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Der Geräte pro Monat Algorithmus hat ein Problem: " + ex.Message);
            //}
        }
    }
}