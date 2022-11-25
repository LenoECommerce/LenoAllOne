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
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
        public void Main ()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //New document
            PdfDocument document = new PdfDocument();
            //New pages
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont heading = new XFont("Arial", 20);
            XFont main = new XFont("Arial", 14);
            XFont subFont = new XFont("Arial", 11);
            XTextFormatter tf = new XTextFormatter(gfx);

            //Zeilenüberschriften
            gfx.DrawString("Orderübersicht", main, XBrushes.Black, new XPoint(10 , 10));
            gfx.DrawString("Bestellnummer", main, XBrushes.Black, new XPoint(10, 30));
            gfx.DrawString("Intern", main, XBrushes.Black, new XPoint(110, 30));
            gfx.DrawString("Kaufbetrag", main, XBrushes.Black, new XPoint(160, 30));
            gfx.DrawString("Ko net.", main, XBrushes.Black, new XPoint(240, 30));
            gfx.DrawString("Ko br", main, XBrushes.Black, new XPoint(290, 30));
            gfx.DrawString("Bst.", main, XBrushes.Black, new XPoint(340, 30));
            gfx.DrawString("Steuern", main, XBrushes.Black, new XPoint(390, 30));


            //Vertikale Line
            gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(180, 120), new XPoint(180, 1000));

            document.Save(desktopPath+"test.pdf");
        }
    }
}
