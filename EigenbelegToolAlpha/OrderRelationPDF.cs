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

        public static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
        public string fullPath = desktopPath + "test.pdf";
        public double headingPosY = 30;
        public double entriesAdded = 0;
        public string taxes = "";

        public void Main (string orderId, string internalNumber, string amount, string externalCosts, string externalCostsDiff, string taxesType)
        {
            string pdfTest = "";
            if (File.Exists(fullPath))
            {
                //add new entry
                PdfDocument document = PdfReader.Open(fullPath, PdfDocumentOpenMode.Modify);
                PdfPage page = document.Pages[0];
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont heading = new XFont("Arial", 20);
                XFont main = new XFont("Arial", 14);
                XFont subFont = new XFont("Arial", 11);

                //fetch order id
                pdfTest = evaluationsBackMarketPDF.FindPDFViaOrderNumber(orderId);
                //rest
                double subBegin = headingPosY + 20 + entriesAdded * 10;
                gfx.DrawString(orderId, subFont, XBrushes.Black, new XPoint(10, subBegin));
                gfx.DrawString(internalNumber, subFont, XBrushes.Black, new XPoint(110, subBegin));
                gfx.DrawString(amount, subFont, XBrushes.Black, new XPoint(160, subBegin));
                gfx.DrawString(externalCosts, subFont, XBrushes.Black, new XPoint(240, subBegin));
                gfx.DrawString(externalCostsDiff, subFont, XBrushes.Black, new XPoint(290, subBegin));
                gfx.DrawString(taxesType, subFont, XBrushes.Black, new XPoint(340, subBegin));
                gfx.DrawString(pdfTest, subFont, XBrushes.Black, new XPoint(390, subBegin));
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
                gfx.DrawString("Ko net.", main, XBrushes.Black, new XPoint(240, headingPosY));
                gfx.DrawString("Ko br", main, XBrushes.Black, new XPoint(290, headingPosY));
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
                evaluationsBackMarketPDF.Main();
                double subBegin = headingPosY + 20;
                gfx.DrawString(orderId, subFont, XBrushes.Black, new XPoint(10, subBegin));
                gfx.DrawString(internalNumber, subFont, XBrushes.Black, new XPoint(110, subBegin));
                gfx.DrawString(amount, subFont, XBrushes.Black, new XPoint(160, subBegin));
                gfx.DrawString(externalCosts, subFont, XBrushes.Black, new XPoint(240, subBegin));
                gfx.DrawString(externalCostsDiff, subFont, XBrushes.Black, new XPoint(290, subBegin));
                gfx.DrawString(taxesType, subFont, XBrushes.Black, new XPoint(340, subBegin));
                document.Save(fullPath);
                entriesAdded++;
            }
        }
        public string CalcTaxes(string deviceAmount, string external, string externalDIFF)
        {
            return "";
        }

    }
}
