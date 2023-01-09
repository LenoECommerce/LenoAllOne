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
    public partial class ServiceB2CAnkauf_ProblemContact : Form
    {
        public string prefix = "Guten Tag";
        public ServiceB2CAnkauf_ProblemContact()
        {
            InitializeComponent();
        }

        private void comboBox_Anrede_SelectedIndexChanged(object sender, EventArgs e)
        {
            prefix = comboBox_Anrede.SelectedItem.ToString();
        }

        private void Btn_Execute_Click(object sender, EventArgs e)
        {
            string reimburseProposal = "";
            string endtext = "\r\n\r\nUngerne mache ich für sowas einen PayPal Fall auf und da der Kontakt sowieso super nett gewesen ist, bin ich sicher, dass wir das so klären können.\r\n\r\nLeider können wir den Artikel so nicht gebrauchen und würden daher eine Rücksendung auf eigene Kosten vorschlagen, also wir würden die Versandkosten tagen.\r\n\r\nAnsonsten wünsche ich noch einen schönen Tag.\r\nMfG Lennart Aufermann";
            if (checkBox_ReimburseProposal.Checked == true)
            {
                double amount = Convert.ToDouble(textBox_ReimburseAmount.Text);
                reimburseProposal = "\r\n\r\nDa dieser Mangel von Ihnen leider nicht angegeben war, wollte ich einmal nett nachfragen, ob Sie mit einer " + amount+" € Teilrückerstattung einverstanden wären.";
                endtext = "\r\n\r\nUngerne mache ich für sowas einen PayPal Fall auf und da der Kontakt sowieso super nett gewesen ist, bin ich sicher, dass wir das so klären können.\r\nErstattung dann bitte einfach per PayPal Freunde an: dange.businessebay@gmail.com)\r\n\r\nUngerne senden wir das Gerät auch zurück, dies würde jedoch zu viel Aufwand führen und dann war alles für umsonst.\r\n\r\nAnsonsten wünsche ich noch einen schönen Tag.\r\nMfG Lennart Aufermann";
            }
            string message = prefix + ",\r\n\r\n" + "ich wollte mich nochmal bei Ihnen für die nette Kommunikation bedanken, das schätze ich sehr wert.\r\nGerade habe ich Zeit gefunden, um mich mit dem Gerät zu befassen und leider hat das Gerät "+textBox_Defect.Text+" (siehe hier:"+textBox_ProofLink.Text + ")."+reimburseProposal+endtext;
            Clipboard.SetText(message);
            MessageBox.Show("Nachricht wurde erfolgreich erzeugt.");
            this.Close();
        }

        private void ServiceB2CAnkauf_ProblemContact_Load(object sender, EventArgs e)
        {

        }

        private void checkBox_ReimburseProposal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ReimburseProposal.Checked == true)
            {
                label5.Visible = true;
                textBox_ReimburseAmount.Visible = true;
            }
            else
            {
                label5.Visible = false;
                textBox_ReimburseAmount.Visible = false;
            }
        }
    }
}
