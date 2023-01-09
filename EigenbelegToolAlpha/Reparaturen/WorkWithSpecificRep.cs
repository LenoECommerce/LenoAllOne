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
    public partial class WorkWithSpecificRep : Form
    {
        public WorkWithSpecificRep()
        {
            InitializeComponent();
        }

        public string searchValue = "";
        public string matchingValue = "";

        private void btn_Executre_Click(object sender, EventArgs e)
        {
            int length = searchValue.Length-6;

            matchingValue = searchValue.Substring(6, length);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchValue = textBox1.Text;
        }
    }
}
