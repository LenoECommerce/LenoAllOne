using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Internal;
using Microsoft.Office.Interop.Excel;
using MySqlX.XDevAPI.Relational;
using MySqlX.XDevAPI.Common;
using bpac;

namespace EigenbelegToolAlpha
{
    public partial class Reparaturen : Form
    {
        //SQL Verbindung zu Datenbank
        public static MySqlConnection conn;
        public static string connString = "SERVER=sql11.freesqldatabase.com;PORT=3306;Initial Catalog='sql11525524';username=sql11525524;password=d3ByMHVgie";
        public static int lastSelectedProductKey;
        public static string internalNumber = "";
        public static string dateBought = "";
        public static string device = "";
        public static string make = "";
        public static string storage = "";
        public static string defect = "";
        public static string transactionAmount = "";
        public static string imei = "";
        public static string externalCosts = "";
        public static string comment = "";
        public static string source = "";
        public static string riskLevel = "";
        public static string worthIt = "";
        public static string referenceToEB = "";
        public static string notifications = "";
        public static string tested = "";
        public static string state = "";
        public static string maindefects = "";
        public static string color = "";
        public static string taxes = "";
        public static string condition = "";
        public static string donorMonth = "";
        public static string fiveG = "";
        public static string externalCostsDiff = "";

        public Reparaturen()
        {
            InitializeComponent();
            ShowReparaturen();
        }

        public void ShowReparaturen()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();

