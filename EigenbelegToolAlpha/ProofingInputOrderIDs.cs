using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EigenbelegToolAlpha
{
    public partial class ProofingInputOrderIDs : Form
    {
        public ProofingInputOrderIDs()
        {
            InitializeComponent();
        }
        public string[] columns = new string [6] {"Order ID","Intern","IMEI","Aesthetic condition before delivery","Technical Certificate", "Additional Information" };
        public string[] collectedIMEI = new string[100];
        public string[] collectedVideoLink = new string[100];
        public string[] collectedTechnicalCertificate = new string[100];
        string[] matchingInternalNumbers = new string[100];
        string[] orderIds = new string[100];
        public int elementCounter = 0;
        private void btn_Execute_Click(object sender, EventArgs e)
        {
            string input = textBox_Input.Text;
            int countComma = input.Count(f => f == ',');
            //Create array of input
            for (int i = 0; i <= countComma;)
            {
                if (input.Length >= 1)
                {
                    var posFirst = input.IndexOf(",");
                    var fullLength = input.Length;
                    if (posFirst==-1)
                    {
                        posFirst = fullLength;
                    }
                    orderIds[i] = input.Substring(0, posFirst);
                    if (posFirst != fullLength)
                    {
                        input = input.Substring(posFirst + 1, fullLength - posFirst - 1);
                    }
                    i++;
                }

            }
            //Find the matching internal numbers from the order ids
            int counter = 0;
            foreach (var item in orderIds)
            {
                if (item != null)
                {
                    var getInternal = CRUDQueries.ExecuteQueryWithResultString("Protokollierung", "Intern", "Bestellnummer",item.ToString());
                    matchingInternalNumbers[counter] = getInternal.ToString();
                    counter++;
                }
            }
            //Get the proofing data via internal number
            Proofing proof = new Proofing();
            foreach (var item in matchingInternalNumbers)
            {
                if (item != null)
                {
                    string getIMEI = CRUDQueries.ExecuteQueryWithResultString("Proofing", "IMEI", "Intern", item.ToString());
                    string getNsys = CRUDQueries.ExecuteQueryWithResultString("Proofing", "NSYS-Zertifikat", "Intern", item.ToString());
                    string getVideoLink = CRUDQueries.ExecuteQueryWithResultString("Proofing", "Video", "Intern", item.ToString());
                    collectedIMEI[elementCounter] = getIMEI;
                    collectedTechnicalCertificate[elementCounter] = getNsys;
                    collectedVideoLink[elementCounter] = getVideoLink;
                    elementCounter++;

                }
            }
            //revert the order of ArrayOrderID
            int counterNewArray = 0;
            string[] newOrderIds = new string[100];
            for (int i = 50; i >= 0; i--)
            {
                if (orderIds[i] != null)
                {
                    newOrderIds[counterNewArray] = orderIds[i];
                    counterNewArray++;
                }
            }
            ExcelManager.CreateNewExcelFileCommissionRefund("BM Commission Refund Request", columns, elementCounter,newOrderIds,matchingInternalNumbers,collectedIMEI,collectedVideoLink,collectedTechnicalCertificate);
            MessageBox.Show("Deine Excel Datei wurde erfolgreich erstellt.");
        }
    }
}
