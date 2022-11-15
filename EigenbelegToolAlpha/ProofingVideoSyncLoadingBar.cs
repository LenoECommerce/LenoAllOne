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
    public partial class ProofingVideoSyncLoadingBar : Form
    {
        public int filesCountSave = 0;
        public ProofingVideoSyncLoadingBar(int filesCount)
        {
            InitializeComponent();
            filesCountSave = filesCount;
            lbl_foundVideoData.Text = filesCount.ToString();    
        }

        public void ChangeBar(int matchingCount)
        {
            double preSum = Convert.ToDouble(matchingCount) / Convert.ToDouble(filesCountSave)*100;
            progressBar1.Value = Convert.ToInt32(preSum);
        }

        private void ProofingVideoSyncLoadingBar_Load(object sender, EventArgs e)
        {

        }
    }
}
