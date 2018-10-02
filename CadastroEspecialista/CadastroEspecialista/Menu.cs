using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroEspecialista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            consultaPaciente screenPaciente = new consultaPaciente();
            screenPaciente.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            cadastroMedico screenCadastro = new cadastroMedico();
            screenCadastro.Show();
        }
    }
}
