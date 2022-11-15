using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SautinSoft.Document;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Drawing.Layout;



namespace EigenbelegToolAlpha
{
    public class pdfDocument
    {
        public static string paymentMethodPath = "paypal.jpg";
        public static string filename = "";
        public static string locationImages = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "PathImagesEB", "Nutzer", Settings.currentUser);
        public static string savePath = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "PathSaveLocationEB", "Nutzer", Settings.currentUser);

        public static void CreateDocument(string pdfEigenbelegNumber, string pdfSellerName, string pdfDateBought,
             string pdfTransactionAmount, string pdfArticle, string pdfPlatform, string pdfPaymentmethod, string pdfAddress)


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


            //Text schreiben
            // XBrushed means color; xPoint sozusagen X und Y
            // Wichtig!! Position muss absolut sein und nicht dynamisch, mit Algorithmus
            //Drawline: XColor: Code Werte

            gfx.DrawString("Eigenbeleg", heading, XBrushes.Black, new XPoint(100, 100));
            //Vertikale Lines
            gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(180, 120), new XPoint(180, 1000));
            //gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(300, 675), new XPoint(300, 1000));
            //Nr + Betrag
            gfx.DrawString("Nr. "+ pdfEigenbelegNumber, main, XBrushes.Black, new XPoint(100, 150));
            gfx.DrawString("Ausgaben Netto", main, XBrushes.Black, new XPoint(200, 150));
            gfx.DrawString(pdfTransactionAmount, main, XBrushes.Black, new XPoint(400, 150));
            gfx.DrawLine(new XPen(XColor.FromArgb(0,0,0)), new XPoint(0,170), new XPoint(1000,170));
            //Artikel
            gfx.DrawString("Artikel", main, XBrushes.Black, new XPoint(100, 250));

            //Textformatter!!
            XRect rect = new XRect(200, 200, 300, 300);
            gfx.DrawRectangle(XBrushes.AliceBlue, rect);
            tf.DrawString(pdfArticle, subFont, XBrushes.Black, rect, XStringFormats.TopLeft);


            gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(0, 575), new XPoint(1000, 575));
            //Verkäufer
            gfx.DrawString("Verkäufer", main, XBrushes.Black, new XPoint(100, 600));
            gfx.DrawString(pdfAddress, subFont, XBrushes.Black, new XPoint(200, 600));
            gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(0, 625), new XPoint(1000, 625));
            //Grund
            gfx.DrawString("Grund", main, XBrushes.Black, new XPoint(100, 650));
            gfx.DrawString("Kauf von Privatperson auf der Online-Plattform "+pdfPlatform, subFont, XBrushes.Black, new XPoint(200, 650));
            gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(0, 675), new XPoint(1000, 675));
            //Kaufdatum und Unterschrift
            gfx.DrawString("Kaufdatum", main, XBrushes.Black, new XPoint(100, 700));
            gfx.DrawString(pdfDateBought, subFont, XBrushes.Black, new XPoint(200, 700));
            gfx.DrawLine(new XPen(XColor.FromArgb(0, 0, 0)), new XPoint(0, 725), new XPoint(1000, 725));
            gfx.DrawString("Unterschrift", main, XBrushes.Black, new XPoint(100, 750));


            //Bilder!
            string imagePath = Path.GetTempPath();
            imagePath = imagePath + "unterschrift.png";
            if (File.Exists(imagePath) == false)
            {
                Properties.Resources.Unterschrift.Save(imagePath);
            }
            DrawImage(gfx, imagePath, 200, 750, 280, 80);


            try
            {
                //Alle Ordner ausgeben im Hauptspeicherort als Array; Durchsuchung anhand eines bestimmten Ordnername
                var pathOfDir = Directory.GetDirectories(locationImages).Where(Directory => Directory.Contains(pdfEigenbelegNumber)).ToList();
                //Alle Dateien speichern des Belegs; gerade aufm ersten Index, weil es nur ein Ergebnis gibt!
                var filesInDir = Directory.GetFiles(pathOfDir[0]);

                //Schleife die neue Seite erstellt
                for (int i = 0; i < filesInDir.Length; i++)
                {
                    PdfPage pageImage = document.AddPage();
                    XGraphics gfx3 = XGraphics.FromPdfPage(pageImage);
                    DrawImage(gfx3, filesInDir[i], 50, 50, 500, 800);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bei der Bildsuche ist ein Fehler passiert.");
            }    


            filename = "Eigenbeleg" + pdfEigenbelegNumber + "_" + pdfDateBought + "_" + pdfTransactionAmount;
            document.Save(savePath + @"/" + filename + ".pdf");

        }




        //Methode für Bildererstellung
        public static void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            if (File.Exists(jpegSamplePath)==false)
            {
                MessageBox.Show("Für den Pfad "+jpegSamplePath+" wurde keine Datei gefunden.");
                return;
            }
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }

        



    }
}
