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
using Barcode = BarcodeLib.Barcode;
using PdfReader = PdfSharp.Pdf.IO.PdfReader;
using PdfPage = PdfSharp.Pdf.PdfPage;
using Org.BouncyCastle.Asn1.Pkcs;
using System.Threading;

namespace EigenbelegToolAlpha
{
    public class MergeShippingDocuments
    {
        public static string folderPath = "";
        public static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
        public string savePath = desktopPath + "output.pdf";
        public string barcodePath = folderPath + "barcode";
        public string text = "";
        public int counter = 0;
        public string[] languages = new string[8] {"Pedido n° ","Bestellnr. ","Ordine n° ","Order no. ","Tilausnumero ", "N.º de encomenda ", "Commande n°", "Bestelnr. " };

        public MergeShippingDocuments(string folderValue)
        {
            folderPath = folderValue;
            MainAlgorithm();
            GoogleDrive drive = new GoogleDrive(savePath, "pdf");
            MessageBox.Show("Datei wurde erfolgreich hochgeladen.");
            DeleteFiles();
        }

        public async void MainAlgorithm()
        {
            try
            {
                string[] filesInDir = Directory.GetFiles(folderPath);
                ModifyFiles(filesInDir);
                filesInDir = Directory.GetFiles(folderPath);
                MergeFiles(filesInDir);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void DeleteFiles()
        {
            File.Delete(savePath);
        }
        public void ModifyFiles(string[] files)
        {
            foreach (var item in files)
            {
                if (ClassifyFile(item) == true)
                {
                    string orderID = FindOrderId(text);
                    AddBarcode(orderID);
                    PdfDocument document = PdfReader.Open(item,PdfDocumentOpenMode.Modify);
                    PdfPage page = document.Pages[0];
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XImage image = XImage.FromFile(barcodePath + counter + ".png");
                    gfx.DrawImage(image, 400, 50, 205, 26);
                    document.Save(folderPath+ @"\test"+counter.ToString()+".pdf");
                    File.Delete(item);
                }
            }
            //File.Delete(barcodePath);
        }

        public bool ClassifyFile(string file)
        {
            text = ExtractText(file);
            if (text.Contains("Back Market"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddBarcode(string rawData)
        {
            Barcode barcode = new Barcode();
            Image img = barcode.Encode(BarcodeLib.TYPE.CODE128, rawData, 205, 26);
            img.Save(barcodePath+counter+".png");
   
        }
        public string ExtractText (string filePath)
        {
            string text = Extractor.PdfToText(filePath);
            return text;
        }
        public string FindOrderId(string searchText)
        {
            string orderID = "";
            foreach (var item in languages)
            {
                if (searchText.Contains(item))
                {
                    var pos = searchText.IndexOf(item);
                    orderID = searchText.Substring(pos + item.Length, 8);
                    counter++;
                }
            }
            return orderID;
        }

        public void MergeFiles(string[] files)
        {
            PdfDocument document = new PdfDocument();
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
            document.Save(savePath);
        }
    }
}
