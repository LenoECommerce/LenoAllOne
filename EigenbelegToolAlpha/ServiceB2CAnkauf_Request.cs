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
    public partial class ServiceB2CAnkauf_Request : Form
    {
        public ServiceB2CAnkauf_Request()
        {
            InitializeComponent();
        }

        private void btn_GetBack_Click(object sender, EventArgs e)
        {
            Service window = new Service();
            window.Show();
            this.Close();   
        }
    }
}
