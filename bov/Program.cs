using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bovelo;

namespace bov
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserManager.CheckIfUserTableExists();
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //if (UserManager.CheckIfNewInstallation())
            //{
            //    Application.Run(new FirstUse());
            //}
            //else
            //{
            //    Application.Run(new Login());

            //}
            Application.Run(new workerschedule());
        }
    }
}
