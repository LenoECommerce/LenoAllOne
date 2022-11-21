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
    public partial class ServiceB2CAnkauf_Selection : Form
    {
        public ServiceB2CAnkauf_Selection()
        {
            InitializeComponent();
        }

        private void Btn_B2CAnkauf_ProActive_Click(object sender, EventArgs e)
        {
            ServiceB2CAnkauf_ProActive window = new ServiceB2CAnkauf_ProActive();
            this.Hide();
            window.Show();
            Service obj = (Service)Application.OpenForms["Service"];
            obj.Close();
        }

        private void Btn_B2CAnkauf_Request_Click(object sender, EventArgs e)
        {
            ServiceB2CAnkauf_ProActive_FirstRequest window = new ServiceB2CAnkauf_ProActive_FirstRequest();
            this.Hide();
            window.Show();
            Service obj = (Service)Application.OpenForms["Service"];
            obj.Close();
        }

        private void Btn_ContactProblem_Click(object sender, EventArgs e)
        {
            ServiceB2CAnkauf_ProblemContact window = new ServiceB2CAnkauf_ProblemContact();
            window.Show();
        }
    }
}
