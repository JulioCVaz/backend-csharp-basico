using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CidadesInteligentes
{
    public partial class Pessoa : Form
    {
        public Pessoa()
        {
            InitializeComponent();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            cbEstadoCivil.Text = "";
            masketData.Text = "";
            cbCidade.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string endereco = txtEndereco.Text;
            string estadocivil = cbEstadoCivil.Text;
            string data = masketData.Text;
            string cidade = cbCidade.SelectedText;
            int intcidade;
            if (cidade.Equals("São Paulo")) {
                intcidade = 1;
            }
            if (cidade.Equals("Rio de Janeiro")) {
                intcidade = 2;
            }
            if (cidade.Equals("Bahia")) {
                intcidade = 3;
            }
            if (cidade.Equals("Minas Gerais")) {
                intcidade = 4;
            }
            if (cidade.Equals("Rio Grande do Sul")) {
                intcidade = 5;
            }
            if (cidade.Equals("Paraná")) {
                intcidade = 6;
            }
            if (cidade.Equals("Pernambuco")) {
                intcidade = 7;
            }

            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=cidadeinteligente;Data Source=LAB-08-05";

            conexao.Open();

            string query = string.Concat("INSERT INTO pessoa(nome_pessoa,endereco_pessoa,estadoc_pessoa,datanasc_pessoa,estadocivil) VALUES (", nome, ",", endereco, ",", estadocivil, ",", data, ",", Convert.ToDecimal(intcidade), ");");

            SqlCommand pesquisarFuncSQL = new SqlCommand(query, conexao);

            conexao.Close();

        }
    }
}
