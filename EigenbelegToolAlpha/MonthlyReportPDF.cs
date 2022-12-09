using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.IO;
using PdfSharpTextExtractor;
using BarcodeLib;
using ceTe.DynamicPDF;
using PdfSharp.Drawing.Layout;
using System.Drawing;
using iTextSharp.text.pdf;
using PdfDocument = PdfSharp.Pdf.PdfDocument;
using PdfReader = PdfSharp.Pdf.IO.PdfReader;
using PdfPage = PdfSharp.Pdf.PdfPage;
using Org.BouncyCastle.Asn1.Pkcs;
using System.Threading;

namespace EigenbelegToolAlpha
{
    public class MonthlyReportPDF
    {
        public static string month = EvaluationsFirstPage.month;
        public static string filename = "test2";
        public static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
        public static string fullPath = desktopPath + filename + ".pdf";
        public static string monthlyReportFinishedPath = desktopPath + "Monthly Report" + month + ".pdf";
        //some value calcs
        public static double runningCostsTotalNet = RoundOneDigit(EvaluationThirdForm.RunningCostsFinal + EvaluationSecondForm.rateConsumptionTotal);
        public static double grossSalesTotalB2C = OrderRelationPDF.grossSalesEbay + OrderRelationPDF.grossSalesBackmarketPayPal + OrderRelationPDF.grossSalesBackmarketNormal;
        public static double costsAtAll = runningCostsTotalNet + EvaluationSecondForm.moreExternalCosts + EvaluationCalculation.donorDevicesAmount;
        public static double revenueAfterCosts = RoundOneDigit(OrderRelationPDF.revenueTotal - costsAtAll);
        public static double margin = RoundOneDigit(revenueAfterCosts / grossSalesTotalB2C * 100);
        public static double costsPerOrder = RoundOneDigit(runningCostsTotalNet / EvaluationCalculation.kpiDevicesPerMonthSold);
        public static void CreatePDFFile()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //New document
            PdfDocument document = new PdfDocument();
            //New pages
            PdfPage page = document.AddPage();
            //PdfPage page2 = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);
            //XGraphics gfx2 = XGraphics.FromPdfPage(page2);
            XFont heading = new XFont("Arial", 20);
            XFont main = new XFont("Arial", 14);
            XFont subFont = new XFont("Arial", 11);
            XTextFormatter tf = new XTextFormatter(gfx);


            //Text schreiben
            // XBrushed means color; xPoint sozusagen X und Y
            // Wichtig!! Position muss absolut sein und nicht dynamisch, mit Algorithmus
            //Drawline: XColor: Code Werte

