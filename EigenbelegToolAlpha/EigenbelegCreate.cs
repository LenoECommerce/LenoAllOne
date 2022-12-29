using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace EigenbelegToolAlpha
{
    public partial class EigenbelegCreate : Form
    {
        public EigenbelegCreate()
        {
            InitializeComponent();

        }
        public int newNumber = 0;
        

        private void button1_Click(object sender, EventArgs e)
        {
            string tempEigenbelegNumber = textBox_eigenbelegNumber.Text;
            string tempSellerName = textBox_eigenbelegSellerName.Text;
            string tempReference = textBox_eigenbelegReference.Text;
            string tempModel = comboBox_eigenbelegeCreateDevice.Text;
            string tempDateBought = textBox_eigenbelegDateBought.Text;
            string tempTransactionAmount = textBox_eigenbelegTransactionAmount.Text;
            string tempMail = textBox_eigenbelegMail.Text;
            string tempPlatform = comboBox_eigenbelegPlatform.Text;
            string tempPaymentMethod = comboBox_eigenbelegPaymentMethod.Text;
            string tempAddress = textBox_eigenbelegAdress.Text;
            string tempCreated = comboBox_eigenbelegCreated.Text;
            string tempArrived = comboBox_eigenbelegArrived.Text;
            string tempEigenbelegStorage = comboBox_eigenbelegStorage.Text;
            string tempTransactionText = "Zahlung für " + tempPlatform + ": " + tempModel + " " + tempEigenbelegStorage;



            string query = string.Format("INSERT INTO `Eigenbelege`(`Eigenbelegnummer`,`Verkaeufername`,`Referenz`,`Modell`,`Kaufdatum`,`Kaufbetrag`,`E-Mail`,`Plattform`,`Zahlungsmethode`,`Adresse`,`Erstellt?`,`Angekommen?`,`Transaktionstext`,`Speicher`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')"
           , tempEigenbelegNumber,tempSellerName,tempReference,tempModel,tempDateBought,tempTransactionAmount,tempMail,tempPlatform,tempPaymentMethod,tempAddress,tempCreated,tempArrived,tempTransactionText, tempEigenbelegStorage);
            CRUDQueries.ExecuteQuery("UPDATE `Config` SET `Nummer` = '" + newNumber + "' WHERE `Typ` = 'Eigenbelegnummer'");
            Eigenbelege.ExecuteQuery(query);
            MessageBox.Show("Dein Eintrag wurde erfolgreich erstellt.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EigenbelegCreate_Load(object sender, EventArgs e)
        {
            newNumber = CRUDQueries.ExecuteQueryWithResult("Config","Nummer","Typ","Eigenbelegnummer") + 1;
            textBox_eigenbelegNumber.Text = newNumber.ToString();
            textBox_eigenbelegDateBought.Text = DateTime.Now.ToString().Substring(0, 10);
            comboBox_eigenbelegArrived.Text = "Ja";
            comboBox_eigenbelegCreated.Text = "Nein";
        }
    

        private void comboBox_eigenbelegPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_eigenbelegPlatform.Text.Equals("BackMarket"))
            {
                comboBox_eigenbelegPaymentMethod.Text = "BuyBack / Lastschrift";
                //BuyBack Preis Kalkulation
                using (var form = new EigenbelegBuyBackPriceCalculation())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string val = form.sumup.ToString() +"€";
                        textBox_eigenbelegTransactionAmount.Text = val;
                    }
                }
            }
            else 
            {
                comboBox_eigenbelegPaymentMethod.Text = "PayPal";
            }

        }

   


        private void textBox_eigenbelegTransactionAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_eigenbelegNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_eigenbelegSellerName_TextChanged(object sender, EventArgs e)
        {
            textBox_eigenbelegAdress.Text = textBox_eigenbelegSellerName.Text;
        }

        private void btn_buybackFillOut_Click(object sender, EventArgs e)
        {
            //using (var form = new EigenbelegCreate())
            //{
            //    var result = form.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        string returnValue = "test";
            //        textBox_eigenbelegSellerName.Text = returnValue;
            //    }
            //}
        }
    }
}
