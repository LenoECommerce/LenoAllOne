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
    public partial class ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedbackMissingInformation : Form
    {
        public string nachwortCopyButtons = "\n\nBei Rückfragen stehe ich Ihnen sehr gerne jederzeit zur Verfügung.\r\nMit freundlichen Grüßen\r\nLennart Aufermann von Leno Repair";
        public string moreQuestions = "";
        public ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedbackMissingInformation()
        {
            InitializeComponent();
        }
        Dictionary<string, string> katalog = new Dictionary<string, string>
        {
            { "Speicher", "- Wie viel GB Speicher hat das Handy?" },
            { "Bilder", "- Hätten Sie wohl bitte noch Bilder von den Rändern des Geräts? Am besten mit Blitzlicht abfotografieren, damit auch kleine Kratzer erkannt werden können." },
            { "Phone Doc Test","- Wären Sie so nett und würden trotzdem einmal alles mit der App 'Phone Doctor' testen, damit es später keine Missverständnisse auftreten und noch ein weiterer Defekt vorliegt. Das würde keine 5-10 Minuten dauern und damit wären beide total abgesichert, was den technischen Zustand des Geräts angeht.\nDas würde mich sehr freuen!" },
            { "iCloud", "- Ist die ICloud Sperre entfernt?" },
            { "Originalität", "- Hat das Gerät nicht-originale Teile verbaut bzw. erscheint eine Fehlermeldung? Dies ist erkennbar unter Einstellungen/Allgemein/Info." },

        };
        private void Btn_Copy_Click(object sender, EventArgs e)
        {
            foreach (object items in listBox1.SelectedItems)
            {
                var key = items.ToString();
                if (katalog.ContainsKey(key))
                {
                    moreQuestions += (moreQuestions == "" ? "" : "\r\n\r\n") + katalog[key];
                }
            }
            Clipboard.SetText("Vielen Dank für die nette Rückmeldung. Ich würde das Gerät sehr gerne abkaufen, allerdings wären noch folgende Informationen offen:\n\n" + moreQuestions + nachwortCopyButtons);
            MessageBox.Show("Die Nachricht wurde erfolgreich kopiert.");
            this.Close();
        }
    }
}
