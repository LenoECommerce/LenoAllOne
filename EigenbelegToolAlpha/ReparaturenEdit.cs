using Google.Protobuf.WellKnownTypes;
using Microsoft.Office.Interop.Excel;
using Org.BouncyCastle.Asn1.Utilities;
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
    public partial class ReparaturenEdit : Form
    {
        public ReparaturenEdit()
        {
            InitializeComponent();
        }
        public string donorMonth = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string internalNumber = textBox_ReparaturenInternalNumber.Text;
            string dateBought = textBox_reparaturenDateBought.Text;
            string device = "";
            string make = comboBox_reparaturenMake.Text;
            string storage = comboBox__reparaturenStorage.Text;
            string defect = textBox__reparaturenDefect.Text;
            string transactionAmount = textBox_reparaturenTransactionAmount.Text;
            string imei = textBox__reparaturenIMEI.Text;
            string externalCosts = textBox_reparaturenExternalCosts.Text;
            string comment = textBox_reparaturenComment.Text;
            string source = textBox_reparaturenSource.Text;
            string riskLevel = textBox_reparaturenRiskLevel.Text;
            string worthIt = textBox_reparaturenWorthIt.Text;
            string referenceToEB = textBox_reparaturenReferenceToEB.Text;
            string notifications = comboBox_ReparaturenMeldungen.Text;
            string tested = comboBox_ReparaturenGetestet.Text;
            string state = comboBox_ReparaturenReparaturStatus.Text;
            string maindefects = "";
            string color = comboBox_ReparaturEditColor.Text;
            string condition = comboBox_ReparaturEditCondition.Text;
            string taxes = comboBox_ReparaturEditTaxes.Text;
            string fiveG = comboBox_FiveG.Text;

            if (comboBox_SamsungDevices.Text != "")
            {
                device = comboBox_SamsungDevices.Text;
            }
            else if (comboBox_reparaturenEditDevice.Text != "")
            {
                device = comboBox_reparaturenEditDevice.Text;
            }

            //Speichern der Elemente in der Listbox Maindefekte
            foreach (object items in listBox_ReparaturenEditMainParts.SelectedItems)
            {
                maindefects += items + ";";
            }


            try
            {
                //Datasync
                Eigenbelege.dataSync("Eigenbelege", device, transactionAmount, storage, referenceToEB);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Fülle folgende Felder unbedingt aus: Modell, Betrag, Speicher und Referenz.");
            }
            finally
            {
                try
                {
                    string query = string.Format("UPDATE `Reparaturen` SET `Intern` = '{0}',`Kaufdatum` = '{1}', `Geraet` = '{2}', `Kaufbetrag` = '{3}', `IMEI` = '{4}', `Marke` = '{5}', `Speicher` = '{6}', `Defekt` = '{7}', `ExterneKosten` = '{8}', `Kommentar` = '{9}', `Meldungen?` = '{10}', `Getestet?` = '{11}', `Reparaturstatus` = '{12}', `Quelle` = '{13}', `Risikostufe` = '{14}', `LohntSich?` = '{15}', `EBReferenz` = '{16}' , `Hauptteile` = '{17}', `Farbe` = '{18}', `Besteuerung` = '{19}', `Zustand` = '{20}', `Spendermonat` = '{21}', `5G` = '{22}' WHERE `Id` = {23}"
                , internalNumber, dateBought, device, transactionAmount, imei, make, storage, defect, externalCosts, comment, notifications, tested, state, source, riskLevel, worthIt, referenceToEB, maindefects, color, taxes, condition, donorMonth, fiveG, Reparaturen.lastSelectedProductKey);
                    Reparaturen.ExecuteQuery(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Deine Änderungen wurden erfolgreich gespeichert.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void ReparaturenEdit_Load(object sender, EventArgs e)
        {
            textBox_ReparaturenInternalNumber.Text = Reparaturen.internalNumber;
            textBox_reparaturenDateBought.Text = Reparaturen.dateBought;
            comboBox_reparaturenMake.Text = Reparaturen.make;
            comboBox__reparaturenStorage.Text = Reparaturen.storage;
            textBox__reparaturenDefect.Text = Reparaturen.defect;
            textBox_reparaturenTransactionAmount.Text = Reparaturen.transactionAmount;
            textBox__reparaturenIMEI.Text = Reparaturen.imei;
            textBox_reparaturenExternalCosts.Text = Reparaturen.externalCosts;
            textBox_reparaturenComment.Text = Reparaturen.comment;
            textBox_reparaturenSource.Text = Reparaturen.source;
            textBox_reparaturenRiskLevel.Text = Reparaturen.riskLevel;
            textBox_reparaturenWorthIt.Text = Reparaturen.worthIt;
            textBox_reparaturenReferenceToEB.Text = Reparaturen.referenceToEB;
            comboBox_ReparaturenGetestet.Text = Reparaturen.tested;
            comboBox_ReparaturenMeldungen.Text = Reparaturen.notifications;
            comboBox_ReparaturenReparaturStatus.Text = Reparaturen.state;
            comboBox_ReparaturEditColor.Text = Reparaturen.color;
            comboBox_ReparaturEditTaxes.Text = Reparaturen.taxes;
            comboBox_ReparaturEditCondition.Text = Reparaturen.condition;
            lbl_donorMonth.Text = Reparaturen.donorMonth;
            comboBox_FiveG.Text = Reparaturen.fiveG;

            string tempCheckDevice = Reparaturen.device;
            if (comboBox_reparaturenEditDevice.Items.Contains(tempCheckDevice))
            {
                comboBox_reparaturenEditDevice.Text = tempCheckDevice;
            }
            else if (comboBox_SamsungDevices.Items.Contains(tempCheckDevice))
            {
                comboBox_SamsungDevices.Text = tempCheckDevice;
            }

            //check if device value is given and modify the visibility
            if (comboBox_SamsungDevices.Text != "")
            {
                comboBox_SamsungDevices.Visible = true;
            }
            else if (comboBox_reparaturenEditDevice.Text != "")
            {
                comboBox_reparaturenEditDevice.Visible = true;
            }


            //Externe Kosten Feld nicht leer lassen, da sonst Fehlermeldung bei Kosten hinzufügen.
            if (textBox_reparaturenExternalCosts.Text.Equals(""))
            {
                textBox_reparaturenExternalCosts.Text = "0€";
            }


            //Umständlich gebaut aber ja
            if (Reparaturen.maindefects.Contains("Display"))
            {
                listBox_ReparaturenEditMainParts.SelectedIndex = listBox_ReparaturenEditMainParts.FindString("Display");
            }
            if (Reparaturen.maindefects.Contains("Akku"))
            {
                listBox_ReparaturenEditMainParts.SelectedIndex = listBox_ReparaturenEditMainParts.FindString("Akku");
            }
            if (Reparaturen.maindefects.Contains("Display Glas"))
            {
                listBox_ReparaturenEditMainParts.SelectedIndex = listBox_ReparaturenEditMainParts.FindString("Display Glas");
            }
            if (Reparaturen.maindefects.Contains("BC Glas"))
            {
                listBox_ReparaturenEditMainParts.SelectedIndex = listBox_ReparaturenEditMainParts.FindString("BC Glas");
            }
            if (Reparaturen.maindefects.Contains("BC komplett"))
            {
                listBox_ReparaturenEditMainParts.SelectedIndex = listBox_ReparaturenEditMainParts.FindString("BC komplett");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double price = 0;
            double currentValue;
            double sumValue;

            foreach (object items in listBox_ReparaturenEditMainParts.SelectedItems)
            {
                string mainpart = items.ToString();
                string modelInput = comboBox_reparaturenEditDevice.Text;
                //Zerteilung zu Modell
                var length = modelInput.Length;
                string model = modelInput.Substring(7,length-7);
                string query2 = "SELECT `Display` FROM `Ersatzteile` WHERE `Modell` = '6S'";
                string query = "SELECT `" + mainpart + "` FROM `Ersatzteile` WHERE `Modell` = '" + model + "'";
                double newValue = Reparaturen.ExecuteQueryWithResult(query);
                if (newValue != 0)
                {
                    price = price + newValue;
                }
            }
            MessageBox.Show(price.ToString() + " wurden zu den externen Kosten hinzugefügt.");
            //Unterscheidung, ob im Textfeld ein € Zeichen ist
            if (textBox_reparaturenExternalCosts.Text.Contains("€"))
            {
                var actualLength = textBox_reparaturenExternalCosts.TextLength;
                var fixedField = textBox_reparaturenExternalCosts.Text.Substring(0, actualLength - 1);
                currentValue = Convert.ToDouble(fixedField);
                sumValue = currentValue += price;
                textBox_reparaturenExternalCosts.Text = sumValue.ToString() + "€";
            }
            else
            {
                //Momentanen Wert festhalten in Textbox
                currentValue = Convert.ToDouble(textBox_reparaturenExternalCosts.Text);
                sumValue = currentValue += price;
                textBox_reparaturenExternalCosts.Text = sumValue.ToString() + "€";
            }

        }

        private void btn_reparaturenAddNewExternalCosts_Click(object sender, EventArgs e)
        {
            //Unterscheidung, ob im Textfeld ein € Zeichen ist
            double currentValue;
            double sumValue;
            double newCosts = Convert.ToDouble(textBox_ReparaturEditAddNewExternalCosts.Text);
            if (textBox_reparaturenExternalCosts.Text.Contains("€"))
            {
                var actualLength = textBox_reparaturenExternalCosts.TextLength;
                var fixedField = textBox_reparaturenExternalCosts.Text.Substring(0, actualLength - 1);
                currentValue = Convert.ToDouble(fixedField);
                sumValue = currentValue + newCosts;
                textBox_reparaturenExternalCosts.Text = sumValue.ToString() + "€";
            }
            else
            {
                //Momentanen Wert festhalten in Textbox
                currentValue = Convert.ToDouble(textBox_reparaturenExternalCosts.Text);
                sumValue = currentValue + newCosts;
                textBox_reparaturenExternalCosts.Text = sumValue.ToString() + "€";
            }
            textBox_ReparaturEditAddNewExternalCosts.Text = "";
            MessageBox.Show("Es wurden " + newCosts + "€ hinzugefügt");
        }

        private void comboBox_reparaturenColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox__reparaturenStorage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_reparaturenMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_reparaturenMake.Text == "Apple")
            {
                comboBox_reparaturenEditDevice.Visible = true;
                comboBox_SamsungDevices.Visible = false;
            }
            else if (comboBox_reparaturenMake.Text == "Samsung")
            {
                comboBox_reparaturenEditDevice.Visible = false;
                comboBox_SamsungDevices.Visible = true;
                label25.Visible = true;
                comboBox_FiveG.Visible = true;
            }
        }

        private void textBox_reparaturenReferenceToEB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_reparaturenWorthIt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_reparaturenRiskLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_reparaturenSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_reparaturenComment_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_reparaturenExternalCosts_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox__reparaturenIMEI_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_reparaturenTransactionAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox__reparaturenDefect_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_reparaturenDevice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_reparaturenDateBought_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ReparaturenInternalNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox_ReparaturenEditMainParts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Dictionary<string, string> monthOverview = new Dictionary<string, string>
        {
            { "01", "Januar" },
            { "02", "Februar" },
            { "03", "März" },
            { "04", "April" },
            { "05", "Mai" },
            { "06", "Juni" },
            { "07", "Juli" },
            { "08", "August" },
            { "09", "September" },
            { "10", "Oktober" },
            { "11", "November" },
            { "12", "Dezember" },
        };
        private void comboBox_ReparaturenReparaturStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ReparaturenReparaturStatus.Text == "Spender")
            {
                string currentMonth = DateTime.Now.ToString().Substring(3,2);
                donorMonth = monthOverview[currentMonth];
                lbl_donorMonth.Text = donorMonth;
            }
        }
    }
}
