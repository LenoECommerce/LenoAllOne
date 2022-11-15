using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EigenbelegToolAlpha
{
    public partial class FolderInstaCreate : Form
    {
        public FolderInstaCreate()
        {
            InitializeComponent();
        }

        private void btn_folderCreateExecute_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(textBox_minimum.Text);
            int max = Convert.ToInt32(textBox_maximum.Text);
            string createPath = pdfDocument.locationImages;
            int numberOrdersCreated = max-min;
            for (int i = min; i <= max; i++)
            {
                Directory.CreateDirectory(createPath+ @"\"+i);
            }
            MessageBox.Show("Es wurden "+numberOrdersCreated+" Ordner erstellt.");
            this.Hide();
        }
    }
}
