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

namespace EigenbelegToolAlpha
{
    public partial class RegularSalesAlgoOverview : Form
    {
        public RegularSalesAlgoOverview()
        {
            InitializeComponent();
        }

        private void RegularSalesAlgoOverview_Load(object sender, EventArgs e)
        {
            string table = "Config";
            string searchColum = "Nummer";
            lbl_lastDateUpdated.Text = CRUDQueries.ExecuteQueryWithResultString(table,searchColum,"Typ","LastRegularSalesAlgo");
            lbl_FreeAmount.Text = CRUDQueries.ExecuteQueryWithResultString(table, searchColum, "Typ", "RegularSalesFreeAmount") + "€";
            lbl_AmountAtLeast.Text = CRUDQueries.ExecuteQueryWithResultString(table, searchColum, "Typ", "RegularSalesAtLeastAmount") + "€";
            lbl_PayPalShare.Text = (100 - RegularSalesAlgoXSL.NonPayPalShare).ToString() + "%";
        }

        private void btn_Analyze_Click(object sender, EventArgs e)
        {
            openFD.ShowDialog();
            string fileName = openFD.FileName;
            RegularSalesAlgoXSL.Analyse(fileName);
            string querySub1 = "UPDATE `Config` SET `Nummer` = '" + DateTime.Now.ToString() + "' WHERE `Typ` = 'LastRegularSalesAlgo';";
            string querySub2 = "UPDATE `Config` SET `Nummer` = '" + RoundOneDigit(RegularSalesAlgoXSL.amountLeft).ToString() + "' WHERE `Typ` = 'RegularSalesFreeAmount';";
            string querySub3 = "UPDATE `Config` SET `Nummer` = '" + RoundOneDigit(RegularSalesAlgoXSL.amountAtLeast).ToString() + "' WHERE `Typ` = 'RegularSalesAtLeastAmount'";
            string queryMain = querySub1 + "\r\n" + querySub2 + "\r\n" + querySub3; 
            CRUDQueries.ExecuteQuery(queryMain);
            RegularSalesAlgoOverview_Load(sender,e);
        }
        public static double RoundOneDigit(double adaptValue)
        {
            string tempValue = adaptValue.ToString();
            if (tempValue.Contains(","))
            {
                var pos = tempValue.IndexOf(",");
                tempValue = tempValue.Substring(0, pos + 2);
                adaptValue = Convert.ToDouble(tempValue);
            }
            return adaptValue;
        }
    }
}
