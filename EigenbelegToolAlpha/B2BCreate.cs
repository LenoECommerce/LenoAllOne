using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EigenbelegToolAlpha
{
    public partial class B2BCreate : Form
    {
        public int newNumber;
        public B2BCreate()
        {
            InitializeComponent();
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

            string query = string.Format("INSERT INTO `B2B`(`Angebotsnummer`,`Angebotsform`,`Modell`,`Ankaufpreis`,`Angebotspreis`,`Referenz`,`Speicher`,`Zustand`,`Originalitaet`,`Defekt`,`Akkustand`,`iCloud`,`OVP?`,`Besteuerung`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')"
            , offerNumber, offerType, model, buyprice, sellprice, reference, storage, condition, original, defect, battery, icloud, packaging, taxing);
            CRUDQueries.ExecuteQuery("UPDATE `Config` SET `Nummer` = '" + newNumber + "' WHERE `Typ` = 'B2BNumber'");
            CRUDQueries.ExecuteQuery(query);
            MessageBox.Show("Dein Eintrag wurde erfolgreich erstellt.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void B2BCreate_Load(object sender, EventArgs e)
        {
            newNumber = CRUDQueries.ExecuteQueryWithResult("Config", "Nummer", "Typ", "B2BNumber") + 1;
            textBox_offerNumber.Text = newNumber.ToString();
        }
    }
}
