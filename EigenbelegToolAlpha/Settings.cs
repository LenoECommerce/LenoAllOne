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
        public static string currentUser = File.ReadAllText(Environment.CurrentDirectory + @"\user.txt");
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

            lbl_currentPathModellTemplate.Text = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "TemplateModell", "Nutzer", currentUser);
            lbl_currentPathDisplayTemplate.Text = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "TemplateSellOff", "Nutzer", currentUser);
            textBox_pathsnagit.Text = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "PathSnagitExe", "Nutzer", currentUser);
            textBox_pathelgato.Text = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "PathElgatoCameraHubExe", "Nutzer", currentUser);
            lbl_SaveLocationPDF.Text = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "PathSaveLocationEB", "Nutzer", currentUser);
            lbl_SourceImages.Text = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "PathImagesEB", "Nutzer", currentUser);
            lbl_PathVideosUpload.Text = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "PathVideosForUpload", "Nutzer", currentUser);
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
            CRUDQueries.ExecuteQuery("UPDATE `ConfigUser` SET `TemplateSellOff` = '" + selectedFileName + "' WHERE `Nutzer` = '" + currentUser + "'");
            lbl_currentPathDisplayTemplate.Text = selectedFileName;
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

        private void lbl_PathVideosUpload_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            string selectedDirectory = folderDialog.SelectedPath;
            selectedDirectory = selectedDirectory.Replace(@"\", @"\\");
            CRUDQueries.ExecuteQuery("UPDATE `ConfigUser` SET `PathVideosForUpload` = '" + selectedDirectory + "' WHERE `Nutzer` = '" + currentUser + "'");
            lbl_PathVideosUpload.Text = selectedDirectory;
        }

        private void textBox_pathsnagit_TextChanged(object sender, EventArgs e)
        {
            string selectedFileName = textBox_pathsnagit.Text;
            selectedFileName = selectedFileName.Replace(@"\", @"\\");
            CRUDQueries.ExecuteQuery("UPDATE `ConfigUser` SET `PathSnagitExe` = '" + selectedFileName + "' WHERE `Nutzer` = '" + currentUser + "'");
        }

        private void textBox_pathelgato_TextChanged(object sender, EventArgs e)
        {
            string selectedFileName = textBox_pathelgato.Text;
            selectedFileName = selectedFileName.Replace(@"\", @"\\");
            CRUDQueries.ExecuteQuery("UPDATE `ConfigUser` SET `PathElgatoCameraHubExe` = '" + selectedFileName + "' WHERE `Nutzer` = '" + currentUser + "'");
        }
    }
}
