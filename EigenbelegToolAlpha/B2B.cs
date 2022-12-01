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
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;


namespace EigenbelegToolAlpha
{
    public partial class B2B : Form
    {
        public static MySqlConnection conn;
        public static string connString = "SERVER=sql11.freesqldatabase.com;PORT=3306;Initial Catalog='sql11525524';username=sql11525524;password=d3ByMHVgie";
        public static int lastSelectedEntry;
        public static string offerNumber = "";
        public static string offerType = "";
        public static string model = "";
        public static string reference = "";
        public static string storage = "";
        public static string condition = "";
        public static string original = "";
        public static string defect = "";
        public static string battery = "";
        public static string icloudLock = "";
        public static string packaging = "";
        public static string taxing = "";
        public static string buyPrice = "";
        public static string sellPrice = "";
        public B2B()
        {
            InitializeComponent();
            ShowB2BEntries();
        }

        public void ShowB2BEntries()
        {
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();

                string query = "SELECT * FROM `B2B`";
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, conn);

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                ////Datensatz
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                //Daten anzeigen im Grid
                b2bDGV.DataSource = dataSet.Tables[0];
                //Column verstecken
                b2bDGV.Columns[0].Visible = false;
                //Sortierte Ansicht
                b2bDGV.Sort(b2bDGV.Columns[1], ListSortDirection.Descending);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void B2B_Load(object sender, EventArgs e)
        {
            ShowB2BEntries();
        }

        private void eigenbelegeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Eigenbelege window = new Eigenbelege();
            window.Show();
            this.Close();
        }

        private void eigenbelegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reparaturen window = new Reparaturen();
            window.Show();
            this.Close();
        }

        private void protokollierungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Protokollierung window = new Protokollierung();
            window.Show();
            this.Close();
        }

        private void proofingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Protokollierung window = new Protokollierung();
            window.Show();
            this.Close();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service window = new Service();
            window.Show();
            this.Close();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            ShowB2BEntries();
        }

        private void b2bDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            offerNumber = b2bDGV.SelectedRows[0].Cells[1].Value.ToString();
            offerType = b2bDGV.SelectedRows[0].Cells[2].Value.ToString();
            model = b2bDGV.SelectedRows[0].Cells[3].Value.ToString();
            buyPrice = b2bDGV.SelectedRows[0].Cells[4].Value.ToString();
            sellPrice = b2bDGV.SelectedRows[0].Cells[5].Value.ToString();
            reference = b2bDGV.SelectedRows[0].Cells[6].Value.ToString();
            storage = b2bDGV.SelectedRows[0].Cells[7].Value.ToString();
            condition = b2bDGV.SelectedRows[0].Cells[8].Value.ToString();
            original = b2bDGV.SelectedRows[0].Cells[9].Value.ToString();
            defect = b2bDGV.SelectedRows[0].Cells[10].Value.ToString();
            battery = b2bDGV.SelectedRows[0].Cells[11].Value.ToString();
            icloudLock = b2bDGV.SelectedRows[0].Cells[2].Value.ToString();
            packaging = b2bDGV.SelectedRows[0].Cells[13].Value.ToString();
            taxing = b2bDGV.SelectedRows[0].Cells[14].Value.ToString();

            lastSelectedEntry = (int)b2bDGV.SelectedRows[0].Cells[0].Value;
        }

        private void btn_eigenbelegRemove_Click(object sender, EventArgs e)
        {
            if (lastSelectedEntry == 0)
            {
                MessageBox.Show("Bitte wähle zuerst einen Eintrag aus");
                return;
            }
            string query = string.Format("DELETE FROM B2B WHERE Id = {0} ;", lastSelectedEntry);
            CRUDQueries.ExecuteQuery(query);
            ShowB2BEntries();
        }

        private void btn_SelectAllRows_Click(object sender, EventArgs e)
        {
            if (b2bDGV.AreAllCellsSelected(true) == true)
            {
                b2bDGV.ClearSelection();
                return;
            }
            b2bDGV.SelectAll();
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM `B2B`";
            CRUDQueries.ExecuteQuery(query);
            ShowB2BEntries();
        }

        private void btn_eigenbelegCreate_Click(object sender, EventArgs e)
        {
            using (var form = new B2BCreate())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ShowB2BEntries();
                }
            }
        }

        private void btn_eigenbelegEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedEntry == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus");
                return;
            }
            using (var form = new B2BEdit())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ShowB2BEntries();
                }
            }
        }

        private void Btn_CreateOffer_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
            string fileName = desktopPath+"B2Boffer.txt";
            FileStream fs = new FileStream(fileName,FileMode.Create);
            fs.Close();
            foreach (DataGridViewRow row in b2bDGV.SelectedRows)
            {
                if (b2bDGV.SelectedRows.Count == 1)
                {
                    File.AppendAllText(fileName, "\r\nAngebot " + offerNumber + " für " + sellPrice + "€\r\n- Angebotsform: " + offerType + "\r\n- Modell: " + model + "\r\n- Speicher: " + storage + "\r\n- Zustand: " + condition + "\r\n- Originalität: " + original + "\r\n- Defekt: " + defect + "\r\n- Akkuzustand: " + battery + "\r\n- iCloud: " + icloudLock + "\r\n- OVP?: " + packaging + "\r\n- Besteuerung: " + taxing + "\r\n____________");
                    break;
                }
                offerNumber = b2bDGV.SelectedRows[row.Index].Cells[1].Value.ToString();
                offerType = b2bDGV.SelectedRows[row.Index].Cells[2].Value.ToString();
                model = b2bDGV.SelectedRows[row.Index].Cells[3].Value.ToString();
                buyPrice = b2bDGV.SelectedRows[row.Index].Cells[4].Value.ToString();
                sellPrice = b2bDGV.SelectedRows[row.Index].Cells[5].Value.ToString();
                reference = b2bDGV.SelectedRows[row.Index].Cells[6].Value.ToString();
                storage = b2bDGV.SelectedRows[row.Index].Cells[7].Value.ToString();
                condition = b2bDGV.SelectedRows[row.Index].Cells[8].Value.ToString();
                original = b2bDGV.SelectedRows[row.Index].Cells[9].Value.ToString();
                defect = b2bDGV.SelectedRows[row.Index].Cells[10].Value.ToString();
                battery = b2bDGV.SelectedRows[row.Index].Cells[11].Value.ToString();
                icloudLock = b2bDGV.SelectedRows[row.Index].Cells[2].Value.ToString();
                packaging = b2bDGV.SelectedRows[row.Index].Cells[13].Value.ToString();
                taxing = b2bDGV.SelectedRows[row.Index].Cells[14].Value.ToString();
                File.AppendAllText(fileName, "\r\nAngebot " + offerNumber + " für "+ sellPrice + "€\r\n- Angebotsform: " + offerType + "\r\n- Modell: " + model + "\r\n- Speicher: " + storage + "\r\n- Zustand: " + condition + "\r\n- Originalität: " + original + "\r\n- Defekt: " + defect + "\r\n- Akkuzustand: " + battery + "\r\n- iCloud: " + icloudLock + "\r\n- OVP?: " + packaging + "\r\n- Besteuerung: " + taxing + "\r\n____________");
            }
            MessageBox.Show("Datei wurde erfolgreich erstellt.");
        }
    }
}
