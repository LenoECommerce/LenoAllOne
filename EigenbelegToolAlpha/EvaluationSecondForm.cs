using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EigenbelegToolAlpha
{
    public partial class EvaluationSecondForm : Form
    {
        public static double ebayGrossSalesMarginalVat;
        public static double ebayGrossSalesNormalVat;
        public static double sparepartsGrossSalesMarginalVat;
        public static double sparepartsGrossSalesNormalVat;
        public static double B2BGrossSalesTotal;
        public static double B2BRevenue;
        public static double rateConsumptionCables;
        public static double rateConsumptionNeutralPackages;
        public static double rateConsumptionCartons;
        public static double rateConsumptionTotal;
        public static double moreExternalCostsMarginalVat;
        public static double moreExternalCostsNormalVat;
        public EvaluationSecondForm()
        {
            InitializeComponent();
        }

        private void btn_ContinueWithEvaluation3_Click(object sender, EventArgs e)
        {
            try
            {
                sparepartsGrossSalesMarginalVat = Convert.ToDouble(textBox_SparePartsGrossSalesMarginalVa.Text);
                sparepartsGrossSalesNormalVat = Convert.ToDouble(textBox_SparePartsGrossSalesNormalVat.Text);
                B2BGrossSalesTotal = Convert.ToDouble(textBox_B2BGrossSales.Text);
                B2BRevenue = Convert.ToDouble(textBox_B2BGrossSalesRevenue.Text);
                rateConsumptionCables = Convert.ToDouble(textBox_rateConsumptionCables.Text)*1;
                rateConsumptionNeutralPackages = Convert.ToDouble(textBox_rateConsumptionNeutralPackages.Text)*3;
                rateConsumptionCartons = Convert.ToDouble(textBox_rateConsumptionCartons.Text)*0.3;
                rateConsumptionTotal = rateConsumptionCables + rateConsumptionNeutralPackages + rateConsumptionCartons;
                moreExternalCostsMarginalVat = Convert.ToDouble(textBox_MoreExternalCostMarginalVat.Text);
                moreExternalCostsNormalVat = Convert.ToDouble(textBox_MoreExternalCostNormalVat.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            EvaluationThirdForm frm = new EvaluationThirdForm();
            frm.Show();
            this.Hide();
        }

        private void textBox_rateConsumptionCables_TextChanged(object sender, EventArgs e)
        {

        }

        private void EvaluationSecondForm_Load(object sender, EventArgs e)
        {

        }
    }
}
