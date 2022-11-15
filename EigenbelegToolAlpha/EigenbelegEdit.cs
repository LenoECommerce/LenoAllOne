using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace EigenbelegToolAlpha
{
    public partial class EigenbelegEdit : Form
    {
        public EigenbelegEdit()
        {
            InitializeComponent();
        }

        private void btn_EigenbelegCreateSaveChanges_Click(object sender, EventArgs e)
        {
            string eigenbelegNumber = textBox_eigenbelegNumber.Text;
            string sellerName = textBox_eigenbelegSellerName.Text;
            string reference = textBox_eigenbelegReference.Text;
            string model = comboBox_eigenbelegeEditDevice.Text;
            string dateBought = textBox_eigenbelegDateBought.Text;
            string transactionAmount = textBox_eigenbelegTransactionAmount.Text;
            string mail = textBox_eigenbelegMail.Text;
            string platform = comboBox_eigenbelegPlatform.Text;
            string paymentMethod = comboBox_eigenbelegPaymentMethod.Text;
            string address = textBox_eigenbelegAdress.Text;
            string created = comboBox_eigenbelegCreated.Text;
            string arrived = comboBox_eigenbelegArrived.Text;
            string transactionText = textBox_eigenbelegTransactionText.Text;
            string storage = comboBox_eigenbelegStorage.Text;

            //Sync mit Reparaturtabelle
            Eigenbelege.dataSync("Reparaturen", model, transactionAmount, storage, eigenbelegNumber);
            string query = string.Format("UPDATE `Eigenbelege` SET `Eigenbelegnummer` = '{0}',`Verkaeufername` = '{1}', `Referenz` = '{2}', `Modell` = '{3}', `Kaufdatum` = '{4}', `Kaufbetrag` = '{5}', `E-Mail` = '{6}', `Plattform` = '{7}', `Zahlungsmethode` = '{8}', `Adresse` = '{9}', `Erstellt?` = '{10}', `Angekommen?` = '{11}', `Transaktionstext` = '{12}', `Speicher` = '{13}' WHERE `Id` = {14}"
                , eigenbelegNumber, sellerName, reference, model, dateBought, transactionAmount, mail, platform, paymentMethod, address, created,
                  arrived, transactionText, storage, Eigenbelege.lastSelectedProductKey);

            Eigenbelege.ExecuteQuery(query);
            MessageBox.Show("Deine Änderungen wurden erfolgreich gespeichert.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EigenbelegEdit_Load(object sender, EventArgs e)
        {
            textBox_eigenbelegAdress.Text = Eigenbelege.address;
            textBox_eigenbelegDateBought.Text = Eigenbelege.dateBought;
            textBox_eigenbelegMail.Text = Eigenbelege.mail;
            comboBox_eigenbelegeEditDevice.Text = Eigenbelege.model;
            textBox_eigenbelegNumber.Text = Eigenbelege.eigenbelegNumber;
            textBox_eigenbelegReference.Text = Eigenbelege.reference;
            textBox_eigenbelegSellerName.Text = Eigenbelege.sellerName;
            comboBox_eigenbelegStorage.Text = Eigenbelege.storage;
            textBox_eigenbelegTransactionAmount.Text = Eigenbelege.transactionAmount;
            textBox_eigenbelegTransactionText.Text = Eigenbelege.transactionText;
            comboBox_eigenbelegArrived.Text = Eigenbelege.arrived;
            comboBox_eigenbelegCreated.Text = Eigenbelege.created;
            comboBox_eigenbelegPaymentMethod.Text = Eigenbelege.paymentMethod;
            comboBox_eigenbelegPlatform.Text = Eigenbelege.platform;
        }
    }
}
