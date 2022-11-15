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
using System.Security.Cryptography;


namespace EigenbelegToolAlpha
{
    public partial class Settings : Form
    {
        public static string currentUser = File.ReadAllText("user.txt");
        public string valueIntern = CRUDQueries.ExecuteQueryWithResult("Config", "Nummer", "Typ", "InterneNummer").ToString();
        public string valueEigenbelegNumber = CRUDQueries.ExecuteQueryWithResult("Config", "Nummer", "Typ", "Eigenbelegnummer").ToString();
        public string defaultStartingWindow = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "Standardfenster", "Nutzer", currentUser).ToString();
        public string folderLocation;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBox_SettingsEigenbelegNummer.Text = valueEigenbelegNumber;
            textBox_SettingsInternalNumber.Text = valueIntern;
            comboBox_PreferdStartWindow.Text = defaultStartingWindow;

            string modellTemplate = CRUDQueries.ExecuteQueryWithResultString("ConfigUser","TemplateModell","Nutzer", currentUser);
            lbl_currentPathModellTemplate.Text = modellTemplate;
            string displayTemplate = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "TemplateDisplay", "Nutzer", currentUser);
            lbl_currentPathDisplayTemplate.Text = displayTemplate;
            string platineTemplate = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "TemplatePlatine", "Nutzer", currentUser);
            lbl_currentPathPlatinenTemplate.Text = platineTemplate;
            string sonstigeTeileTemplate = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "TemplateSonstigeTeile", "Nutzer", currentUser);
            lbl_currentPathSonstigesTemplate.Text = sonstigeTeileTemplate;
            string saveLocationEB = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "PathSaveLocationEB", "Nutzer", currentUser);
            lbl_SaveLocationPDF.Text = saveLocationEB;
            string sourceImages = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "PathImagesEB", "Nutzer", currentUser);
            lbl_SourceImages.Text = sourceImages;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUDQueries.ExecuteQuery("UPDATE `Config` SET `Nummer` = " + textBox_SettingsEigenbelegNummer.Text + " WHERE `Typ` = 'Eigenbelegnummer'");
            CRUDQueries.ExecuteQuery("UPDATE `Config` SET `Nummer` = " + textBox_SettingsInternalNumber.Text + " WHERE `Typ` = 'InterneNummer'");
            CRUDQueries.ExecuteQuery("UPDATE `ConfigUser` SET `Standardfenster` = '" + comboBox_PreferdStartWindow.Text + "' WHERE `Nutzer` = '"+currentUser+"'");
            MessageBox.Show("Deine Einstellungen wurden gespeichert.");
            this.Hide();
        }

        private void btn_SetTemplateModell_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_currentPathModellTemplate_Click(object sender, EventArgs e)
        {
            openFD.ShowDialog();
            string selectedFileName = openFD.FileName;
            selectedFileName = selectedFileName.Replace(@"\", @"\\");
            CRUDQueries.ExecuteQuery("UPDATE `ConfigUser` SET `TemplateModell` = '" + selectedFileName + "' WHERE `Nutzer` = '"+ currentUser + "'");
            lbl_currentPathModellTemplate.Text = selectedFileName;
        }

        private void lbl_currentPathDisplayTemplate_Click(object sender, EventArgs e)
        {
            openFD.ShowDialog();
            string selectedFileName = openFD.FileName;
            selectedFileName = selectedFileName.Replace(@"\", @"\\");
            CRUDQueries.ExecuteQuery("UPDATE `ConfigUser` SET `TemplateDisplay` = '" + selectedFileName + "' WHERE `Nutzer` = '" + currentUser + "'");
            lbl_currentPathDisplayTemplate.Text = selectedFileName;
        }

        private void lbl_currentPathPlatinenTemplate_Click(object sender, EventArgs e)
        {
            openFD.ShowDialog();
            string selectedFileName = openFD.FileName;
            selectedFileName = selectedFileName.Replace(@"\", @"\\");
            CRUDQueries.ExecuteQuery("UPDATE `ConfigUser` SET `TemplatePlatine` = '" + selectedFileName + "' WHERE `Nutzer` = '" + currentUser + "'");
            lbl_currentPathPlatinenTemplate.Text = selectedFileName;
        }

        private void lbl_currentPathSonstigesTemplate_Click(object sender, EventArgs e)
        {
            openFD.ShowDialog();
            string selectedFileName = openFD.FileName;
            selectedFileName = selectedFileName.Replace(@"\", @"\\");
            CRUDQueries.ExecuteQuery("UPDATE `ConfigUser` SET `TemplateSonstigeTeile` = '" + selectedFileName + "' WHERE `Nutzer` = '" + currentUser + "'");
            lbl_currentPathSonstigesTemplate.Text = selectedFileName;
        }

        private void btn_LocationTemplates_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            string selectedDirectory = folderDialog.SelectedPath;
            selectedDirectory = selectedDirectory.Replace(@"\", @"\\");
            CRUDQueries.ExecuteQuery("UPDATE `ConfigUser` SET `PathSaveLocationEB` = '" + selectedDirectory + "' WHERE `Nutzer` = '" + currentUser + "'");
            lbl_SaveLocationPDF.Text = selectedDirectory;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            string selectedDirectory = folderDialog.SelectedPath;
            selectedDirectory = selectedDirectory.Replace(@"\", @"\\");
            CRUDQueries.ExecuteQuery("UPDATE `ConfigUser` SET `PathImagesEB` = '" + selectedDirectory + "' WHERE `Nutzer` = '" + currentUser + "'");
            lbl_SourceImages.Text = selectedDirectory;
        }

        private void textBox_SettingsInternalNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
