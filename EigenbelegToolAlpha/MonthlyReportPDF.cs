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
        public static string month = "";
        public static string filename = "test2";
        public static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
        public static string fullPath = desktopPath + filename + ".pdf";
        public static string monthlyReportFinishedPath = desktopPath + "Monthly Report" + month + ".pdf";
        public static void CreatePDFFile()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //New document
            PdfDocument document = new PdfDocument();
            //New pages
            PdfPage page = document.AddPage();
            PdfPage page2 = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XGraphics gfx2 = XGraphics.FromPdfPage(page2);
            XFont heading = new XFont("Arial", 20);
            XFont main = new XFont("Arial", 14);
            XFont subFont = new XFont("Arial", 11);
            XTextFormatter tf = new XTextFormatter(gfx);


            //Text schreiben
            // XBrushed means color; xPoint sozusagen X und Y
            // Wichtig!! Position muss absolut sein und nicht dynamisch, mit Algorithmus
            //Drawline: XColor: Code Werte

            gfx.DrawString("Monthly Report "/*month*/, heading, XBrushes.Black, new XPoint(100, 100));
            //Vertikale Line
            gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(180, 120), new XPoint(180, 1000));
            //Anfang
            gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(0, 120), new XPoint(1000, 120));
            //Umsatzübersicht
            gfx.DrawString("Umsatzübersicht", main, XBrushes.Black, new XPoint(25, 140));
            gfx.DrawString("Regelbesteuert", main, XBrushes.Black, new XPoint(200, 140));
            gfx.DrawString("Differenzbesteuert", main, XBrushes.Black, new XPoint(400, 140));
            gfx.DrawString("Ebay", main, XBrushes.Black, new XPoint(25, 170));
            gfx.DrawString("BM Normal", main, XBrushes.Black, new XPoint(25, 200));
            gfx.DrawString("BM PayPal", main, XBrushes.Black, new XPoint(25, 230));
            gfx.DrawString("Ersatzteile", main, XBrushes.Black, new XPoint(25, 260));
            gfx.DrawString("Ankunft", main, XBrushes.Black, new XPoint(25, 290));

            //gfx.DrawString(ebayGrossREG + "€", subFont, XBrushes.Black, new XPoint(200, 170));
            //gfx.DrawString(ebayGrossDIFF + "€", subFont, XBrushes.Black, new XPoint(400, 170));
            //gfx.DrawString(backmarketNormalGrossREG + "€", subFont, XBrushes.Black, new XPoint(200, 200));
            //gfx.DrawString(backmarketNormalGrossDIFF + "€", subFont, XBrushes.Black, new XPoint(400, 200));
            //gfx.DrawString(backmarketPayPalGrossREG + "€", subFont, XBrushes.Black, new XPoint(200, 230));
            //gfx.DrawString(backmarketPayPalGrossDIFF + "€", subFont, XBrushes.Black, new XPoint(400, 230));
            //gfx.DrawString(sparepartsGrossREG + "€", subFont, XBrushes.Black, new XPoint(200, 260));
            //gfx.DrawString(sparepartsGrossDIFF + "€", subFont, XBrushes.Black, new XPoint(400, 260));
            //gfx.DrawString(outcomeGross + "€", subFont, XBrushes.Black, new XPoint(200, 290));
            gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(0, 310), new XPoint(1000, 310));
            //Einsatzübersicht
            //gfx.DrawString("Einsatzübersicht", main, XBrushes.Black, new XPoint(25, 330));
            //gfx.DrawString("Ware REG", main, XBrushes.Black, new XPoint(200, 330));
            //gfx.DrawString(inputGoodsREG + "€", subFont, XBrushes.Black, new XPoint(400, 330));
            //gfx.DrawString("Ware DIFF", main, XBrushes.Black, new XPoint(200, 360));
            //gfx.DrawString(inputGoodsDIFF + "€", subFont, XBrushes.Black, new XPoint(400, 360));
            //gfx.DrawString("Externe Kosten", main, XBrushes.Black, new XPoint(200, 390));
            //gfx.DrawString(inputExternalCosts + "€", subFont, XBrushes.Black, new XPoint(400, 390));
            //gfx.DrawString("Externer Aufwand", main, XBrushes.Black, new XPoint(200, 420));
            //gfx.DrawString(inputExternalInput + "€", subFont, XBrushes.Black, new XPoint(400, 420));
            //gfx.DrawString("Spender", main, XBrushes.Black, new XPoint(200, 450));
            //gfx.DrawString(inputDonatorDevices + "€", subFont, XBrushes.Black, new XPoint(400, 450));
            //gfx.DrawString("Insgesamt", main, XBrushes.Black, new XPoint(200, 480));
            //gfx.DrawString(inputTotal + "€", subFont, XBrushes.Black, new XPoint(400, 480));
            //gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(0, 500), new XPoint(1000, 500));
            ////Sonstiges
            //gfx.DrawString("Sonstiges", main, XBrushes.Black, new XPoint(25, 520));
            //gfx.DrawString("Verbrauch", main, XBrushes.Black, new XPoint(200, 520));
            //gfx.DrawString(rateOfConsumptionTotal + "€", subFont, XBrushes.Black, new XPoint(400, 520));
            //gfx.DrawString("Laufende Kosten", main, XBrushes.Black, new XPoint(200, 550));
            //gfx.DrawString(runningCostsTotal + "€", subFont, XBrushes.Black, new XPoint(400, 550));
            //gfx.DrawString("Mehrsteuern", main, XBrushes.Black, new XPoint(200, 580));
            //gfx.DrawString(taxesToPay + "€", subFont, XBrushes.Black, new XPoint(400, 580));
            //gfx.DrawString("B2B Umsatz", main, XBrushes.Black, new XPoint(200, 610));
            //gfx.DrawString(grossB2B + "€", subFont, XBrushes.Black, new XPoint(400, 610));
            //gfx.DrawString("B2B Gewinn", main, XBrushes.Black, new XPoint(200, 640));
            //gfx.DrawString(revenueB2B + "€", subFont, XBrushes.Black, new XPoint(400, 640));
            //gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(0, 660), new XPoint(1000, 660));
            ////KPIs
            //gfx.DrawString("KPIs", main, XBrushes.Black, new XPoint(25, 680));
            //gfx.DrawString("Umsatz", main, XBrushes.Black, new XPoint(200, 680));
            //gfx.DrawString(kpiGrossSalesTotal + "€", subFont, XBrushes.Black, new XPoint(400, 680));
            //gfx.DrawString("Gewinn", main, XBrushes.Black, new XPoint(200, 710));
            //gfx.DrawString(kpiRevenueTotal + "€", subFont, XBrushes.Black, new XPoint(400, 710));
            //gfx.DrawString("Gewinn n. K.", main, XBrushes.Black, new XPoint(200, 740));
            //gfx.DrawString(kpiRevenueTotalAfterCosts + "€", subFont, XBrushes.Black, new XPoint(400, 740));
            //gfx.DrawString("Marge n. K.", main, XBrushes.Black, new XPoint(200, 770));
            //gfx.DrawString(margin.ToString() + " %", subFont, XBrushes.Black, new XPoint(400, 770));
            //gfx.DrawString("Geräte verkauft", main, XBrushes.Black, new XPoint(200, 800));
            //gfx.DrawString(kpiDevicesPerMonthSold + " Geräte", subFont, XBrushes.Black, new XPoint(400, 800));
            //gfx.DrawString("Kosten pro Auftrag (Misch)", main, XBrushes.Black, new XPoint(200, 830));
            //gfx.DrawString(costsPerDevice + "€", subFont, XBrushes.Black, new XPoint(400, 830));

            //gfx2.DrawString("Quelle: Ebay", main, XBrushes.Black, new XPoint(200, 100));
            //gfx2.DrawString(kpiSourceEbay + " Geräte", subFont, XBrushes.Black, new XPoint(400, 100));
            //gfx2.DrawString("Quelle: Ebay Kleinanzeigen", main, XBrushes.Black, new XPoint(200, 130));
            //gfx2.DrawString(kpiSourceEbayKleinanzeigen + " Geräte", subFont, XBrushes.Black, new XPoint(400, 130));
            //gfx2.DrawString("Quelle: BackMarket", main, XBrushes.Black, new XPoint(200, 160));
            //gfx2.DrawString(kpiSourceBackMarket + " Geräte", subFont, XBrushes.Black, new XPoint(400, 160));
            //gfx2.DrawString("Durchfluss", main, XBrushes.Black, new XPoint(200, 200));
            //gfx2.DrawString(kpiDevicesPerMonthInTotal + " Geräte", subFont, XBrushes.Black, new XPoint(400, 200));

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
    }
}
