using Microsoft.Office.Interop.Excel;
using Microsoft.Vbe.Interop;
using Org.BouncyCastle.Crypto.Tls;
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
    public partial class B2BEdit : Form
    {
        public B2BEdit()
        {
            InitializeComponent();
        }

        private void B2BEdit_Load(object sender, EventArgs e)
        {
            textBox_Battery.Text = B2B.battery;
            textBox_Defect.Text = B2B.defect;   
            textBox_offerNumber.Text = B2B.offerNumber;
            textBox_Reference.Text = B2B.reference;
            comboBox_Condition.Text = B2B.condition;
            comboBox_iCloud.Text = B2B.icloudLock;
            comboBox_Model.Text = B2B.model;
            comboBox_offerType.Text = B2B.offerType;
            comboBox_Original.Text = B2B.original;
            comboBox_Packaging.Text = B2B.packaging;
            comboBox_Storage.Text = B2B.storage;
            comboBox_Taxing.Text = B2B.taxing;
            textBox_BuyPrice.Text = B2B.buyPrice;
            textBox_SellPrice.Text = B2B.sellPrice;
        }

        private void Btn_Execute_Click(object sender, EventArgs e)
        {
            string offerNumber = textBox_offerNumber.Text;
            string offerType = comboBox_offerType.Text;
            string model = comboBox_Model.Text;
            string reference = textBox_Reference.Text;
            string storage = comboBox_Storage.Text;
            string condition = comboBox_Condition.Text;
            string original = comboBox_Original.Text;
            string defect = textBox_Defect.Text;
            string battery = textBox_Battery.Text;
            string icloud = comboBox_iCloud.Text;
            string packaging = comboBox_Packaging.Text;
            string taxing = comboBox_Taxing.Text;
            string buyprice = textBox_BuyPrice.Text;
            string sellprice = textBox_SellPrice.Text;

            string query = string.Format("UPDATE `B2B` SET `Angebotsnummer` = '{0}',`Angebotsform` = '{1}', `Modell` = '{2}', `Referenz` = '{3}', `Speicher` = '{4}', `Zustand` = '{5}', `Originalitaet` = '{6}', `Defekt` = '{7}', `Akkustand` = '{8}', `iCloud` = '{9}', `OVP?` = '{10}', `Besteuerung` = '{11}', `Ankaufpreis` = '{12}', `Angebotspreis` = '{13}'  WHERE `Id` = {14}"
            , offerNumber, offerType, model, reference, storage, condition, original, defect, battery, icloud, packaging, taxing, buyprice, sellprice, B2B.lastSelectedEntry);
            CRUDQueries.ExecuteQuery(query);
            MessageBox.Show("Deine Änderungen wurden erfolgreich gespeichert.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
