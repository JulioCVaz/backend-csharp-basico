using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace somdegaragemHOME
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string table = "logins";
            string email = txtUsuario.Text;
            string senha = txtSenha.Text;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=somdegaragem;Data Source=LAB-06-09";
            conn.Open();

            string query = string.Concat("SELECT email, senha FROM ", table, " WHERE email = '", email, "' AND senha = '", senha, "' ;");

            SqlCommand execute = new SqlCommand(query, conn);

            execute.ExecuteNonQuery();

            SqlDataReader resultPsq = execute.ExecuteReader();

            string resultemail = "";
            string resultsenha = "";

            while (resultPsq.Read())
            {
                resultemail = (resultPsq.GetString(0));
                resultsenha = (resultPsq.GetString(1));
            };

            if (email.Equals(resultemail) && senha.Equals(resultsenha))
            {
                MessageBox.Show("Usuario logado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao localizar usuario");
            }

            conn.Close();
        }
    }
}
