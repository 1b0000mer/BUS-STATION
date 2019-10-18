using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHAXE_ENTITIES
{
    static class Program
    {
        static void frmLogin()
        {
            Form frm = new frmLogin();
            frm.ShowDialog();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin();
            Application.Run(new frmMain());
        }
    }
}
