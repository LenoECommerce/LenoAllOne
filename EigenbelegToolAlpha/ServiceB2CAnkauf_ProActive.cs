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
    public partial class ServiceB2CAnkauf_ProActive : Form
    {
        public ServiceB2CAnkauf_ProActive()
        {
            InitializeComponent();
        }

        private void btn_GetBack_Click(object sender, EventArgs e)
        {
            Service window = new Service();
            window.Show();
            this.Close();
        }

        private void ServiceB2CAnkauf_ProActive_Load(object sender, EventArgs e)
        {

        }

        private void Btn_FirstRequest_Click(object sender, EventArgs e)
        {
            ServiceB2CAnkauf_ProActive_FirstRequest window = new ServiceB2CAnkauf_ProActive_FirstRequest();
            window.Show();
            this.Close();
        }

        private void Btn_Feedback_Click(object sender, EventArgs e)
        {
            ServiceB2CAnkauf_ProActive_ReachBack window = new ServiceB2CAnkauf_ProActive_ReachBack();
            window.Show();
            this.Close();
        }

        private void Btn_CommonQuestions_Click(object sender, EventArgs e)
        {
            ServiceB2CAnkauf_Questions window = new ServiceB2CAnkauf_Questions();
            window.Show();
            this.Close();
        }
    }
}
