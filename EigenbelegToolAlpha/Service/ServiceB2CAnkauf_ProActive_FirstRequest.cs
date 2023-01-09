using com.itextpdf.text.pdf;
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
    public partial class ServiceB2CAnkauf_ProActive_FirstRequest : Form
    {
        public ServiceB2CAnkauf_ProActive_FirstRequest()
        {
            InitializeComponent();
        }
        public string prefix = "";
        public string requestAmount = "";
        public string user = Service.user;
        public string hauptfragen = "";

        Dictionary<string, string> appleKatalog = new Dictionary<string, string>
        {
            { "Speicher", "- Wie viel GB Speicher hat das Handy?" },
            { "Rand", "- Hätten Sie wohl bitte noch Bilder von den Rändern des Geräts? Am besten mit Blitzlicht abfotografieren, damit auch kleine Kratzer erkannt werden können." },
            { "iCloud", "- Ist die ICloud Sperre entfernt?" },
            { "Display", "- Ist das Display original? Dies ist erkennbar in den Einstellungen/Allgemein/Info. Weiterhin wollte ich gerne fragen, ob der Touchscreen einwandfrei funktioniert und ob es irgendwelche Auffälligkeiten (Pixelfehler, Verfärbungen) gibt?" },

        };
        Dictionary<string, string> samsungKatalog = new Dictionary<string, string>
        {
            { "Speicher", "- Wie viel GB Speicher hat das Handy?" },
            { "Rand", "- Hätten Sie wohl bitte noch Bilder von den Rändern des Geräts? Am besten mit Blitzlicht abfotografieren, damit auch kleine Kratzer erkannt werden können." },
        };

        private void BuildMessage(string insertValue)
        {
            prefix = comboBox_Anrede.Text;
            string message = prefix + ",\r\n"+insertValue+ "\r\nBei Rückfragen stehe ich Ihnen sehr gerne jederzeit zur Verfügung\n\rMfG " + user+" von Leno Repair";
            Clipboard.SetText(message);
            MessageBox.Show("Deine Nachricht wurde erfolgreich erstellt.");
        }
        private void BuildMessageWithPhoneNumber(string insertValue)
        {
            prefix = comboBox_Anrede.Text;
            string message = prefix + ",\r\n" + insertValue + "\r\nBei Rückfragen stehe ich Ihnen sehr gerne jederzeit zur Verfügung, auch telefonisch oder per WhatsApp (015110792661).\r\nMfG " + user + " von Leno Repair";
            Clipboard.SetText(message);
            MessageBox.Show("Deine Nachricht wurde erfolgreich erstellt.");
        }
        private void BuildMessageFirstContact()
        {
            prefix = comboBox_Anrede.Text;
            if (comboBox_ModellApple.Text == "Bis iPhone XR")
            {
                hauptfragen = "- Funktioniert sonst technisch alles?\nIch kann Ihnen die App 'Phone Doctor' empfehlen, womit Sie innerhalb kürzester Zeit alle Funktionen des Geräts testen können. Würde mich auch freuen, wenn Sie kurz schauen könnten, ob die Außenkamera Flecken hat.\r\n\r\n";
            }
            else if (comboBox_ModellApple.Text == "Ab iPhone XS")
            {
                hauptfragen = "- Funktioniert sonst technisch alles? Vor allem die Face ID ist die wichtigste Funktion, wären Ihnen daher dankbar, wenn Sie diese einmal zum Test einrichten können.\nIch kann Ihnen die App 'Phone Doctor' empfehlen, womit Sie innerhalb kürzester Zeit alle Funktionen des Geräts testen können. Würde mich auch freuen, wenn Sie kurz schauen könnten, ob die Außenkamera Flecken hat.\r\n\r\n- Hat das Gerät nicht-originale Teile verbaut bzw. erscheint eine Fehlermeldung? Dies ist erkennbar unter Einstellungen/Allgemein/Info. \r\n\r\n";
            }
            hauptfragen = ListBoxAlgorithm();
            string message = prefix + ",\r\ngerne würden wir Ihnen "+requestAmount+ "€ inkl. Versandabwicklung anbieten. Wir sind ein junges Unternehmen, das sich auf die Reparatur von defekten Smartphones spezialisiert hat und können Ihnen gerne ein für Sie kostenloses Versandetikett erstellen. \r\nHätte noch paar Fragen, ich würde mich freuen, wenn Sie mir da behilflich sein würden:\r\n\r\n" + hauptfragen+ "\r\nBei Rückfragen stehe ich Ihnen sehr gerne jederzeit zur Verfügung, auch telefonisch oder per WhatsApp (015110792661).\r\nMfG " + user + " von Leno Repair";
            Clipboard.SetText(message);
            MessageBox.Show("Deine Nachricht wurde erfolgreich erstellt.");
        }
        private string ListBoxAlgorithm()
        {
            if (comboBox_Make.Text == "Apple")
            {
                foreach (object items in listBox_Apple.SelectedItems)
                {
                    var key = items.ToString();
                    if (appleKatalog.ContainsKey(key))
                    {
                        hauptfragen += (hauptfragen == "" ? "" : "\r\n\r\n") + appleKatalog[key];
                    }
                }
            }
            else
            {
                hauptfragen = "- Soweit funktioniert technisch alles einwandfrei?\r\n\r\n- Gibt es irgendwelche Brüche (auch minimale nennen bitte) oder starke Risse ?\r\n\r\n";
                foreach (object items in listBox_Samsung.SelectedItems)
                {
                    var key = items.ToString();
                    if (samsungKatalog.ContainsKey(key))
                    {
                        hauptfragen += (hauptfragen == "" ? "" : "\r\n\r\n") + samsungKatalog[key];
                    }
                }
            }
            return hauptfragen;
        }
        private void Btn_GetBack_Click(object sender, EventArgs e)
        {
            ServiceB2CAnkauf_ProActive window = new ServiceB2CAnkauf_ProActive();
            window.Show();
            this.Close();
        }

        private void Btn_AppleAngebot_Click(object sender, EventArgs e)
        {
            BuildMessage("das ist wirklich schade. Gerne könnte ich Ihnen noch anbieten, dass Sie mir das Gerät zusenden und ich ein Display draufpacke und es dann ankaufe oder ggf. Ihnen mit Fehlerbericht zurücksende, natürlich als kostenloser Service. Wir sind als Unternehmen tätig und auch hier auf Ebay Kleinanzeigen präsent. Natürlich senden wir Ihnen dazu auch ein offiziell rechtliches Dokument hinzu.\r\nIhr Vorteil dabei wäre, dass Sie je nach Situation auf jeden Fall einen Fehlerbericht haben, um so mehr Klarheit im Verkauf zu haben oder es eben wie gesagt an uns zu verkaufen, denn wir können seriöse Preise inkl. Abwicklung anbieten. Wir können auch gerne einen Mindestpreis im Vorhinein festlegen, den wir auch schon bezahlen würden. Was denken Sie dazu?");
        }

        private void Btn_AppleDisplay_Click(object sender, EventArgs e)
        {
            BuildMessage("also sind Sie sich sicher, dass keine Verfärbungen oder Fehler am Display vorliegen? Ich hatte schon öfters den Fall, dass es dann doch einen Fehler hatte. Am besten erkennt man Verfärbungen wenn man von der Seite unter den starken Glasschaden schaut. Dabei hilft vor allem die Phone Doctor Plus App, wenn man den Reiter 'Bildschirmanzeige' auswählt und so sowohl auf weißem, als auch schwarzem Hintergrund genau hinschaut. Würde mich freuen, wenn Sie das nochmal absichern würden.");
        }

        private void Btn_AppleRisikokauf_Click(object sender, EventArgs e)
        {
            BuildMessageWithPhoneNumber(requestAmount+"€ inkl. Versandabwicklung anbieten. Wir sind ein junges Unternehmen, das sich auf die Reparatur von defekten Smartphones spezialisiert hat und können Ihnen gerne ein für Sie kostenloses Versandetikett erstellen.\r\nHätte noch paar Fragen, ich würde mich freuen, wenn Sie mir da behilflich sein würden:- Hat vorher alles einwandfrei funktioniert?\r\n\r\n- Befindet sich das Gerät im Originalzustand bzw. wurde es schon geöffnet? Dies ist für uns sehr wichtig.\r\n- Konnten Sie die iCloud Sperre entfernen? Bzw. haben Sie im Fall einer erfolgreichen Reparatur noch die Apple ID Daten zur Verfügung, ansonsten wäre das Gerät dann leider wertlos.\r\n- Haben Sie Infos, wie es genau zu dem Defekt gekommen ist? Wichtig wäre hierbei, ob das Gerät Kontakt mit Wasser hatte.\r\n\r\nGerne zahle ich per PayPal oder über die Ebay Kleinanzeigen Bezahlfunktion");
        }

        private void textBox_Amount_TextChanged(object sender, EventArgs e)
        {
            requestAmount=textBox_Amount.Text;
        }

        private void Btn_AppleFaceID_Click(object sender, EventArgs e)
        {
            BuildMessageWithPhoneNumber("ich wollte einmal nachfragen, inwiefern die Face ID nicht funktioniert. Gibt es eine Fehlermeldung? Wenn ja könnten Sie mir diese bitte zuordnen.\r\nIn manchen Fällen lässt sich der Knopf für die Face ID Einrichtung noch drücken, lediglich die Sensoren funktionieren nicht.\r\n\r\nHat schon jemand in das Gerät eingegriffen, wodurch es zu dem Face ID Defekt gekommen ist oder ist dieser einfach so aufgetreten?");
        }

        private void Btn_Copy_Click(object sender, EventArgs e)
        {
            BuildMessageFirstContact();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            hauptfragen = "";
            textBox_Amount.Text = "";
            listBox_Samsung.SelectedItems.Clear();
            listBox_Apple.SelectedItems.Clear();
        }

        private void comboBox_Make_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Make.Text == "Apple")
            {
                label4.Visible = true;
                comboBox_ModellApple.Visible = true;
                listBox_Apple.Visible = true;
                listBox_Samsung.Visible = false;
            }
            else
            {
                label4.Visible = false;
                comboBox_ModellApple.Visible = false;
                listBox_Apple.Visible = false;
                listBox_Samsung.Visible = true;
            }
        }

        private void ServiceB2CAnkauf_ProActive_FirstRequest_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Feedback_Click(object sender, EventArgs e)
        {
            ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedback window = new ServiceB2CAnkauf_ProActive_ReachBack_FirstFeedback();
            window.Show();
            this.Close();
        }

        private void Btn_NotInterested_Click(object sender, EventArgs e)
        {
            BuildMessage("vielen Dank für die Nachricht und vor allem in Ihr Vertrauen in unser Unternehmen.\r\n\r\nLeider haben wir für den von Ihnen beschriebenen Artikel kein Interesse.\r\n\r\nBei weiteren Rückfragen melden Sie sich gerne, wir bieten neben dem Ankauf Service auch Reparaturen an. Es würde es uns freuen, wenn Sie unserem Ebay Kleinanzeigen Account folgen und uns in Zukunft kontaktieren, wenn Sie aus dem Bekanntenkreis oder von Freunden von einem (teil)defekten iPhone mitbekommen.\r\n\r\nIch freue mich über weitere Rückmeldungen.");
        }

        private void Btn_Offer_Click(object sender, EventArgs e)
        {
            BuildMessage("vielen Dank für die Nachricht und vor allem in Ihr Vertrauen in unser Unternehmen.\r\n\r\nGerne mache ich Ihnen ein Angebot. Da es sich wahrscheinlich um einen Platinenfehler handelt, würde ich "+requestAmount+ "€ + Versandabwicklung vorschlagen. Platinenfehler sind nämlich sehr zeitintensiv. Notfalls kann es auch sein, dass das Gerät als Ersatzteilspender verwendet wird.\r\n\r\nEs gäbe allerdings auch noch eine weitere Möglichkeit, dass Sie das Gerät kostenfrei einsenden und wir es uns dann ansehen und je nachdem mehr anzahlen würden, wenn es ein einfacher Fehler wäre. Dazu würden Sie natürlich ein offiziell rechtliches Dokument erhalten.\r\n\r\nFreue mich über Ihre Rückmeldung.");
        }
    }
}
