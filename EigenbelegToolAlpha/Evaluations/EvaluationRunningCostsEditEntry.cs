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
    public partial class EvaluationRunningCostsEditEntry : Form
    {
        public EvaluationRunningCostsEditEntry()
        {
            InitializeComponent();
        }

        private void EvaluationRunningCostsEditEntry_Load(object sender, EventArgs e)
        {
            string table = "EvaluationsCurrentCosts";
            string equalColum = "Id";
            string equalValue = EvaluationRunningCosts.lastSelectedEntry.ToString();
            textBox_Amount.Text = CRUDQueries.ExecuteQueryWithResultString(table,"Betrag",equalColum, equalValue);
            textBox_invoiceProvider.Text = CRUDQueries.ExecuteQueryWithResultString(table, "Rechnungssteller", equalColum, equalValue);
            comboBox_taxdeduction.Text = CRUDQueries.ExecuteQueryWithResultString(table, "Vorsteuerabzug", equalColum, equalValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string amount = textBox_Amount.Text;
            string invoiceProvider = textBox_invoiceProvider.Text;
            string taxDeduction = comboBox_taxdeduction.Text;
            string query = string.Format("UPDATE `EvaluationsCurrentCosts` SET `Rechnungssteller` = '{0}', `Betrag` = '{1}', `Vorsteuerabzug` = '{2}' WHERE `Id` = '{3}'",
                            invoiceProvider,amount,taxDeduction, EvaluationRunningCosts.lastSelectedEntry.ToString());
            CRUDQueries.ExecuteQuery(query);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
