using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CidadesInteligentes
{
    public partial class PessoaDocumento : Form
    {
        public PessoaDocumento()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeDoc.Text = "";
            txtEnderecoDoc.Text = "";
            cmEstadoDoc.Text = "";
            txtDataNascDoc.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtCTPS.Text = "";
            txtCNH.Text = "";
        }
    }
}
