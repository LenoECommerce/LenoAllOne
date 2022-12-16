using System;
using System.Windows.Forms;

namespace EigenbelegToolAlpha
{
    public partial class ServiceB2CAnkauf_Questions : Form
    {
        public string user = Service.user;

        public ServiceB2CAnkauf_Questions()
        {
            InitializeComponent();
        }
        private void BuildMessage(string insertValue)
        {
            string message = insertValue + "\r\n\r\nBei Rückfragen stehe ich Ihnen sehr gerne jederzeit zur Verfügung\r\n\r\nMfG " + user + " von Leno Repair";
            Clipboard.SetText(message);
            MessageBox.Show("Deine Nachricht wurde erfolgreich erstellt.");
        }
        private void btn_GetBack_Click(object sender, EventArgs e)
        {
            Service window = new Service();
            window.Show();
            this.Close();
        }

        private void ServiceB2CAnkauf_Questions_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ReactionToEbayPaymentMethod_Click(object sender, EventArgs e)
        {
            BuildMessage("Im Grunde wäre ein Bezahlung per 'Ebay Sicher Bezahlen' möglich, allerdings fällt dabei eine doppelt so hohe Gebühr wie ursprünglich bei PayPal an. Daher würden wir PayPal bevorzugen, gerne können Sie auch das Konto eines Bekannten o. Ä. verwenden.\r\n\r\n Ansonsten würde ich vorschlagen, dass wir uns bei Ebay Sicher Bezahlen die Gebühren teilen. Freue mich über Ihre Rückmeldung.");
        }

        private void Btn_ExplanationBusinessModel_Click(object sender, EventArgs e)
        {
            BuildMessage("Gerne erläutere ich Ihnen unser Geschäftsmodell. Im Prinzip ist es der klassische Handel im Online Bereich. Dazugehört natürlich die technische Prüfung und ggf. Reparatur oder Wiederaufbereitung. Dann wird es wieder an den Endkunden weitergegeben und wir als Unternehmen tragen natürlich die Gewährleistung.\r\n\r\nEs ist vollkommen verständlich, dass Sie nachfragen. Wir bekommen immer wieder zu hören, dass man eine höfliche Kommunikation sehr selten antrifft. Es ist einfach so, dass sehr viele unseriöse Leute hier auf Kleinanzeigen unterwegs sind, da freut man sich immer, wenn man mal auf vernünftige Leute trifft.");
        }

        private void Btn_NoInterests_Click(object sender, EventArgs e)
        {
            BuildMessage("Ich wollte Sie nur kurz darüber informieren, dass es uns zurzeit leider nicht möglich ist, das Gerät anzukaufen.\r\nDaher bitten wir um Ihr Verständnis. Der Kontakt mit Ihnen war super nett und das freut mich persönlich, da dies auf Kleinanzeigen nicht immer der Fall ist.\r\nZudem möchten wir natürlich nicht, eventuelle andere Interessenten blockieren. Teilen Sie uns gerne mit, ob wir Sie in ggf. ein paar Tagen nochmal anschreiben könnten, wenn es für uns ein Ankauf des Geräts wieder in Frage kommt. Dann notiere ich mir gerne alles Notwendige dazu.\r\nFreue mich sehr über Rückmeldung.");
        }

        private void Btn_ExplainShippingProcess_Click(object sender, EventArgs e)
        {
            BuildMessage("Bei unserem Ankaufservice erstellen wir Ihnen ein voll umfänglich versichertes DHL Etikett. Dabei ist der Absender logischerweise auf Ihren Namen und das Etikett ist direkt zu uns adressiert.\r\nDer Hintergrund hinter diesem Service ist, dass wir unseren Kunden damit so wenig Aufwand und Kosten wie möglich bieten möchten.");
        }

        private void Btn_PayPalMoneyHoldExplanation_Click(object sender, EventArgs e)
        {
            BuildMessage("Keine Sorge, das ist eine Vorsichtsmaßnahme von PayPal. Das machen dir zurzeit anscheinend öfter, um Ihre Nutzer zu schützen.\r\nSoweit ich das kenne, wird das Geld freigeschaltet, sobald das Gerät hier eintrifft. Am besten ist es immer, den Sendungsverfolg zu hinterlegen. Das System erkennt dann die Ankunft. Auf jeden Fall ist Ihr Geld bei PayPal sicher aufgehoben.\r\nBei weiteren Rückfragen hilft bestimmt der PayPal Support.");
        }

        private void Btn_PayPalBlocksMoneyAfterDelivery_Click(object sender, EventArgs e)
        {
            //test
            BuildMessage("Bitte entschuldigen Sie die Unannehmlichkeiten. Momentan hält PayPal verhältnismäßig viel ein, bitte gedulden Sie sich. Mich stört das selber auch. Hatte ich selten, dass es so oft vorkommt, dass Geld einbehalten wird. \r\nEmpfehlen kann ich immer die Hinterlegung des Sendungsverfolgs. Ansonsten habe ich gerade nochmal extra nachgeschaut, ich habe dort leider keine Möglichkeiten für eine verschnellerte Freischaltung.\r\nBitte daher um Geduld, wenn es frei ist können Sie sich ja kurz melden.");
        }
    }
}
