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
    public partial class EvaluationThirdForm : Form
    {
        public EvaluationThirdForm()
        {
            InitializeComponent();
        }
        public double digitalToolsBillBee;
        public double digitalToolsLexOffice;
        public double digitalToolsKleinanzeigen;
        public double digitalToolsBitwarden;
        public double digitalToolsNsys;
        public double digitalToolsPenta;
        public double digitalToolsZapier;
        public double digitalToolsEbayAbo;
        public double digitalToolsFraenk;
        public double digitalToolsSQLDatabase;
        public double websitesIONOS;
        public double websitesSiteground;
        public double websitesElementorPro;
        public double legalRechtskanzlei;
        public double legalVerpackungslizenz;
        public double legalSteuerberatung;
        public double legalFinanzbuchhaltung;
        public double restMiete;
        public double restKredit;
        public double restVersandkosten;
        public double restEbayVorsteuer;

        public static double RunningCostsSum;
        public static double RunningCostsTaxGetBack;
        public static double RunningCostsFinal;

        private void btn_ContinueWithEvaluation3_Click(object sender, EventArgs e)
        {
            digitalToolsBillBee = Convert.ToDouble(textbox_DigitalToolsBillbee.Text);
            digitalToolsBitwarden = Convert.ToDouble(textbox_DigitalToolsBitWarden.Text);
            digitalToolsEbayAbo = Convert.ToDouble(textbox_DigitalToolsEbayAbos.Text);
            digitalToolsFraenk = Convert.ToDouble(textbox_DigitalToolsFraenk.Text);
            digitalToolsKleinanzeigen = Convert.ToDouble(textbox_DigitalToolsKleinanzeigen.Text);
            digitalToolsLexOffice = Convert.ToDouble(textbox_DigitalToolsLexOffice.Text);
            digitalToolsNsys = Convert.ToDouble(textbox_DigitalToolsNSYS.Text);
            digitalToolsPenta = Convert.ToDouble(textbox_DigitalToolsPenta.Text);
            digitalToolsSQLDatabase = Convert.ToDouble(textbox_DigitalToolsSQLDatabase.Text);
            digitalToolsZapier = Convert.ToDouble(textbox_DigitalToolsZapier.Text);
            websitesElementorPro = Convert.ToDouble(textbox_WebsiteElementorPro.Text);
            websitesIONOS = Convert.ToDouble(textbox_WebsiteIONOS.Text);
            websitesSiteground = Convert.ToDouble(textbox_WebsiteSiteground.Text);
            legalFinanzbuchhaltung = Convert.ToDouble(textbox_LegalFinanzbuchhaltung.Text);
            legalRechtskanzlei = Convert.ToDouble(textbox_LegalRechtskanzlei.Text);
            legalSteuerberatung = Convert.ToDouble(textbox_LegalSteuerberatung.Text);
            legalVerpackungslizenz = Convert.ToDouble(textbox_LegalVerpackungslizenz.Text);
            restMiete = Convert.ToDouble(textBox_RestMiete.Text);
            restVersandkosten = Convert.ToDouble(textBox_RestVersandkosten.Text);
            //20 Elemente!
            RunningCostsSum = digitalToolsBillBee + digitalToolsBitwarden + digitalToolsEbayAbo + digitalToolsFraenk + digitalToolsKleinanzeigen + digitalToolsLexOffice + digitalToolsNsys + digitalToolsPenta
                + digitalToolsSQLDatabase + digitalToolsZapier + websitesElementorPro + websitesIONOS + websitesSiteground + legalFinanzbuchhaltung + legalRechtskanzlei + legalSteuerberatung + legalVerpackungslizenz
                + restKredit + restMiete + restVersandkosten;
            RunningCostsTaxGetBack = (RunningCostsSum - restMiete - websitesElementorPro - websitesSiteground) / 1.19 * 0.19;
            RunningCostsFinal = RunningCostsSum - RunningCostsTaxGetBack - EvaluationsFirstPage.ebayTaxGetBack;

            EvaluationCalculation window = new EvaluationCalculation();
            window.Show();
            this.Hide();
        }

        private void EvaluationThirdForm_Load(object sender, EventArgs e)
        {
            textbox_DigitalToolsBillbee.Text = "0";
            textbox_DigitalToolsLexOffice.Text = "0";
            textbox_DigitalToolsKleinanzeigen.Text = "41,65";
            textbox_DigitalToolsBitWarden.Text = "7,21";
            textbox_DigitalToolsNSYS.Text = "195,00";
            textbox_DigitalToolsPenta.Text = "0";
            textbox_DigitalToolsZapier.Text = "30,21";
            textbox_DigitalToolsEbayAbos.Text = "39,95";
            textbox_DigitalToolsFraenk.Text = "10,00";
            textbox_DigitalToolsSQLDatabase.Text = "1,33";
            textbox_WebsiteIONOS.Text = "23,65";
            textbox_WebsiteSiteground.Text = "22,90";
            textbox_WebsiteElementorPro.Text = "8,50";
            textbox_LegalRechtskanzlei.Text = "23,56";
            textbox_LegalVerpackungslizenz.Text = "3,87";
            textbox_LegalSteuerberatung.Text = "100";
            textbox_LegalFinanzbuchhaltung.Text = "200";
            textBox_RestMiete.Text = "0";
            textBox_RestVersandkosten.Text = "0";
        }

        private void textbox_DigitalToolsEbayAbos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
