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
    public partial class EigenbelegCreateInputBuyBack : Form
    {
        public string shippingNumber = "";
        public EigenbelegCreateInputBuyBack()
        {
            InitializeComponent();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            shippingNumber = textBox_order.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
