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
    public partial class ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedback : Form
    {
        public ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedback()
        {
            InitializeComponent();
        }

        private void Btn_AllinfosThere_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Vielen Dank für die nette Rückmeldung. Ich würde dann sehr gerne per PayPal zahlen, wäre das möglich? Ansonsten würde auch normal per Ebay Kleinanzeigen funktionieren, dort sind allerdings die Gebühren höher.\r\n\r\nBei Rückfragen stehe ich Ihnen sehr gerne jederzeit zur Verfügung.\r\nMit freundlichen Grüßen\r\nLennart Aufermann von Leno Repair");
            MessageBox.Show("Nachricht erfolgreich kopiert.");
            this.Close();
        }

        private void Btn_MissingInformation_Click(object sender, EventArgs e)
        {
            ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedbackMissingInformation window = new ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedbackMissingInformation();
            window.Show();
            this.Close();
        }
    }
}
