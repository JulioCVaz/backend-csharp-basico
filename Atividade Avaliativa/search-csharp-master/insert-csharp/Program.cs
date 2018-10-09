using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace insert_csharp
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
            Application.Run(new verAluno());
        }

        public static string nomeConexao = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbAluno;Data Source=LAB-06-21";
    }
}
