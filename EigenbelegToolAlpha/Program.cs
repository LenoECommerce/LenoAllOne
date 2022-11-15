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
        //public static string currentUser = File.ReadAllText("user.txt");
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Eigenbelege());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            //CRUDQueries window = new CRUDQueries();
            //window.Backup();
            //StartMenu window2 = new StartMenu();
            //if (window2.CheckUser() == false)
            //{
            //    Application.Run(new StartMenu());
            //}
            //else
            //{
            //    string preferedWindow = CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "Standardfenster", "Nutzer", currentUser).ToString();
            //    RunWindow(preferedWindow);
            //}

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

        private static bool ExistsUserFile()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ @"\user.txt"))
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
