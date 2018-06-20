using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PrjCliente_conexao
{
    public partial class frm_Cadastro : Form
    {
        public frm_Cadastro()
        {
            InitializeComponent();
        }
        private void frm_Cadastro_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        OleDbConnection conn = Conexao.obterConexao();

        OleDbDataReader dr_clientes;

        BindingSource bs_clientes = new BindingSource();

        String _query;

        private void carregar_grid() {
            _query = "SELECT * FROM clientes";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_clientes = _dataCommand.ExecuteReader();
            if (dr_clientes.HasRows == true)
            {
                bs_clientes.DataSource = dr_clientes;
                dgv_clientes.DataSource = bs_clientes;
                igualar_text();

            }
            else {
                MessageBox.Show("Não possui clientes cadastrados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void igualar_text() {
            //TODO
        }

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            igualar_text();
        }

        private void dgv_clientes_KeyUp(object sender, DataGridViewKeyEventArgs e)
        {
            igualar_text();
        }

        
    }
}