            string query = "SELECT * FROM `Reparaturen`";
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, conn);

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            ////Datensatz
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            //Daten anzeigen im Grid
            reparaturenDGV.DataSource = dataSet.Tables[0];
            //Column verstecken
            reparaturenDGV.Columns[0].Visible = false;
            reparaturenDGV.Columns[23].Visible = false;
            reparaturenDGV.Columns[24].Visible = false;
            //Sortierte Ansicht
            reparaturenDGV.Sort(reparaturenDGV.Columns[1], ListSortDirection.Descending);
            conn.Close();
        }

        public void ShowReparaturenFiltered(string[] filterValueModel, string[] filterValueSource, string []filterValueRepairState)
        {
            conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();

            string query = "SELECT * FROM `Reparaturen`";
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, conn);

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            ////Datensatz
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            //Daten anzeigen im Grid
            reparaturenDGV.DataSource = dataSet.Tables[0];
            //Column verstecken
            reparaturenDGV.Columns[0].Visible = false;
            reparaturenDGV.Columns[23].Visible = false;
            reparaturenDGV.Columns[24].Visible = false;
            //Sortierte Ansicht
            reparaturenDGV.Sort(reparaturenDGV.Columns[1], ListSortDirection.Descending);
            //Filtern
            reparaturenDGV.CurrentCell = null;
            for (int i = 0; i < reparaturenDGV.RowCount; i++)
            {
                if (filterValueModel.Contains(reparaturenDGV.Rows[i].Cells[3].Value.ToString()) == true)
                {
                    if (filterValueSource.Contains(reparaturenDGV.Rows[i].Cells[19].Value.ToString()) == true)
                    {
                        if (filterValueRepairState.Contains(reparaturenDGV.Rows[i].Cells[18].Value.ToString()) == true)
                        {
                            reparaturenDGV.Rows[i].Visible = true;
                        }
                        else
                        {
                            reparaturenDGV.Rows[i].Visible = false;
                        }
                    }
                    else
                    {
                        reparaturenDGV.Rows[i].Visible = false;
                    }
                }
                else
                {
                    reparaturenDGV.Rows[i].Visible = false;
                }

            }
            conn.Close();
        }

        public static void ExecuteQuery(string query)
        {
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public static double ExecuteQueryWithResult(string query)
        {
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //zwischenspeichern und danach umformen um Fehlerquelle zu vermeiden
                var firstValueGetBack = cmd.ExecuteScalar();
                double result = Convert.ToDouble(firstValueGetBack);
                conn.Close();
                return result;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public static string ExecuteQueryWithResultForManualDataImport(string query)
        {
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //zwischenspeichern und danach umformen um Fehlerquelle zu vermeiden
                var firstValueGetBack = cmd.ExecuteScalar();
                var result = firstValueGetBack;
                conn.Close();
                if(result != null)
                {
                    return result.ToString();
                }
                return "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }


        public void SelectReparaturFromEigenbelege(string relatedNumber)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in reparaturenDGV.Rows)
            {
                if (row.Cells[22].Value.Equals(relatedNumber))
                {
                    rowIndex = row.Index;
                }   
            }
            if (rowIndex != -1)
            {
                reparaturenDGV.ClearSelection();
                reparaturenDGV.Rows[rowIndex].Selected = true;
                //bad workaroung, weil selection nicht erkannt wird als Klick
                internalNumber = reparaturenDGV.Rows[rowIndex].Cells[1].Value.ToString();
                dateBought = reparaturenDGV.Rows[rowIndex].Cells[2].Value.ToString();
                device = reparaturenDGV.Rows[rowIndex].Cells[3].Value.ToString();
                transactionAmount = reparaturenDGV.Rows[rowIndex].Cells[4].Value.ToString();
                imei = reparaturenDGV.Rows[rowIndex].Cells[5].Value.ToString();
                make = reparaturenDGV.Rows[rowIndex].Cells[6].Value.ToString();
                color = reparaturenDGV.Rows[rowIndex].Cells[7].Value.ToString();
                storage = reparaturenDGV.Rows[rowIndex].Cells[8].Value.ToString();
                taxes = reparaturenDGV.Rows[rowIndex].Cells[9].Value.ToString();
                condition = reparaturenDGV.Rows[rowIndex].Cells[10].Value.ToString();
                defect = reparaturenDGV.Rows[rowIndex].Cells[11].Value.ToString();
                maindefects = reparaturenDGV.Rows[rowIndex].Cells[12].Value.ToString();
                externalCosts = reparaturenDGV.Rows[rowIndex].Cells[13].Value.ToString();
                externalCostsDiff = reparaturenDGV.Rows[rowIndex].Cells[14].Value.ToString();
                comment = reparaturenDGV.Rows[rowIndex].Cells[15].Value.ToString();
                notifications = reparaturenDGV.Rows[rowIndex].Cells[16].Value.ToString();
                tested = reparaturenDGV.Rows[rowIndex].Cells[17].Value.ToString();
                state = reparaturenDGV.Rows[rowIndex].Cells[18].Value.ToString();
                source = reparaturenDGV.Rows[rowIndex].Cells[19].Value.ToString();
                riskLevel = reparaturenDGV.Rows[rowIndex].Cells[20].Value.ToString();
                worthIt = reparaturenDGV.Rows[rowIndex].Cells[21].Value.ToString();
                referenceToEB = reparaturenDGV.Rows[rowIndex].Cells[22].Value.ToString();
                fiveG = reparaturenDGV.Rows[rowIndex].Cells[24].Value.ToString();
                lastSelectedProductKey = (int)reparaturenDGV.Rows[rowIndex].Cells[0].Value;
                using (var form = new ReparaturenEdit())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        ShowReparaturen();
                    }
                }
            }

            else
            {
                MessageBox.Show("Es konnte kein Eintrag gefunden werden.");
            }

        }


        private void reparaturenDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            internalNumber = reparaturenDGV.SelectedRows[0].Cells[1].Value.ToString();
            dateBought = reparaturenDGV.SelectedRows[0].Cells[2].Value.ToString();
            device = reparaturenDGV.SelectedRows[0].Cells[3].Value.ToString();
            transactionAmount = reparaturenDGV.SelectedRows[0].Cells[4].Value.ToString();
            imei = reparaturenDGV.SelectedRows[0].Cells[5].Value.ToString();
            make = reparaturenDGV.SelectedRows[0].Cells[6].Value.ToString();
            color = reparaturenDGV.SelectedRows[0].Cells[7].Value.ToString();
            storage = reparaturenDGV.SelectedRows[0].Cells[8].Value.ToString();
            taxes = reparaturenDGV.SelectedRows[0].Cells[9].Value.ToString();
            condition = reparaturenDGV.SelectedRows[0].Cells[10].Value.ToString();
            defect = reparaturenDGV.SelectedRows[0].Cells[11].Value.ToString();
            maindefects = reparaturenDGV.SelectedRows[0].Cells[12].Value.ToString();
            externalCosts = reparaturenDGV.SelectedRows[0].Cells[13].Value.ToString();
            externalCostsDiff = reparaturenDGV.SelectedRows[0].Cells[14].Value.ToString();
            comment = reparaturenDGV.SelectedRows[0].Cells[15].Value.ToString();
            notifications = reparaturenDGV.SelectedRows[0].Cells[16].Value.ToString();
            tested = reparaturenDGV.SelectedRows[0].Cells[17].Value.ToString();
            state = reparaturenDGV.SelectedRows[0].Cells[18].Value.ToString();
            source = reparaturenDGV.SelectedRows[0].Cells[19].Value.ToString();
            riskLevel = reparaturenDGV.SelectedRows[0].Cells[20].Value.ToString();
            worthIt = reparaturenDGV.SelectedRows[0].Cells[21].Value.ToString();
            referenceToEB = reparaturenDGV.SelectedRows[0].Cells[22].Value.ToString();
            donorMonth = reparaturenDGV.SelectedRows[0].Cells[23].Value.ToString();
            fiveG = reparaturenDGV.SelectedRows[0].Cells[24].Value.ToString();

            lastSelectedProductKey = (int)reparaturenDGV.SelectedRows[0].Cells[0].Value;

        }

        private bool checkIfSelected()
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst einen Eintrag aus");
                return false;
            }
            else
            {
                return true;
            }
        }



        private void btn_settings_Click(object sender, EventArgs e)
        {
            Eigenbelege eigenbelege = new Eigenbelege();
            eigenbelege.Show();
            this.Hide();
        }

        private void btn_reparaturenDelete_Click(object sender, EventArgs e)
        {
            if (checkIfSelected() == false)
            {
                return;
            }
            string query = string.Format("DELETE FROM `Reparaturen` WHERE `Id` = {0} ;", lastSelectedProductKey);
            ExecuteQuery(query);

            ShowReparaturen();
        }

        

        private void btn_SelectAllRows_Click(object sender, EventArgs e)
        {
            if (reparaturenDGV.AreAllCellsSelected(true) == true)
            {
                reparaturenDGV.ClearSelection();
                return;
            }
            reparaturenDGV.SelectAll();
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM `Reparaturen`";
            ExecuteQuery(query);
            ShowReparaturen();
        }

        private void btn_reparaturenEdit_Click(object sender, EventArgs e)
        {
            if (checkIfSelected() == false)
            {
                return;
            }
            using (var form = new ReparaturenEdit())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ShowReparaturen();
                }
            }
        }

        private void Reparaturen_Load(object sender, EventArgs e)
        {
            ShowReparaturen();
        }

        private void reparaturenDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowReparaturen();
        }

        private void btn_reparaturenCreate_Click(object sender, EventArgs e)
        {
            using (var form = new ReparaturCreate())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ShowReparaturen();
                }
            }
        }

        internal class GetReparaturenDGV : DataGridView
        {
        }

        private void btn_SwitchToRelatedEigenbeleg_Click(object sender, EventArgs e)
        {
            if (checkIfSelected() == false)
            {
                return;
            }
            Eigenbelege eigenbelege = new Eigenbelege();
            eigenbelege.Show();
            this.Hide();
            eigenbelege.SelectEigenbelegeFromReparatur(referenceToEB);
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            Settings window = new Settings();
            window.Show();
        }

        public void BrotherPrintThisModell(int quantityOfCopies)
        {
            if (checkIfSelected() == false)
            {
                return;
            }
            try
            {
                string internPrefix = "";
                string zero = "0";
                string barcodeSKU = "APL/10.1/B64C/DIFF";
                string path = "";
                try
                {
                    path = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "TemplateModell", "Nutzer", Settings.currentUser);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bitte setze in den Einstellungen dein Template fest; Fehlermeldung:" + ex.Message);
                }

                //Abfrage wie lang interne Nummer, dann prefix anpassen!
                int lengthIntern = internalNumber.Length;
                int freeDigits = 5 - lengthIntern;
                for (int i = 0; i < freeDigits; i++)
                {
                    internPrefix = internPrefix + "0";
                }

                //SKU Generator in andere Klasse auslagern!
                SKUGeneration newObject = new SKUGeneration();
                barcodeSKU = newObject.SKUGenerationMethod(make, device, color, condition, taxes, storage, fiveG);

                string barcodeIMEICombo = internPrefix + internalNumber + "/" + imei;
                

                bpac.Document doc = new bpac.Document();
                doc.Open(path);
                doc.SetPrinter("Brother QL-600", true);

                var temp = doc.GetBarcodeIndex("SKU");
                var temp2 = doc.GetBarcodeIndex("IMEICombo");
                doc.SetBarcodeData(temp, barcodeSKU);
                doc.SetBarcodeData(temp2, barcodeIMEICombo);

                doc.StartPrint("", bpac.PrintOptionConstants.bpoDefault);
                doc.PrintOut(quantityOfCopies, bpac.PrintOptionConstants.bpoDefault);
                doc.EndPrint();
                doc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Print Error: " + ex.Message);
            }
        }

        private void platinenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hauptetikettToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrotherPrintThisModell(1);
        }

        private void btn_WorkWithSpecificReparatur_Click(object sender, EventArgs e)
        {
            using (var form = new WorkWithSpecificRep())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int rowIndex = -1;
                    foreach (DataGridViewRow row in reparaturenDGV.Rows)
                    {
                        if (row.Cells[5].Value.Equals(form.matchingValue))
                        {
                            rowIndex = row.Index;
                        }
                    }
                    if (rowIndex != -1)
                    {
                        reparaturenDGV.ClearSelection();
                        reparaturenDGV.Rows[rowIndex].Selected = true;
                        internalNumber = reparaturenDGV.Rows[rowIndex].Cells[1].Value.ToString();
                        dateBought = reparaturenDGV.Rows[rowIndex].Cells[2].Value.ToString();
                        device = reparaturenDGV.Rows[rowIndex].Cells[3].Value.ToString();
                        transactionAmount = reparaturenDGV.Rows[rowIndex].Cells[4].Value.ToString();
                        imei = reparaturenDGV.Rows[rowIndex].Cells[5].Value.ToString();
                        make = reparaturenDGV.Rows[rowIndex].Cells[6].Value.ToString();
                        color = reparaturenDGV.Rows[rowIndex].Cells[7].Value.ToString();
                        storage = reparaturenDGV.Rows[rowIndex].Cells[8].Value.ToString();
                        taxes = reparaturenDGV.Rows[rowIndex].Cells[9].Value.ToString();
                        condition = reparaturenDGV.Rows[rowIndex].Cells[10].Value.ToString();
                        defect = reparaturenDGV.Rows[rowIndex].Cells[11].Value.ToString();
                        maindefects = reparaturenDGV.Rows[rowIndex].Cells[12].Value.ToString();
                        externalCosts = reparaturenDGV.SelectedRows[0].Cells[13].Value.ToString();
                        externalCostsDiff = reparaturenDGV.SelectedRows[0].Cells[14].Value.ToString();
                        comment = reparaturenDGV.SelectedRows[0].Cells[15].Value.ToString();
                        notifications = reparaturenDGV.SelectedRows[0].Cells[16].Value.ToString();
                        tested = reparaturenDGV.SelectedRows[0].Cells[17].Value.ToString();
                        state = reparaturenDGV.SelectedRows[0].Cells[18].Value.ToString();
                        source = reparaturenDGV.SelectedRows[0].Cells[19].Value.ToString();
                        riskLevel = reparaturenDGV.SelectedRows[0].Cells[20].Value.ToString();
                        worthIt = reparaturenDGV.SelectedRows[0].Cells[21].Value.ToString();
                        referenceToEB = reparaturenDGV.SelectedRows[0].Cells[22].Value.ToString();
                        donorMonth = reparaturenDGV.SelectedRows[0].Cells[23].Value.ToString();
                        fiveG = reparaturenDGV.SelectedRows[0].Cells[24].Value.ToString();
                        lastSelectedProductKey = (int)reparaturenDGV.Rows[rowIndex].Cells[0].Value;
                        using (var form2 = new ReparaturenEdit())
                        {
                            var result2 = form2.ShowDialog();
                            if (result2 == DialogResult.OK)
                            {
                                ShowReparaturen();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Es konnte kein Eintrag gefunden werden.");
                    }
                }
            }
        }

        private void etikettenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            string query = "";
            ExecuteQuery(query);
        }

        private void eigenbelegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eigenbelege eigenbelege = new Eigenbelege();
            eigenbelege.Show();
            this.Hide();
        }

        private void protokollierungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Protokollierung window = new Protokollierung();
            window.Show();
            this.Hide();
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new ReparaturenFilter())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ShowReparaturenFiltered(form.selectedFilterModell, form.selectedFilterSource, form.selectedFilterRepairState);
                }
            }
        }

        private void xHauptetikettToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrotherPrintThisModell(2);
        }

        private void proofingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proofing window = new Proofing();
            window.Show();
            this.Hide();
        }

        private void auswertungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvaluationChoice window = new EvaluationChoice();
            window.Show();
        }

        private void sucheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new SearchAlgorithm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Collecting all rows with the matching term
                    string searchTerm = form.searchTerm.ToLower();
                    int cellCounter = reparaturenDGV.Rows[0].Cells.Count - 1;
                    int arrayIndexCounter = 0;
                    string[] matchingRows = new string[100];
                    foreach (DataGridViewRow row in reparaturenDGV.Rows)
                    {
                        var pos = row.Index;
                        for (int i = 1; i <= cellCounter; i++)
                        {
                            if (row.Cells[i].Value.ToString().ToLower().Contains(searchTerm))
                            {
                                if (SearchAlgorithm.CheckIfExists(pos, matchingRows) == false)
                                {
                                    matchingRows[arrayIndexCounter] = pos.ToString();
                                }
                            }
                        }
                        //Changing the visibility
                        if (matchingRows.Contains(pos.ToString()))
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            if (pos == 0)
                            {
                                reparaturenDGV.CurrentCell = null;
                                row.Visible = false;
                            }
                            else
                            {
                                row.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service window = new Service();
            window.Show();
            this.Hide();
        }

        private void b2BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            B2B window = new B2B();
            window.Show();
            this.Close();
        }
    }
}
