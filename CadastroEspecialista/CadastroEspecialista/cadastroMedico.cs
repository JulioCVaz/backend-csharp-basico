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

        private void CadastrarMedico(string nmMedico, string dsEndereco)
        {
            SqlConnection conn = new SqlConnection();

            conn.Open();

            string InsertMedico = string.Concat("insert into tbMedico values ('", nmMedico, "', '", dsEndereco, "')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertMedico, conn);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            conn.Close();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarMedico(txtNome.Text, txtEndereco.Text);
            LimparCampos();
            MessageBox.Show("Registro cadastrado", "Etec ZL");
        }
    }
}
