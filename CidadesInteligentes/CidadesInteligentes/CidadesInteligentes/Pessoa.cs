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
            string cidade = cbCidade.Text;

            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=cidadeinteligente;Data Source=LAB-07-05";

            conexao.Open();

            string query = string.Concat("INSERT INTO pessoa(nome_pessoa,endereco_pessoa,estadoc_pessoa,datanasc_pessoa,cidade) VALUES (", nome, ",", endereco, ",", estadocivil, ",", DateTime.Now, ",", cidade, ");");

            SqlCommand queryInsert = new SqlCommand(query, conexao);

            queryInsert.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Dados inseridos com sucesso");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
