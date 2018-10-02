using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastroEspecialista
{
    public partial class cadastroMedico : Form
    {
        public cadastroMedico()
        {
            InitializeComponent();
        }

        private void CadastrarPaciente()
        {
            string nome = txtNome.Text;
            string nasc = dtNasc.Text;
            string cpf = txtCpf.Text;
            string end = txtEnd.Text;
            string cep = txtCep.Text;
            string email = txtEmail.Text;


            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=consulta_medica;Data Source=LAB-07-01";

            conn.Open();

            string query = string.Concat("INSERT INTO clientes (nome_cliente,data_nasc,cpf,endereco,cep,email,funcionarioID) VALUES('",nome,"','",nasc,"','",cpf,"','",end,"','",cep,"','",email,"',", 2,");");

            SqlCommand execute = new SqlCommand(query, conn);

            execute.ExecuteNonQuery();


            MessageBox.Show("Paciente Cadastrado com sucesso");


            conn.Close();
        }

        private void LimparCampos() { 
            //TODO;
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarPaciente();
        }
    }
}
