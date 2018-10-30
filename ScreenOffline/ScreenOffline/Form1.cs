using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ScreenOffline
{
    public partial class Form1 : Form
    {
        // criar uma lista para armazenar uma lista na memoria
        private List<Funcionario> listaMemoria = new List<Funcionario>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // estancia um obj funcionario
            Funcionario func = new Funcionario();
            // pega os dados do input nome
            func.nmFuncionario = txtNome.Text;
            // adiciona o obj a list
            listaMemoria.Add(func);
            // atualiza o grid com os dados do input
            dgvFuncionario.DataSource = null;
            dgvFuncionario.DataSource = listaMemoria;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = Program.conexao;
            conn.Open();

            foreach (Funcionario item in listaMemoria)
            {
                string query = string.Concat("INSERT INTO aluno(nmFuncionario) VALUES ('",item.nmFuncionario,"')");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
            }

            MessageBox.Show("Dados inseridos no banco de dados");

            conn.Close();

            listaMemoria = new List<Funcionario>();

            dgvFuncionario.DataSource = null;
        }
    }
}
