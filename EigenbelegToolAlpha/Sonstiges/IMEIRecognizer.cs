using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Google.Apis.Drive.v3.Data;
using WindowsInput;
using WindowsInput.Native;
using System.Windows.Forms;

namespace EigenbelegToolAlpha
{
    public class IMEIRecognizer
    {
        public void Main ()
        {
            string currentUser = System.IO.File.ReadAllText(Environment.CurrentDirectory + @"\user.txt");
            OpenAndMinimizeApp(CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "PathSnagitExe", "Nutzer", currentUser));
            OpenAndMaximizeApp(CRUDQueries.ExecuteQueryWithResultString("ConfigUser", "PathElgatoCameraHubExe", "Nutzer", currentUser));
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
                string fileName = desktopPath + @"Screenshot_1.png";
                Thread.Sleep(3000);
                System.Windows.Forms.SendKeys.SendWait("{PRTSC}");
                Thread.Sleep(1000);
                System.Windows.Forms.SendKeys.SendWait("^s");
                Thread.Sleep(1000);
                System.Diagnostics.Process.Start(fileName);
                MaximizeCurrentApp();
                Thread.Sleep(1000);
                System.Windows.Forms.SendKeys.SendWait("{F9}");
                Thread.Sleep(1000);
                System.IO.File.Delete((fileName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void OpenAndMinimizeApp(string path)
        {
            System.Diagnostics.Process.Start(path);
            Thread.Sleep(2000);
            MinimizeCurrentApp();
        }
        public void OpenAndMaximizeApp(string path)
        {
            System.Diagnostics.Process.Start(path);
            Thread.Sleep(2000);
            MaximizeCurrentApp();
        }
        public void MinimizeCurrentApp()
        {
            var simu = new InputSimulator();
            simu.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.DOWN);
        }
        public void MaximizeCurrentApp()
        {
            var simu = new InputSimulator();
            simu.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.UP);
        }
    }
}
