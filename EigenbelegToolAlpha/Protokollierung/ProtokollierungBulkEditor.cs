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
    public partial class ProtokollierungBulkEditor : Form
    {
        public string selectedMonth = "";
        public ProtokollierungBulkEditor()
        {
            InitializeComponent();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            selectedMonth = comboBox_Months.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Hide();

        }
    }
}
