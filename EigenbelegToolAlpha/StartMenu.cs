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
using MySql.Data.MySqlClient;

namespace EigenbelegToolAlpha
{
    public partial class StartMenu : Form
    {
        public string basePath = Environment.CurrentDirectory + @"\user.txt";
        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }

        public bool CheckUser()
        {
            if (FileExists() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void comboBox_UserSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileExists() == true)
            {
                File.Create(basePath);
            }
            File.WriteAllText(basePath, comboBox_UserSelection.Text);
            this.Hide();
            Reparaturen window = new Reparaturen();
            window.Show();
        }

        private bool FileExists ()
        {
            if (File.Exists(basePath) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
