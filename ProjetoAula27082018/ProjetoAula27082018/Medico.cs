using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace teste
{
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
        }

        private void CadastrarMedico(string nmMedico, string dsEndereco)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=Agenda;Data Source=LAB-08-21";

            //abrir conexão
            conexao.Open();
 
            //inseri texto de insert
            string InsertMedico = string.Concat("insert into tbMedico values ('",nmMedico,"', '", dsEndereco,"')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertMedico, conexao);
            
            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }

        private void LimparCampos()
        {
            txtNomeMedico.Text = "";
            txtEndereco.Text = "";
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarMedico(txtNomeMedico.Text, txtEndereco.Text);
            LimparCampos();
            MessageBox.Show("Registro cadastrado", "Etec ZL");
        }
    }
}
