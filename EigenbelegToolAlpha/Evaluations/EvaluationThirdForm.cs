using Org.BouncyCastle.Bcpg;
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
        public double restVersandkosten;
        public double restRunningCosts;
        public static double RunningCostsSum;
        public static double RunningCostsTaxGetBack;
        public static double RunningCostsFinal;
        public string month = EvaluationsFirstPage.month;

        private void btn_ContinueWithEvaluation3_Click(object sender, EventArgs e)
        {
            digitalToolsBillBee = Convert.ToDouble(textbox_DigitalToolsBillbee.Text);
            restVersandkosten = Convert.ToDouble(textBox_RestVersandkosten.Text);
            restRunningCosts = Convert.ToDouble(textBox_CostsFromDatabase.Text);
            RunningCostsSum = digitalToolsBillBee + restVersandkosten + restRunningCosts;
            RunningCostsFinal = RunningCostsSum - EvaluationsFirstPage.ebayTaxGetBack;
            EvaluationCalculation window = new EvaluationCalculation();
            window.Show();
            this.Hide();
        }

        private void EvaluationThirdForm_Load(object sender, EventArgs e)
        {
            if (CheckIfMonthExists() == true)
            {
                SkipRunningCosts();
            }
            else
            {
                textbox_DigitalToolsBillbee.Text = "0";
                textBox_RestVersandkosten.Text = "0";
                textBox_CostsFromDatabase.Text = CalculateAllDatabaseRunningCosts();
            }
        }
        public void SkipRunningCosts()
        {
            RunningCostsFinal = Convert.ToDouble(CRUDQueries.ExecuteQueryWithResultString("Evaluations", "Kosten", "Monat", month)) - EvaluationsFirstPage.ebayTaxGetBack;
            EvaluationCalculation window = new EvaluationCalculation();
            window.Show();
            this.Close();
        }
        public bool CheckIfMonthExists()
        {
            var id = CRUDQueries.ExecuteQueryWithResult("Evaluations","Id","Monat",month);
            if (id != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string CalculateAllDatabaseRunningCosts()
        {
            double returnValue = 0;
            EvaluationRunningCosts evaluationRunningCosts = new EvaluationRunningCosts();
            foreach (DataGridViewRow row in evaluationRunningCosts.runningcostsDGV.Rows)
            {
                returnValue += Convert.ToDouble(row.Cells[2].Value);
                //Check ob Ausgabe vorsteuerabzugsfähig ist
                if (row.Cells[3].Value.ToString() == "Ja")
                {
                    returnValue -= Convert.ToDouble(row.Cells[2].Value) / 1.19 * 0.19;
                }
            }
            double temp = MonthlyReportPDF.RoundOneDigit(returnValue);
            return temp.ToString();
        }
        private void textbox_DigitalToolsEbayAbos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
