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
    public partial class ServiceB2CAnkauf_ProActive_ReachBack : Form
    {
        public ServiceB2CAnkauf_ProActive_ReachBack()
        {
            InitializeComponent();
        }

        private void BuildMessage(string messageValue)
        { 
            Clipboard.SetText(messageValue+ "\r\n\r\nBei Rückfragen stehe ich Ihnen sehr gerne jederzeit zur Verfügung.\r\nMfG Lennart von Leno Repair");
            MessageBox.Show("Die Nachricht wurde erfolgreich kopiert.");
        }
        private void ServiceB2CAnkauf_ProActive_ReachBack_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Reserve_Click(object sender, EventArgs e)
        {
            BuildMessage("Das wäre super nett, ich würde mich sehr freuen, wenn Sie so lieb wären und die Anzeige so lange als reserviert einstellen würden, damit Sie nicht von unseriösen Anfragen zubombardiert werden, wenn Sie verstehen was ich meine.");
        }

        private void Btn_NoUnsafePaymentMethods_Click(object sender, EventArgs e)
        {
            BuildMessage("Bitte verstehen Sie mich nicht falsch.\r\nWir zahlen grundsätzlich nicht per “Schenkfunktionen” (PayPal Freunde oder Überweisung) und davon rät auch die Polizei ab, weil man im Rechtsstreit machtlos ist.\r\nDaher würde ich gerne per normaler PayPal Bezahlung abwickeln. Die Gebühren übernehme ich selbstverständlich und schreibe falls ein den Defekt vorhanden sein sollte diesen ausdrücklich rein, dann sind wir beide auf der sicheren Seite.\r\n\r\nZudem sind wir hier auf Ebay Kleinanzeigen als seriöses Unternehmen gelistet und auch dementsprechend bewertet, schauen Sie sich dies gerne an.");
        }

        private void Btn_ShipmentNormalAdress_Click(object sender, EventArgs e)
        {
            BuildMessage("Geld ist soeben versendet. Bitte geben Sie doch kurz die Bestätigung über den Empfang durch, nicht dass es Unstimmigkeiten gegeben hat.\r\nVersand bitte per DHL Paket an folgende Adresse:\r\n\r\nLennart Aufermann\r\nAlfred-Delp-Straße 3\r\n59590 Geseke\r\n\r\nE-Mail, falls gefragt: dange.businessebay@gmail.com\r\n\r\nBitte alles sicher verpacken und vor allem das Gerät auf Werkseinstellungen zurücksetzen und jegliche Sperren (bei Apple: iCloud Konto oder bei Samsung Google Konto)\r\nBitte kontaktieren Sie mich doch, wenn Sie es verschickt haben.\r\n\r\nPositive Bewertung würde uns sehr freuen. Vor allem auch über Trustpilot: https://de.trustpilot.com/review/leno-ecommerce.de ");
        }

        private void Btn_ShipmentLabelRequestForAddress_Click(object sender, EventArgs e)
        {
            BuildMessage("Habe das Geld soeben versendet. Bitte geben Sie doch kurz die Bestätigung über den Empfang durch, nicht dass es Unstimmigkeiten gegeben hat. \r\n\r\nIch würde dann sehr gerne ein DHL Etikett für Sie erstellen. Wäre eine Zusendung an dieselbe Mail wie von PayPal möglich?\r\nWeiterhin bräuchte ich natürlich bitte noch Ihre Absenderadresse.");
        }

        private void Btn_ShipmentLabelSentIt_Click(object sender, EventArgs e)
        {
            BuildMessage("Habe das Etikett soeben an Ihre Mailadresse gesendet. Nur zur Information: Das Etikett kann leider nicht in einer Postfiliale vor Ort ausgedruckt werden.\r\n\r\nBitte geben Sie doch Bescheid, wenn sie das Paket abgegeben haben. Bitte alles sicher verpacken und vor allem das Gerät auf Werkseinstellungen zurücksetzen und jegliche Sperren (bei Apple: iCloud Konto oder bei Samsung Google Konto)\r\n\r\nBitte kontaktieren Sie mich doch, wenn Sie es verschickt haben.\r\n\r\nPositive Bewertung würde uns sehr freuen. Vor allem auch über Trustpilot: https://de.trustpilot.com/review/leno-ecommerce.de");
        }

        private void Btn_GetBack_Click(object sender, EventArgs e)
        {
            ServiceB2CAnkauf_ProActive window = new ServiceB2CAnkauf_ProActive();
            window.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedback window = new ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedback();
            window.Show();
        }

        private void Btn_BurnIn_Click(object sender, EventArgs e)
        {
            BuildMessage("Letzte Nachfrage noch:\r\nWir mussten in letzter Zeit mehrfach folgenden Fehler feststellen: Bei einigen Samsung Modellen kommt es mit der Zeit der Nutzung zu einem so genannten „Burn In“, ein so genannter Pixelfehler. Dies äußert sich, indem man bei einem weißen Hintergrund bestimmte Pixel sehr deutlich erkennt.\r\n(siehe Beispielbilder hier: https://drive.google.com/drive/folders/1Cxh-5atSUTq8-2lfMA7ppkNe7TeIR4fz?usp=sharing )\r\nWir möchten unseren Kunden nur die beste Qualität anbieten, weshalb wir Sie bitten würden, das Gerät einmal auf dieses Fehlerbild zu prüfen, damit keine Unstimmigkeiten im Nachgang entstehen.\r\nAm besten erkennt man dies bei leichtem Kippen des Geräts und mit einem Youtube Video “Weißer Hintergrund”, um wirklich alles zu erkennen. Wichtig hierbei ist, dass der komplette Bildschirm ausschließlich weiß ist, da diese Pixelfehler nur am oberen und unteren Rand des Geräts auftreten.\r\nFreue mich über Rückmeldung.\r\n\r\nBei Rückfragen stehe ich Ihnen sehr gerne jederzeit zur Verfügung.\r\nMfG Lennart von Leno Repair");
        }
    }
}
