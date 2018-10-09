using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace insert_csharp
{
    public partial class verAluno : Form
    {
        public verAluno()
        {
            InitializeComponent();
        }

        public void cadAluno(int idAluno, string rgAluno, string cpfAluno, string dsEndereco, string nmAluno, string foneAluno, string curso)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.nomeConexao;          
            conn.Open();


            string query = "";

            if (idAluno == 0)
            {
                query = String.Concat("insert into aluno(rgAluno,cpfAluno , dsEndereco, nmAluno, foneAluno, curso) values ('", rgAluno, "','", cpfAluno, "','", dsEndereco, "','", nmAluno, "','", foneAluno, "','", curso, "')");
            }
            else
            {
                query = String.Concat("update aluno set"); 
            }
            SqlCommand comandaSQL = new SqlCommand(query, conn);
            comandaSQL.ExecuteNonQuery();
            conn.Close();
        }
            private void limparCampos()
            {
                txtRg.Text = "";
                txtCpf.Text = "";
                txtEndereco.Text = "";
                txtNome.Text = "";
                txtTelefone.Text = "";
                txtCurso.Text = "";
            }

            private void btnCadastrar_Click_1(object sender, EventArgs e)
            {
                cadAluno(int.Parse(txtIdAluno.Text), txtRg.Text, txtCpf.Text, txtEndereco.Text, txtNome.Text, txtTelefone.Text, txtCurso.Text);
                limparCampos();
                MessageBox.Show("Registro cadastrado", "Cadastrado");
                retornarAlunos();
            }

            private void btnLimpar_Click_1(object sender, EventArgs e)
            {
                txtRg.Text = "";
                txtCpf.Text = "";
                txtEndereco.Text = "";
                txtNome.Text = "";
                txtTelefone.Text = "";
                txtCurso.Text = "";
            }

            public void retornarAlunos()
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = Program.nomeConexao;
                conexao.Open();

                //idAluno, rgAluno, cpfAluno, dsEndereco, nmAluno, foneAluno, curso
                string comandoSQL = "SELECT idAluno 'Código Aluno', nmAluno 'Nome', cpfAluno 'CPF Aluno', dsEndereco 'Endereço', rgAluno 'RG', foneAluno 'Telefone', curso 'Curso' FROM Aluno";

                SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                dgvAluno.DataSource = dt;

                conexao.Close();
            }
 
            public void buscarAluno() {
                DataSet ds = new DataSet();
                SqlConnection conexao = null;

                try
                {
                    conexao = new SqlConnection(Program.nomeConexao);
                    conexao.Open();
                    SqlCommand cmd = new SqlCommand("sp_RetornarAluno", conexao);
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (txtBuscarAluno.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@nmAluno", txtBuscarAluno.Text);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    dgvAluno.DataSource = ds.Tables[0];

                }
                catch (Exception e)
                {
                    MessageBox.Show("Falha na conexão! Caso o erro persista, contate o administrador.", "Erro!");
                }
                finally
                {
                    conexao.Close();
                }
            }

            private void btnBuscar_Click(object sender, EventArgs e)
            {
                buscarAluno();
            }

            private void verAluno_Load(object sender, EventArgs e)
            {
                retornarAlunos();
            }


            private void dgvAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                txtIdAluno.Text = dgvAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCpf.Text = dgvAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEndereco.Text = dgvAluno.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtRg.Text = dgvAluno.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTelefone.Text = dgvAluno.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCurso.Text = dgvAluno.Rows[e.RowIndex].Cells[6].Value.ToString();
            }



            

        
    }
}
