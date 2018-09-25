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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;

            String senha = txtSenha.Text;
            
            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=cidadeinteligente;Data Source=LAB-07-05";
 
            conexao.Open();

            string comandoSQL = string.Concat("SELECT user_login, password_login FROM loginUser WHERE user_login='",login,"'");

            SqlCommand pesquisarFuncSQL = new SqlCommand(comandoSQL, conexao);

            SqlDataReader resultPsq = pesquisarFuncSQL.ExecuteReader();

            String auth = resultPsq.GetValue(0).ToString();

            if (auth.Length > 0)
            {
                MessageBox.Show("Login efetuado com sucesso");
             } else {
                MessageBox.Show("Login inválido");
            }
            

            conexao.Close();
        }

    }
}
