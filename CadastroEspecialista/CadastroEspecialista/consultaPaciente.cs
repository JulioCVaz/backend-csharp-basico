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
    public partial class consultaPaciente : Form
    {
        public consultaPaciente()
        {
            InitializeComponent();
        }

        private void buscaPaciente(string id) {

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=consulta_medica;Data Source=LAB-07-01";

            conn.Open();

            string query = string.Concat("SELECT nome_cliente, endereco, email FROM clientes WHERE id_cliente = ",id,";");

            SqlCommand execute = new SqlCommand(query, conn);

            execute.ExecuteNonQuery();

            SqlDataReader resultPsq = execute.ExecuteReader();
            while (resultPsq.Read())
            {
                lblNome.Text = (resultPsq.GetString(0));
                lblend.Text = (resultPsq.GetString(1));
                lblemail.Text = (resultPsq.GetString(2));
            }



            conn.Close();

            /*SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CidadeInteligente;Data Source=LAB-06-19";
            conexao.Open();
            string pesquisarFun = string.Concat("SELECT cdPessoa, nmPessoa FROM tb_pessoas where cdPessoa =", a, "");
            SqlCommand pesquisarFuncSQL = new SqlCommand(pesquisarFun, conexao);
            
            conexao.Close();
            */
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            buscaPaciente(id);
        }
    }
}
