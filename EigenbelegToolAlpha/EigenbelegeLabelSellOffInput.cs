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
        public EigenbelegeLabelSellOffInput()
        {
            InitializeComponent();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            imei = textBox_IMEI.Text;
            DialogResult = DialogResult.OK; 
            this.Close();
        }
    }
}
