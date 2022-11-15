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
        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }

        public bool CheckUser()
        {
            if (File.Exists("user.txt") == true)
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
            File.WriteAllText("user.txt",comboBox_UserSelection.Text);
            this.Hide();
            Reparaturen window = new Reparaturen();
            window.Show();
        }
    }
}
