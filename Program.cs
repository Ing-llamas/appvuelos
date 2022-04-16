using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            // Application.SetHighDpiMode(HighDpiMode.SystemAware);
            // Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PRESENTACION.Login frm = new PRESENTACION.Login();
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();

            Application.Run();


           // Application.Run(new PRESENTACION.Login());
        }

        private static void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

    }
}
