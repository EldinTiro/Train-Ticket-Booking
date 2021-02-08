using eZeljeznice.WinUI.Korisnici;
using eZeljeznice.WinUI.Putovanja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eZeljeznice.WinUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin login = new frmLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {

                    Application.Run(new frmIndex());

            }
        }
    }
}
