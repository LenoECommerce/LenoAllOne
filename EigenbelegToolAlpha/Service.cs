using Org.BouncyCastle.Bcpg.OpenPgp;
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
    public partial class Service : Form
    {
        public string preFix = "";
        public Service()
        {
            InitializeComponent();
        }

        private string BuildMessage(string message)
        {
            message = preFix + ",\r\n\r\n" + message;
            return message;
            MessageBox.Show("Die Nachricht wurde erfolgreich kopiert.");
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            preFix = comboBox1.Text;
        }

        private void btn_RemoveFindMyPhoneLock_Click(object sender, EventArgs e)
        {
            string message = BuildMessage("ich wollte gerade das Gerät bearbeiten.\r\nLeider ist es jedoch noch mit der iCloud verbunden und somit noch nicht nutzbar. Bitte wie folgt aus dem Konto entfernen: 1. Auf dem Smartphone auf iCloud.com gehen.  2. Auf „iPhone Suche“ klicken.  3. Das Gerät auswählen.  4. Auf „Aus dem Account entfernen“ klicken (Bitte nicht mit Gerät \"löschen\" verwechseln).\r\nVielen Dank.");
            Clipboard.SetText(message);
        }
    }
}
