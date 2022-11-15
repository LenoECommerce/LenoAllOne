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
    public partial class SearchAlgorithm : Form
    {
        public string searchTerm = "";
        public SearchAlgorithm()
        {
            InitializeComponent();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            searchTerm = textBox_SearchTerm.Text;
            this.DialogResult = DialogResult.OK;
        }

        public static bool CheckIfExists(int checkRowValue, string[] array)
        {
            if (array.Contains(checkRowValue.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
