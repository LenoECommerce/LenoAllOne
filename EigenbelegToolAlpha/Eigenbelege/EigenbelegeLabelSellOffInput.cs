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
    public partial class EigenbelegeLabelSellOffInput : Form
    {
        public string imei = "";
        public string condition = "";
        public int quantity = 0;

        public EigenbelegeLabelSellOffInput()
        {
            InitializeComponent();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            imei = textBox_IMEI.Text;
            condition = comboBox_condition.Text;
            quantity = Convert.ToInt32(comboBox_quantity.Text);
            DialogResult = DialogResult.OK; 
            this.Close();
        }
    }
}
