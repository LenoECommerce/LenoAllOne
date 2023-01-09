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
    public partial class EigenbelegFilter : Form
    {
        public EigenbelegFilter()
        {
            InitializeComponent();
        }
        public string filterModell = "";
        public string filterCreated = "";
        public string filterPlatform = "";
        public string[] selectedFilterModell = new string[100];
        public string[] selectedFilterCreated = new string[100];
        public string[] selectedFilterPlatform = new string[100];



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            filterModell = comboBox_filterModell.Text;
            filterCreated = comboBox_FilterCreated.Text;
            filterPlatform = comboBox_filterPlatform.Text;
            if (SaveValuesFromComboboxIntoArray(filterModell, comboBox_filterModell, selectedFilterModell) == null)
            {
                selectedFilterModell[0] = filterModell;
            }
            if (SaveValuesFromComboboxIntoArray(filterCreated, comboBox_FilterCreated, selectedFilterCreated) == null)
            {
                selectedFilterCreated[0] = filterCreated;
            }
            if (SaveValuesFromComboboxIntoArray(filterPlatform, comboBox_filterPlatform, selectedFilterPlatform) == null)
            {
                selectedFilterPlatform[0] = filterPlatform;
            }
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private string [] SaveValuesFromComboboxIntoArray(string checkFilter, dynamic control, string[] filledArray)
        {
            if (checkFilter == "Alle")
            {
                int helpComboCounter = 1;
                int helpArrayCounter = 0;
                foreach (var item in control.Items)
                {
                    if (control.Items.Count == helpComboCounter)
                    {
                        break;
                    }
                    else
                    {
                        filledArray[helpArrayCounter] = control.Items[helpComboCounter].ToString();
                        helpComboCounter++;
                        helpArrayCounter++;
                    }
                }
                return filledArray;
            }
            return null;
        }

        private void EigenbelegFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
