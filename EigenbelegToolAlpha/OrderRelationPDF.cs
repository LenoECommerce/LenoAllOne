using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SautinSoft.Document;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Drawing.Layout;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;

namespace EigenbelegToolAlpha
{
    public class OrderRelationPDF
    {
        EvaluationsBackMarketPDF evaluationsBackMarketPDF = new EvaluationsBackMarketPDF();
        EvaluationsEbayPDF evaluationsEbay = new EvaluationsEbayPDF();
        EvaluationsFirstPage EvaluationsFirstPage = new EvaluationsFirstPage();

        public static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
        public string backmarketOrdersPath = "";
        public string fullPath = desktopPath + "test.pdf";
        public double headingPosY = 30;
        public double entriesAdded = 0;
        //calcs
        public double marketPlaceFeesEbay = 0;
        public double taxes = 0;
        public double revenue = 0;
        public double margin = 0;

        public static int beginLineEbay = 0;
        public double paymentFeesNotPayPalTotal = 0;
        public double OrdersNotPayPal = 0;
        public double paymentFeesNotPayPalPerOrder = 0;
        public static double backCareFee = 0;
        public static double backShipCosts = 0;

        public static double backCareFees1 = 0;
        public static double backCareFees2 = 0;
        public static double backCareFees3 = 0;

