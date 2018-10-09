using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace insert_csharp
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.Equals("admin",txtUser.Text) && string.Equals("admin",txtSenha.Text))
            {
                this.Hide();
                verAluno v = new verAluno();
                v.Closed += (s, args) => this.Close();
                v.Show();

            }
            else {
                MessageBox.Show("Credenciais incorretas! (user: admin \\ senha: admin)");
            }
        }
    }
}
