using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;


namespace PrjCliente_conexao
{
    class Conexao
    {
        private static string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;
        Data Source=|DataDirectory|\BD_Cliente.accdb;Persist Security Info=False;";

        


        private static OleDbConnection conn = null;


        public static OleDbConnection obterConexao() {
            conn = new OleDbConnection(connString);
            try{
                conn.Open();
            }catch{
                conn = null;
                String error = "Erro com Banco de Dados";
                MessageBox.Show("Error => " + error);
            }
            return conn;
        }

        public static void fecharConexao() {
            if (conn != null)
            {
                conn.Close();
            }
        }


    }
}