            gfx.DrawString("Monthly Report "+month, heading, XBrushes.Black, new XPoint(100, 100));
            //Vertikale Line
            gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(180, 120), new XPoint(180, 1000));
            //Anfang
            gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(0, 120), new XPoint(1000, 120));
            //Umsatzübersicht
            gfx.DrawString("Umsatzübersicht", main, XBrushes.Black, new XPoint(25, 140));
            gfx.DrawString("Ebay", main, XBrushes.Black, new XPoint(200, 170));
            gfx.DrawString("BM Normal", main, XBrushes.Black, new XPoint(200, 200));
            gfx.DrawString("BM PayPal", main, XBrushes.Black, new XPoint(200, 230));
            gfx.DrawString("Ersatzteile", main, XBrushes.Black, new XPoint(200, 260));
            gfx.DrawString(OrderRelationPDF.grossSalesEbay.ToString() + "€", subFont, XBrushes.Black, new XPoint(400, 170));
            gfx.DrawString(OrderRelationPDF.grossSalesBackmarketNormal.ToString() + "€", subFont, XBrushes.Black, new XPoint(400, 200));
            gfx.DrawString(OrderRelationPDF.grossSalesBackmarketPayPal.ToString() + "€", subFont, XBrushes.Black, new XPoint(400, 230));
            gfx.DrawString("/" + "€", subFont, XBrushes.Black, new XPoint(400, 260));
            gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(0, 310), new XPoint(1000, 310));
            //Sonstiges
            gfx.DrawString("Sonstiges", main, XBrushes.Black, new XPoint(25, 330));
            gfx.DrawString("Laufende Kosten", main, XBrushes.Black, new XPoint(200, 360));
            gfx.DrawString(runningCostsTotalNet.ToString() + "€", subFont, XBrushes.Black, new XPoint(400, 360));
            gfx.DrawString("B2B Umsatz", main, XBrushes.Black, new XPoint(200, 390));
            gfx.DrawString(EvaluationSecondForm.B2BGrossSalesTotal.ToString() + "€", subFont, XBrushes.Black, new XPoint(400, 390));
            gfx.DrawString("B2B Gewinn", main, XBrushes.Black, new XPoint(200, 420));
            gfx.DrawString(EvaluationSecondForm.B2BRevenue.ToString() + "€", subFont, XBrushes.Black, new XPoint(400, 420));
            gfx.DrawString("Externer Aufwand", main, XBrushes.Black, new XPoint(200, 450));
            gfx.DrawString(EvaluationSecondForm.moreExternalCosts.ToString() + "€", subFont, XBrushes.Black, new XPoint(400, 450));
            gfx.DrawString("Spender", main, XBrushes.Black, new XPoint(200, 480));
            gfx.DrawString(EvaluationCalculation.donorDevicesAmount.ToString() + "€", subFont, XBrushes.Black, new XPoint(400, 480));
            gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(0, 500), new XPoint(1000, 500));
            //KPIs
            gfx.DrawString("KPIs (B2C)", main, XBrushes.Black, new XPoint(25, 520));
            gfx.DrawString("Umsatz", main, XBrushes.Black, new XPoint(200, 550));
            gfx.DrawString(grossSalesTotalB2C.ToString() + "€", subFont, XBrushes.Black, new XPoint(400, 550));
            gfx.DrawString("Gewinn", main, XBrushes.Black, new XPoint(200, 580));
            gfx.DrawString(OrderRelationPDF.revenueTotal.ToString() + "€", subFont, XBrushes.Black, new XPoint(400, 580));
            gfx.DrawString("Gewinn n. K.", main, XBrushes.Black, new XPoint(200, 610));
            gfx.DrawString(revenueAfterCosts + "€", subFont, XBrushes.Black, new XPoint(400, 610));
            gfx.DrawString("Marge n. K.", main, XBrushes.Black, new XPoint(200, 640));
            gfx.DrawString(margin.ToString() + "%", subFont, XBrushes.Black, new XPoint(400, 640));
            gfx.DrawString("Quelle: Ebay", main, XBrushes.Black, new XPoint(200, 670));
            gfx.DrawString(EvaluationCalculation.kpiSourceCounterEbay.ToString() + " Geräte", subFont, XBrushes.Black, new XPoint(400, 670));
            gfx.DrawString("Quelle: Ebay Kleinanzeigen", main, XBrushes.Black, new XPoint(200, 700));
            gfx.DrawString(EvaluationCalculation.kpiSourceCounterEbayKleinanzeigen.ToString() + " Geräte", subFont, XBrushes.Black, new XPoint(400, 700));
            gfx.DrawString("Quelle: BackMarket", main, XBrushes.Black, new XPoint(200, 730));
            gfx.DrawString(EvaluationCalculation.kpiSourceCounterBackMarket.ToString() + " Geräte", subFont, XBrushes.Black, new XPoint(400, 730));
            gfx.DrawString("Durchfluss", main, XBrushes.Black, new XPoint(200, 760));
            gfx.DrawString(EvaluationCalculation.kpiDevicesPerMonth.ToString() + " Geräte", subFont, XBrushes.Black, new XPoint(400, 760));
            gfx.DrawString("Geräte verkauft", main, XBrushes.Black, new XPoint(200, 790));
            gfx.DrawString(EvaluationCalculation.kpiDevicesPerMonthSold.ToString() + " Geräte", subFont, XBrushes.Black, new XPoint(400, 790));
            gfx.DrawString("Kosten / Auftrag (Misch)", main, XBrushes.Black, new XPoint(200, 820));
            gfx.DrawString(costsPerOrder.ToString() + " Geräte", subFont, XBrushes.Black, new XPoint(400, 820));

            //Leno Logo
            string imagePath = Path.GetTempPath();
            imagePath = imagePath + "lenologo.jpg";
            if (File.Exists(imagePath) == false)
            {
                Properties.Resources.lenologo.Save(imagePath);
            }
            DrawImage(gfx, imagePath, 400, 10, 175, 100);
            //Verhältnis 1,75; passt Größe?
            document.Save(fullPath);
            MergeFiles();
        }
        public static void MergeFiles()
        {
            PdfDocument document = new PdfDocument();
            OrderRelationPDF orderRelationPDF = new OrderRelationPDF();
            string[] files = new string[2] {orderRelationPDF.fullPath, fullPath}; 
            foreach (string pdfFile in files)
            {
                PdfDocument inputPDFDocument = PdfReader.Open(pdfFile, PdfDocumentOpenMode.Import);
                document.Version = inputPDFDocument.Version;
                //actual pdf merge
                foreach (PdfPage page in inputPDFDocument.Pages)
                {
                    document.AddPage(page);
                }
                // When document is add in pdf document remove file from folder  
                System.IO.File.Delete(pdfFile);
            }
            // Set font for paging  
            XFont font = new XFont("Verdana", 9);
            XBrush brush = XBrushes.Black;
            // Create variable that store page count  
            string noPages = document.Pages.Count.ToString();
            // Set for loop of document page count and set page number using DrawString function of PdfSharp  
            for (int i = 0; i < document.Pages.Count; ++i)
            {
                PdfPage page = document.Pages[i];
                // Make a layout rectangle.  
                XRect layoutRectangle = new XRect(240 /*X*/ , page.Height - font.Height - 10 /*Y*/ , page.Width /*Width*/ , font.Height /*Height*/ );
                using (XGraphics gfx = XGraphics.FromPdfPage(page))
                {
                    gfx.DrawString("Page " + (i + 1).ToString() + " of " + noPages, font, brush, layoutRectangle, XStringFormats.Center);
                }
            }
            document.Options.CompressContentStreams = true;
            document.Options.NoCompression = false;
            // In the final stage, all documents are merged and save in your output file path.  
            document.Save(monthlyReportFinishedPath);
        }
        public static void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            if (File.Exists(jpegSamplePath) == false)
            {
                MessageBox.Show("Für den Pfad " + jpegSamplePath + " wurde keine Datei gefunden.");
                return;
            }
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }

        public static double RoundOneDigit(double adaptValue)
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
