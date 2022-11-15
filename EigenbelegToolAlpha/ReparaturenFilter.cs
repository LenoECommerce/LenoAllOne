using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EigenbelegToolAlpha
{
    public partial class ReparaturenFilter : Form
    {
        public ReparaturenFilter()
        {
            InitializeComponent();
        }
        public string filterModel = "";
        public string filterSource = "";
        public string filterRepairState = "";
        public string[] selectedFilterModell = new string[100];
        public string[] selectedFilterSource = new string[100];
        public string[] selectedFilterRepairState = new string[100];

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            filterModel = comboBox_filterModell.Text;
            filterSource = comboBox_filterSource.Text;
            filterRepairState = comboBox_filterRepairState.Text;
            if (SaveValuesFromComboboxIntoArray(filterModel, comboBox_filterModell, selectedFilterModell) == null)
            {
                selectedFilterModell[0] = filterModel;
            }
            if (SaveValuesFromComboboxIntoArray(filterSource, comboBox_filterSource, selectedFilterSource) == null)
            {
                selectedFilterSource[0] = filterSource;
            }
            if (SaveValuesFromComboboxIntoArray(filterRepairState, comboBox_filterRepairState, selectedFilterRepairState) == null)
            {
                selectedFilterRepairState[0] = filterRepairState;
            }
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
        private string[] SaveValuesFromComboboxIntoArray(string checkFilter, dynamic control, string[] filledArray)
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
        private void ReparaturenFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
