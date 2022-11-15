using MySql.Data.MySqlClient;
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
    public partial class Matching : Form
    {
        public Matching()
        {
            InitializeComponent();
            ShowMatching();
        }
        public static MySqlConnection conn;
        public static string connString = "SERVER=sql11.freesqldatabase.com;PORT=3306;Initial Catalog='sql11525524';username=sql11525524;password=d3ByMHVgie";
        public void ShowMatching()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();

            string query = "SELECT * FROM `Matching`";
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, conn);

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            ////Datensatz
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            //Daten anzeigen im Grid
            matchingDGV.DataSource = dataSet.Tables[0];
            //Column verstecken
            matchingDGV.Columns[0].Visible = false;
            conn.Close();
        }


        private void Matching_Load(object sender, EventArgs e)
        {

        }
    }
}
