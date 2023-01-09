using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using _Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using MigraDoc.DocumentObjectModel.Internals;
using System.Runtime.Remoting.Messaging;
using Microsoft.Vbe.Interop;

namespace EigenbelegToolAlpha
{
    public partial class EvaluationRunningCosts : Form
    {
        public static MySqlConnection conn;
        public string connString = CRUDQueries.connString;
        public static int lastSelectedEntry = 0;
        string invoiceProvider = "";
        string amount = "";
        string taxDeductionPossible = "";
        public EvaluationRunningCosts()
        {
            InitializeComponent();
            ShowCosts();
        }

        private void EvaluationRunningCosts_Load(object sender, EventArgs e)
        {
            ShowCosts();
        }
        public void ShowCosts()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();

            string query = "SELECT * FROM `EvaluationsCurrentCosts`";
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, conn);

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            ////Datensatz
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            //Daten anzeigen im Grid
            runningcostsDGV.DataSource = dataSet.Tables[0];
            //Column verstecken
            runningcostsDGV.Columns[0].Visible = false;
            //Sortierte Ansicht
            runningcostsDGV.Sort(runningcostsDGV.Columns[1], ListSortDirection.Descending);
            conn.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            using(var form = new EvaluationRunningCostsCreateEntry())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ShowCosts();
                }
            }
        }
        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lastSelectedEntry == 0)
            {
                MessageBox.Show("Bitte wähle zuerst einen Eintrag aus");
                return;
            }
            string query = string.Format("DELETE FROM `EvaluationsCurrentCosts` WHERE `Id` = {0} ;", lastSelectedEntry);
            CRUDQueries.ExecuteQuery(query);
            ShowCosts();
        }

        private void runningcostsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            invoiceProvider = runningcostsDGV.SelectedRows[0].Cells[1].Value.ToString();
            amount = runningcostsDGV.SelectedRows[0].Cells[2].Value.ToString();
            taxDeductionPossible = runningcostsDGV.SelectedRows[0].Cells[3].Value.ToString();

            lastSelectedEntry = (int)runningcostsDGV.SelectedRows[0].Cells[0].Value;
        }


        private void runningcostsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (lastSelectedEntry == 0)
            {
                MessageBox.Show("Bitte wähle zuerst einen Eintrag aus");
                return;
            }
            using (var form = new EvaluationRunningCostsEditEntry())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ShowCosts();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in runningcostsDGV.Rows)
            {
                double test = Convert.ToDouble(row.Cells[2].Value);
                MessageBox.Show("test");
            }
        }
    }
}
