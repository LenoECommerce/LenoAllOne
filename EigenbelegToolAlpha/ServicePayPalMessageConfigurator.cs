using ExcelLibrary.BinaryFileFormat;
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
    public partial class ServicePayPalMessageConfigurator : Form
    {
        public ServicePayPalMessageConfigurator()
        {
            InitializeComponent();
        }

        private void Btn_Execute_Click(object sender, EventArgs e)
        {
            string seller = textBox_SellerName.Text;
            string device = comboBox_Model.Text;
            string storage = comboBox_Storage.Text;
            string defect = textBox_Defect.Text;
            if (checkBox_IsItFromTheSellingOffer.Checked == true)
            {
                seller = seller + " Ankaufanzeige";
            }
            if (checkBox_iCloudLock.Checked == true)
            {
                defect = defect + "iCloud Sperre";
            }
            if (checkBox_IsThereDefect.Checked != true)
            {
                defect = "nichts";
            }
            if (defect != "")
            {
                defect = defect + " defekt";
            }
            string finalText = seller + " trenn Zahlung für Ebay Kleinanzeigen: " + device + " trenn2 " + storage + " trenn3 " + defect + " ansonsten einwandfreier technischer Zustand und ohne jegliche Gerätesperre";
            Clipboard.SetText(finalText);
            MessageBox.Show("Erfolgreich kopiert.");
            this.Hide();
        }

        private void checkBox_IsThereDefect_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_IsThereDefect.Checked == true)
            {
                textBox_Defect.Visible = true;
            }
        }
    }
}
