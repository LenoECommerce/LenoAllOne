using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace EigenbelegToolAlpha
{
    public partial class EvaluationHistory : Form
    {
        public string currentYear = "2022";
        public int lastSelectedEntry;
        public static MySqlConnection conn;
        public string connString = CRUDQueries.connString;
        public EvaluationHistory()
        {
            InitializeComponent();
            ShowEvaluations();
        }

        public void ShowEvaluations ()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();

            string query = "SELECT * FROM `Evaluations`";
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, conn);

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            ////Datensatz
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            //Daten anzeigen im Grid
            evaluationsDGV.DataSource = dataSet.Tables[0];

            evaluationsDGV.Columns[0].Visible = false;
            evaluationsDGV.Columns[4].Visible = false;
            evaluationsDGV.Columns[5].Visible = false;
            evaluationsDGV.Columns[6].Visible = false;
            evaluationsDGV.Columns[7].Visible = false;
            evaluationsDGV.Columns[8].Visible = false;
            evaluationsDGV.Columns[9].Visible = false;
            evaluationsDGV.Columns[10].Visible = false;
            evaluationsDGV.Columns[11].Visible = false;
            evaluationsDGV.Columns[12].Visible = false;
            //Sortierte Ansicht
            evaluationsDGV.Sort(evaluationsDGV.Columns[1], ListSortDirection.Descending);

            foreach (DataGridViewRow row in evaluationsDGV.Rows)
            {
                var pos = row.Index;
                if (row.Cells[2].Value.ToString() != currentYear)
                {
                    if (pos == 0)
                    {
                        evaluationsDGV.CurrentCell = null;
                        row.Visible = false;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

            conn.Close();
        }
        private void EvaluationHistory_Load(object sender, EventArgs e)
        {
            ShowEvaluations();
        }

        private void combobox_SelectedYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentYear = combobox_SelectedYear.SelectedItem.ToString();
            ShowEvaluations();
        }

        private void btn_DownloadReport_Click(object sender, EventArgs e)
        {
            if (lastSelectedEntry == 0)
            {
                MessageBox.Show("Bitte wähle einen Eintrag aus.");
                return;
            }
            var result = CRUDQueries.ExecuteQueryWithResultString("Evaluations","Link","Id",lastSelectedEntry.ToString());
            Clipboard.SetText(result);
            MessageBox.Show("Wurde erfolgreich kopiert.");
        }

        private void evaluationsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastSelectedEntry = (int)evaluationsDGV.SelectedRows[0].Cells[0].Value;
        }
    }
}
