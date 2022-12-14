using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EigenbelegToolAlpha
{
    internal static class Program
    {
        public static string currentUser = "";
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            //var s = File.ReadAllText("credentials.json");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CRUDQueries window = new CRUDQueries();
            StartMenu window2 = new StartMenu();

            //BillBeeAPIHandler.MainAccess();
            //PayPalAPIHandler.Main();

            if (window2.CheckUser() == false)
            {
                Application.Run(new StartMenu());
            }
            else
            {
                currentUser = ReturnCurrentUser();
                string preferedWindow = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "Standardfenster", "Nutzer", currentUser).ToString();
                VideoUpload();
                RunWindow(preferedWindow);

            }
            window.Backup();
        }

        private static void RunWindow (string window)
        {
            if (window == "Reparaturen")
            {
                Application.Run(new Reparaturen());
            }
            else if (window == "Eigenbelege")
            {
                Application.Run(new  Eigenbelege());
            }
            else if (window == "Protokollierung")
            {
                Application.Run(new Protokollierung());
            }
            else if (window == "Beweise")
            {
                Application.Run(new Proofing());
            }
            else
            {
                Application.Run(new Eigenbelege());
            }

        }
        public static void VideoUpload()
        {
            if (currentUser == "LennartLagerPC")
            {
                DateTime today = DateTime.Now;
                DateTime lastUpload = Convert.ToDateTime(CRUDQueries.ExecuteQueryWithResultString("Config","Nummer","Typ","LastVideoUpload"));
                if (today.Subtract(lastUpload).TotalDays >= 7)
                {
                    Proofing window = new Proofing();
                    window.VideoSync();
                }
            }
        }
        private static bool ExistsUserFile()
        {
            if (File.Exists(Environment.CurrentDirectory + @"\user.txt"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string ReturnCurrentUser()
        {
            string returnValue = "";
            try
            {
                returnValue = File.ReadAllText(Environment.CurrentDirectory + @"\user.txt");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return returnValue;
        }
    }
}
