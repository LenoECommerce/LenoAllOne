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

namespace EigenbelegToolAlpha
{
    public partial class ReparaturCreate : Form
    {
        public int tempNumber = 0;
        public ReparaturCreate()
        {
            InitializeComponent();
        }

        private void ReparaturCreate_Load(object sender, EventArgs e)
        {
            tempNumber = CRUDQueries.ExecuteQueryWithResult("Config", "Nummer", "Typ", "InterneNummer") + 1;
            textBox_ReparaturenInternalNumber.Text = tempNumber.ToString();
            comboBox_ReparaturenReparaturStatus.Text = "Entgegengenommen";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tempInternalNumber = textBox_ReparaturenInternalNumber.Text;
            string tempDateBought = textBox_reparaturenDateBought.Text;
            string tempDevice = comboBox_reparaturenCreateDevice.Text;
            string tempTransactionAmount = textBox_reparaturenTransactionAmount.Text;
            string tempMake = "";
            string tempStorage = comboBox__reparaturenStorage.Text;
            string tempDefect = textBox__reparaturenDefect.Text;
            string tempImei = textBox__reparaturenIMEI.Text;
            string tempExternalCosts = textBox_reparaturenExternalCosts.Text;
            string tempComment = textBox_reparaturenComment.Text;
            string tempNotifications = textBox_reparaturenComment.Text;
            string tempTested = comboBox_ReparaturenGetestet.Text;
            string tempStatus = comboBox_ReparaturenReparaturStatus.Text;
            string tempSource = textBox_reparaturenSource.Text;
            string tempRiskLevel = textBox_reparaturenRiskLevel.Text;
            string tempWorthIt = textBox_reparaturenWorthIt.Text;
            string tempReferenceToEB = textBox_reparaturenReferenceToEB.Text;
            string tempColor = comboBox_ReparaturCreateColor.Text;
            string tempTaxes = comboBox_ReparaturCreateTaxes.Text;
            string tempCondition = comboBox_ReparaturCreateCondition.Text;
            if (comboBox_SamsungDevices.Text != "")
            {
                tempMake = comboBox_SamsungDevices.Text;
            }
            else if (comboBox_reparaturenCreateDevice.Text != "")
            {
                tempMake = comboBox_reparaturenCreateDevice.Text;
            }

            string query = string.Format("INSERT INTO `Reparaturen`(`Intern`,`Kaufdatum`,`Geraet`,`Kaufbetrag`,`IMEI`,`Marke`,`Speicher`,`Defekt`,`ExterneKosten`,`Kommentar`,`Meldungen?`,`Getestet?`,`Reparaturstatus`,`Quelle`,`Risikostufe`,`LohntSich?`,`EBReferenz`,`Farbe`,`Besteuerung`,`Zustand`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}')"
            , tempInternalNumber, tempDateBought, tempDevice, tempTransactionAmount, tempImei, tempMake, tempStorage, tempDefect, tempExternalCosts, tempComment, tempNotifications, tempTested, tempStatus, tempSource, tempRiskLevel, tempWorthIt, tempReferenceToEB, tempColor, tempTaxes, tempCondition);

            Reparaturen.ExecuteQuery(query);
            CRUDQueries.ExecuteQuery("UPDATE `Config` SET `Nummer` = '" + tempNumber + "' WHERE `Typ` = 'InterneNummer'");
            MessageBox.Show("Dein Eintrag wurde erfolgreich erstellt.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox_reparaturenTransactionAmount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Apple")
            {
                comboBox_reparaturenCreateDevice.Visible = true;
                comboBox_SamsungDevices.Visible = false;
            }
            else if (comboBox1.Text == "Samsung")
            {
                comboBox_reparaturenCreateDevice.Visible = false;
                comboBox_SamsungDevices.Visible = true;
            }
        }

        private void comboBox_ReparaturCreateColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_FiveG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
