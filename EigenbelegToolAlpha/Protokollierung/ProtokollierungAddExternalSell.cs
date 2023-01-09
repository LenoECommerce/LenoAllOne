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
    public partial class ProtokollierungAddExternalSell : Form
    {
        public string orderNumberReplacement = "";
        public string internalNumber = "";
        public string imei = "";
        public string month = "";
        public string reference = "";
        public ProtokollierungAddExternalSell()
        {
            InitializeComponent();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            orderNumberReplacement = textBox_invoiceNumber.Text + " " + textBox_amount.Text + "€";
            imei = textBox_IMEI.Text;
            internalNumber = textBox_internalNumber.Text;
            month = comboBox_Months.Text;
            reference = "Extern " + textBox_reference.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
