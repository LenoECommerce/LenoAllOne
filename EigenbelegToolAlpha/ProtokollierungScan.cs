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
    public partial class ProtokollierungScan : Form
    {
        public string scanInput = "";
        public string orderIDInput = "";
        public ProtokollierungScan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scanInput = textBox_scanField.Text;
            orderIDInput = textBox_orderID.Text;
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void textBox_scanField_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
