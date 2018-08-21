using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;

namespace EtecMetodoGenerics
{
    public partial class CadastrarCliente : Form
    {
        List<Cliente> listaClientesCadastrados = new List<Cliente>();

        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente clienteCadastro = new Cliente();
            clienteCadastro.codigoCliente = Convert.ToInt32(txtCodigoCliente.Text);
            clienteCadastro.nmCliente = txtNomeCliente.Text;

            listaClientesCadastrados.Add(clienteCadastro);

        }
    }
}
