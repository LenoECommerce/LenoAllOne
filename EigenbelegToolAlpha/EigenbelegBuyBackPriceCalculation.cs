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
    public partial class EigenbelegBuyBackPriceCalculation : Form
    {
        
        public EigenbelegBuyBackPriceCalculation()
        {
            InitializeComponent();
            
        }
        public string price;
        public double sumup;

        
        
        private void textBox_BuyBackPrice_TextChanged(object sender, EventArgs e)
        {
            price = textBox_BuyBackPrice.Text;
        }

        public void GivePrice()
        {
            sumup = Convert.ToInt32(price) + Convert.ToInt32(price) * 0.1 + 9.2;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            GivePrice();
        }
    }
}
