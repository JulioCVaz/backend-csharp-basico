using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;

namespace EtecMetodoGenerics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Cliente> lista = new List<Cliente>();

            Cliente cliente1 = new Cliente();
            cliente1.codigoCliente = 1;
            cliente1.nmCliente = "Zezinho";
            cliente1.endereco = "Av Tal";
            cliente1.dtNascimento = Convert.ToDateTime("14-02-1980");
            cliente1.nrTelefone = "92353-4234";

            lista.Add(cliente1);

            Cliente cliente2 = new Cliente();
            cliente2.codigoCliente = 2;
            cliente2.nmCliente = "Luluzinha";
            cliente2.endereco = "Rua Jaime Barcelos";
            cliente2.dtNascimento = Convert.ToDateTime("18-09-1990");
            cliente2.nrTelefone = "954876132";

            lista.Add(cliente2);

            Cliente cliente3 = new Cliente();
            cliente3.codigoCliente = 3;
            cliente3.nmCliente = "Huguinho";
            cliente3.endereco = "Rua Katumi kida";
            cliente3.dtNascimento = Convert.ToDateTime("17-03-2000");
            cliente3.nrTelefone = "98745-6541";

            lista.Add(cliente3);

            Cliente cliente4 = new Cliente();
            cliente4.codigoCliente = 4;
            cliente4.nmCliente = "Rosinha";
            cliente4.endereco = "Rua Americo Sugai";
            cliente4.dtNascimento = Convert.ToDateTime("29-10-1999");
            cliente4.nrTelefone = "91458-6702";

            lista.Add(cliente4);

            Cliente cliente5 = new Cliente();
            cliente5.codigoCliente = 5;
            cliente5.nmCliente = "Joazinho";
            cliente5.endereco = "Av Imperador";

            lista.Add(cliente5);

            dgvClientes.DataSource = lista.Where(i => i.codigoCliente == 1).ToList();
     
        }

    }
}
