using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;
using System.Data.SqlClient;

namespace EtecMetodoGenerics
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }
        
        List<ClientePedido> lista_pedido = new List<ClientePedido>();
        
        private void Pedidos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid(){

            gdvPedidos.DataSource = null;
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(lista_pedido.Count.ToString());

            //CONSULTA USANDO GENERICS

            List<ClientePedido> ListaPesquisa = new List<ClientePedido>();
            ListaPesquisa = lista_pedido;

            //lista_pedido = lista_pedido.Where(i => i.nmProduto == txbNomeProduto.Text).ToList();
            ListaPesquisa = ListaPesquisa.Where(i => i.nmProduto.Contains(txbNomeProduto.Text) && i.marca.Contains(txbNomeMarca.Text)).ToList();
            

            gdvPedidos.DataSource = null;

            gdvPedidos.DataSource = ListaPesquisa;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNomeMarca.Text = string.Empty;
            txbNomeProduto.Text = "";
            txtNomeProd.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtPreco.Text = string.Empty;
            maskedTextBox1.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            ClientePedido pedido1 = new ClientePedido();
            pedido1.idPedido = 1;
            pedido1.nmProduto = txtNomeProd.Text;
            pedido1.marca = txtMarca.Text;
            pedido1.dtPedido = Convert.ToDateTime(maskedTextBox1.Text);
            pedido1.preco = txtPreco.Text;
            lista_pedido.Add(pedido1);

            gdvPedidos.DataSource = lista_pedido;
        }

    }
}
