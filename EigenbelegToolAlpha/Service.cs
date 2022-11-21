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
using System.IO;

namespace EigenbelegToolAlpha
{
    public partial class Service : Form
    {
        public string preFix = "";
        public static string user = ReturnSuffix();
        public Service()
        {
            InitializeComponent();
        }

        private void BuildMessage(string message)
        {
            message = preFix + ",\r\n\r\n" + message + "\r\n\r\nBei weiteren Rückfragen stehe ich Ihnen gerne jederzeit zur Verfügung.\r\n\r\nMfG " + user+" von Leno Repair";
            MessageBox.Show("Die Nachricht wurde erfolgreich kopiert.");
            Clipboard.SetText(message);
        }
       
        private static string ReturnSuffix ()
        {
            string user = File.ReadAllText(Environment.CurrentDirectory + @"\user.txt");
            if (user.Contains("Noah"))
            {
                user = "Noah";
            }
            else if (user.Contains("Lennart"))
            {
                user = "Lennart";
            }
            return user;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            preFix = comboBox1.Text;
        }

        private void btn_RemoveFindMyPhoneLock_Click(object sender, EventArgs e)
        {
            BuildMessage("leider ist es jedoch noch mit der iCloud verbunden und somit noch nicht nutzbar. Bitte wie folgt aus dem Konto entfernen: 1. Auf dem Smartphone auf iCloud.com gehen.  2. Auf „iPhone Suche“ klicken.  3. Das Gerät auswählen.  4. Auf „Aus dem Account entfernen“ klicken (Bitte nicht mit Gerät \"löschen\" verwechseln).\r\nVielen Dank.");
        }

        private void btn_PayPalMessageConfigurator_Click(object sender, EventArgs e)
        {
            ServicePayPalMessageConfigurator window = new ServicePayPalMessageConfigurator();
            window.Show();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eigenbelege window = new Eigenbelege();
            window.Show();
            this.Hide();
        }

        private void eigenbelegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reparaturen window = new Reparaturen();
            window.Show();
            this.Hide();
        }

        private void protokollierungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Protokollierung window = new Protokollierung();
            window.Show();
            this.Hide();
        }

        private void proofingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proofing window = new Proofing();
            window.Show();
            this.Hide();
        }

        private void Service_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Trustpilot_Click(object sender, EventArgs e)
        {
            BuildMessage("ich melde mich nochmal wegen der netten & problemlosen Abwicklung mit Ihnen.\r\nWir würden uns sehr freuen, wenn Sie unserem Ebay Kleinanzeigen Account folgen und uns in Zukunft kontaktieren, wenn Sie aus dem Bekanntenkreis oder von Freunden von einem (teil)defekten iPhone mitbekommen. Für jegliche Angebote sind wir jederzeit verfügbar.\r\n\r\nWir bieten seit neusten übrigens auch hochqualitative Reparaturen für Apple und Samsung Geräte an. Hier finden Sie unsere Website: [https://leno-repair.de/](https://leno-repair.de/)\r\n\r\nWenn Sie mit der Abwicklung ebenso zufrieden waren, würden wir uns sehr über eine Trustpilot Bewertung freuen:\r\n[https://www.trustpilot.com/review/leno-ecommerce.de](https://www.trustpilot.com/review/leno-ecommerce.de)\r\nEs dauert keine 2 Minuten und Sie würden uns damit sehr unterstützen!");
        }

        private void Btn_B2CAnkauf_Click(object sender, EventArgs e)
        {
            ServiceB2CAnkauf_Selection window = new ServiceB2CAnkauf_Selection();
            window.Show();
        }

        private void Btn_EbayPurchaseMessage_Click(object sender, EventArgs e)
        {
            BuildMessage("könnten Sie bitte die Bestellnummer auf die Außenseiten des Pakets schreiben, damit es bei Ankunft besser zuordnen. \r\nDas würde mich sehr freuen.\r\nDankeschön!");
        }
    }
}
