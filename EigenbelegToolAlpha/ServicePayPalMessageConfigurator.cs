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

            string finalText = seller + " trenn Zahlung für Ebay Kleinanzeigen: " + device + " trenn2 " + storage + " trenn3 " + defect + " ansonsten einwandfreier technischer Zustand und ohne jegliche Gerätesperre";
            Clipboard.SetText(finalText);
            MessageBox.Show("Erfolgreich kopiert.");
            this.Hide();
        }
    }
}