        //monthly report sum up values
        public static double grossSalesEbay = 0;
        public static double grossSalesBackmarketNormal = 0;
        public static double grossSalesBackmarketPayPal = 0;
        public static double revenueTotal = 0;
        public void Main (string orderId, string internalNumber, string amount, string externalCosts, string externalCostsDiff, string taxesType)
        {
            string pdfFound = "";
            string salesVolume = "";
            string marketplaceFees = "";
            double paymentFees = 0;
            if (File.Exists(fullPath))
            {
                //add new entry
                PdfDocument document = PdfReader.Open(fullPath, PdfDocumentOpenMode.Modify);
                PdfPage page = document.Pages[0];
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont heading = new XFont("Arial", 20);
                XFont main = new XFont("Arial", 14);
                XFont subFont = new XFont("Arial", 11);

                //fetch order id etc.
                pdfFound = evaluationsBackMarketPDF.FindPDFViaOrderNumber(orderId);
                backmarketOrdersPath = EvaluationsFirstPage.lineSearchAndGetValue("BackMarket XLS:", 15);
                if (CheckMarketPlace(orderId)=="BackMarket")
                {
                    if (BackMarketXLSAnalysis.Main(backmarketOrdersPath, orderId) != "DE")
                    {
                        backShipCosts = 15;
                    }
                    else
                    {
                        backShipCosts = 0;
                    }
                    if (evaluationsBackMarketPDF.CheckPDFTypeIfNormal(pdfFound) == true)
                    //Normal
                    {
                        paymentFees = paymentFeesNotPayPalPerOrder;
                        salesVolume = evaluationsBackMarketPDF.GetSalesVolume(orderId, pdfFound);
                        if(salesVolume != "N/A")
                        {
                            grossSalesBackmarketNormal += Convert.ToDouble(salesVolume);
                        }
                        double marketplaceFeesTemp = RoundOneDigit(evaluationsBackMarketPDF.CollectMarketPlaceFess(salesVolume) + paymentFees + backCareFee + backShipCosts);
                        marketplaceFees = marketplaceFeesTemp.ToString();
                    }
                    else
                    //PayPal
                    {
                        salesVolume = evaluationsBackMarketPDF.GetSalesVolume(orderId, pdfFound);
                        if (salesVolume != "N/A")
                        {
                            grossSalesBackmarketPayPal += Convert.ToDouble(salesVolume);
                        }
                        paymentFees = Convert.ToDouble(salesVolume) * 0.029 + 0.39;
                        double marketplaceFeesTemp = RoundOneDigit(evaluationsBackMarketPDF.CollectMarketPlaceFess(salesVolume) + backCareFee +backShipCosts + paymentFees);
                        marketplaceFees = marketplaceFeesTemp.ToString();
                    }
                }
                //Ebay part
                else
                {
                    salesVolume = evaluationsEbay.GetSalesVolume(orderId);
                    if (salesVolume != "N/A")
                    {
                        grossSalesEbay += Convert.ToDouble(salesVolume);
                    }
                    marketPlaceFeesEbay = RoundOneDigit(evaluationsEbay.GetSellerCommission(orderId) + (Convert.ToDouble(salesVolume)*0.02));
                    marketplaceFees = marketPlaceFeesEbay.ToString();
                }
                taxes = RoundOneDigit(CalcTaxes(taxesType, salesVolume, amount, externalCosts, externalCostsDiff));
                revenue = RoundOneDigit(CalcRevenue(salesVolume, Convert.ToDouble(amount), Convert.ToDouble(externalCosts), Convert.ToDouble(externalCostsDiff), taxes, Convert.ToDouble(marketplaceFees)));
                margin = RoundOneDigit(CalcMargin(salesVolume, revenue));
                revenueTotal += revenue;
                //drawing part
                double subBegin = headingPosY + 20 + entriesAdded * 10;
                gfx.DrawString(orderId, subFont, XBrushes.Black, new XPoint(10, subBegin));
                gfx.DrawString(internalNumber, subFont, XBrushes.Black, new XPoint(110, subBegin));
                gfx.DrawString(amount, subFont, XBrushes.Black, new XPoint(160, subBegin));
                gfx.DrawString(externalCosts, subFont, XBrushes.Black, new XPoint(240, subBegin));
                gfx.DrawString(externalCostsDiff, subFont, XBrushes.Black, new XPoint(290, subBegin));
                gfx.DrawString(taxesType, subFont, XBrushes.Black, new XPoint(340, subBegin));
                gfx.DrawString(taxes.ToString(), subFont, XBrushes.Black, new XPoint(390, subBegin));
                gfx.DrawString(marketplaceFees, subFont, XBrushes.Black, new XPoint(450, subBegin));
                gfx.DrawString(revenue.ToString(), subFont, XBrushes.Black, new XPoint(490, subBegin));
                gfx.DrawString(margin.ToString(), subFont, XBrushes.Black, new XPoint(530, subBegin));
                document.Save(fullPath);
                entriesAdded++;
            }
            else
            {
                //Set up file with one entry
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                PdfDocument document = new PdfDocument();
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont heading = new XFont("Arial", 20);
                XFont main = new XFont("Arial", 14);
                XFont subFont = new XFont("Arial", 11);
                //Zeilenüberschriften
                gfx.DrawString("Orderübersicht", main, XBrushes.Black, new XPoint(10, 10));
                gfx.DrawString("Bestellnummer", main, XBrushes.Black, new XPoint(10, headingPosY));
                gfx.DrawString("Intern", main, XBrushes.Black, new XPoint(110, headingPosY));
                gfx.DrawString("Kaufbetrag", main, XBrushes.Black, new XPoint(160, headingPosY));
                gfx.DrawString("Ko RE", main, XBrushes.Black, new XPoint(240, headingPosY));
                gfx.DrawString("Ko DI", main, XBrushes.Black, new XPoint(290, headingPosY));
                gfx.DrawString("Bst.", main, XBrushes.Black, new XPoint(340, headingPosY));
                gfx.DrawString("Steuern", main, XBrushes.Black, new XPoint(390, headingPosY));
                gfx.DrawString("MP", main, XBrushes.Black, new XPoint(450, headingPosY));
                gfx.DrawString("Rev", main, XBrushes.Black, new XPoint(490, headingPosY));
                gfx.DrawString("Mar", main, XBrushes.Black, new XPoint(530, headingPosY));

                //Vertikale Linien
                gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(105, 20), new XPoint(105, 1000));
                gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(155, 20), new XPoint(155, 1000));
                gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(235, 20), new XPoint(235, 1000));
                gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(285, 20), new XPoint(285, 1000));
                gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(335, 20), new XPoint(335, 1000));
                gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(385, 20), new XPoint(385, 1000));
                gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(105, 20), new XPoint(105, 1000));
                gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(445, 20), new XPoint(445, 1000));
                gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(485, 20), new XPoint(485, 1000));
                gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(525, 20), new XPoint(525, 1000));
                //Horizontale Linien
                gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(0, 35), new XPoint(1000, 35));
                //Insert Values
                //First important setup
                SetUpFirstCreation();
                pdfFound = evaluationsBackMarketPDF.FindPDFViaOrderNumber(orderId);
                backmarketOrdersPath = EvaluationsFirstPage.lineSearchAndGetValue("BackMarket XLS:", 15);
                if (CheckMarketPlace(orderId) == "BackMarket")
                {
                    if (BackMarketXLSAnalysis.Main(backmarketOrdersPath, orderId) != "DE")
                    {
                        backShipCosts = 15;
                    }
                    else
                    {
                        backShipCosts = 0;
                    }
                    if (evaluationsBackMarketPDF.CheckPDFTypeIfNormal(pdfFound) == true)
                    //Normal
                    {
                        paymentFees = paymentFeesNotPayPalPerOrder;
                        if (salesVolume != "N/A")
                        {
                            grossSalesBackmarketNormal += Convert.ToDouble(salesVolume);
                        }
                        salesVolume = evaluationsBackMarketPDF.GetSalesVolume(orderId, pdfFound);
                        double marketplaceFeesTemp = RoundOneDigit(evaluationsBackMarketPDF.CollectMarketPlaceFess(salesVolume) + paymentFees + backCareFee + backShipCosts);
                        marketplaceFees = marketplaceFeesTemp.ToString();
                    }
                    else
                    //PayPal
                    {
                        salesVolume = evaluationsBackMarketPDF.GetSalesVolume(orderId, pdfFound);
                        if (salesVolume != "N/A")
                        {
                            grossSalesBackmarketPayPal += Convert.ToDouble(salesVolume);
                        }
                        paymentFees = Convert.ToDouble(salesVolume) * 0.029 + 0.39;
                        double marketplaceFeesTemp = RoundOneDigit(evaluationsBackMarketPDF.CollectMarketPlaceFess(salesVolume) + backCareFee + backShipCosts + paymentFees);
                        marketplaceFees = marketplaceFeesTemp.ToString();
                    }
                }
                //Ebay part
                else
                {
                    salesVolume = evaluationsEbay.GetSalesVolume(orderId);
                    if (salesVolume != "N/A")
                    {
                        grossSalesEbay += Convert.ToDouble(salesVolume);
                    }
                    marketPlaceFeesEbay = RoundOneDigit(evaluationsEbay.GetSellerCommission(orderId) + (Convert.ToDouble(salesVolume) * 0.02));
                    marketplaceFees = marketPlaceFeesEbay.ToString();

                }
                taxes = RoundOneDigit(CalcTaxes(taxesType, salesVolume, amount, externalCosts, externalCostsDiff));
                revenue = RoundOneDigit(CalcRevenue(salesVolume, Convert.ToDouble(amount), Convert.ToDouble(externalCosts), Convert.ToDouble(externalCostsDiff), taxes, Convert.ToDouble(marketplaceFees)));
                margin = RoundOneDigit(CalcMargin(salesVolume, revenue));
                revenueTotal += revenue;
                //drawing part
                double subBegin = headingPosY + 20;
                gfx.DrawString(orderId, subFont, XBrushes.Black, new XPoint(10, subBegin));
                gfx.DrawString(internalNumber, subFont, XBrushes.Black, new XPoint(110, subBegin));
                gfx.DrawString(amount, subFont, XBrushes.Black, new XPoint(160, subBegin));
                gfx.DrawString(externalCosts, subFont, XBrushes.Black, new XPoint(240, subBegin));
                gfx.DrawString(externalCostsDiff, subFont, XBrushes.Black, new XPoint(290, subBegin));
                gfx.DrawString(taxesType, subFont, XBrushes.Black, new XPoint(340, subBegin));
                gfx.DrawString(taxes.ToString(), subFont, XBrushes.Black, new XPoint(390, subBegin));
                gfx.DrawString(marketplaceFees, subFont, XBrushes.Black, new XPoint(450, subBegin));
                gfx.DrawString(revenue.ToString(), subFont, XBrushes.Black, new XPoint(490, subBegin));
                gfx.DrawString(margin.ToString(), subFont, XBrushes.Black, new XPoint(530, subBegin));
                document.Save(fullPath);
                entriesAdded++;
            }
        }
        public void SetUpFirstCreation()
        {
            evaluationsBackMarketPDF.Main();
            evaluationsEbay.Main();
            paymentFeesNotPayPalTotal = evaluationsBackMarketPDF.CollectPaymentFeesAndBackCare();
            OrdersNotPayPal = evaluationsBackMarketPDF.CountNotPayPalOrders();
            double temp = evaluationsBackMarketPDF.RoundOneDigit(paymentFeesNotPayPalTotal / OrdersNotPayPal);
            paymentFeesNotPayPalPerOrder = temp;
        }
        public string CheckMarketPlace(string checkValue)
        {
            if (checkValue.Contains("-"))
            {
                return "Ebay";
            }
            else
            {
                return "BackMarket";
            }
        }
        public double CalcTaxes(string taxesType, string salesVolume, string deviceAmount, string external, string externalDIFF)
        {
            if (salesVolume == "N/A")
            {
                return 0;
            }
            double getBackTax = 0;
            double normalTax = 0;
            double haveToPayTax = 0;
            if (taxesType.Contains("REG"))
            {
                normalTax += Convert.ToDouble(salesVolume) / 1.19 * 0.19;
                getBackTax += Convert.ToDouble(deviceAmount) / 1.19 * 0.19;
            }
            else
            {
                normalTax += (Convert.ToDouble(salesVolume) - Convert.ToDouble(deviceAmount) - Convert.ToDouble(externalDIFF)) / 1.19 * 0.19;
            }
            getBackTax += Convert.ToDouble(external)/1.19 * 0.19;
            haveToPayTax = normalTax - getBackTax;
            return haveToPayTax;
        }
        public double CalcRevenue (string salesVolume, double deviceAmount, double external, double externalDIFF, double taxes, double marketplaceFees)
        {
            if (salesVolume == "N/A")
            {
                return 0;
            }
            double revenue = Convert.ToDouble(salesVolume) - deviceAmount - external - externalDIFF - taxes - marketplaceFees;
            return revenue;
        }
        public double CalcMargin (string salesVolume, double revenue)
        {
            if (salesVolume == "N/A")
            {
                return 0;
            }
            double margin = revenue / Convert.ToDouble(salesVolume) * 100;
            return margin;
        }
        public double RoundOneDigit(double adaptValue)
        {
            string tempValue = adaptValue.ToString();
            if (tempValue.Contains(","))
            {
                var pos = tempValue.IndexOf(",");
                tempValue = tempValue.Substring(0, pos + 2);
                adaptValue = Convert.ToDouble(tempValue);
            }
            return adaptValue;
        }

    }
}
