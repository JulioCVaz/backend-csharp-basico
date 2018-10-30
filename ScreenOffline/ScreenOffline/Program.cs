using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScreenOffline
{
    static class Program
    {
        public static string conexao = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=dboffline;Data Source=LAB-06-07";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
