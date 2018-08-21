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
    public partial class Documentos : Form
    {
        public Documentos()
        {
            InitializeComponent();
        }

        private void Documentos_Load(object sender, EventArgs e)
        {
            List<ClienteDocumento> lista_doc = new List<ClienteDocumento>();

            ClienteDocumento cliente_doc1 = new ClienteDocumento();
            cliente_doc1.idDocumentoCliente = 1;
            cliente_doc1.CPF = "3124321";
            cliente_doc1.RG = "2412545";
            cliente_doc1.CNH = "34124535";
            cliente_doc1.tituloEleitor = "5325325";

            lista_doc.Add(cliente_doc1);

            ClienteDocumento cliente_doc2 = new ClienteDocumento();
            cliente_doc2.idDocumentoCliente = 2;
            cliente_doc2.CPF = "8694865";
            cliente_doc2.RG = "2532235";
            cliente_doc2.CNH = "8569799";
            cliente_doc2.tituloEleitor = "902385";

            lista_doc.Add(cliente_doc2);

            ClienteDocumento cliente_doc3 = new ClienteDocumento();
            cliente_doc3.idDocumentoCliente = 3;
            cliente_doc3.CPF = "5235325";
            cliente_doc3.RG = "5987259";
            cliente_doc3.CNH = "4352355";
            cliente_doc3.tituloEleitor = "12412432";

            lista_doc.Add(cliente_doc3);

            ClienteDocumento cliente_doc4 = new ClienteDocumento();
            cliente_doc4.idDocumentoCliente = 4;
            cliente_doc4.CPF = "729487324";
            cliente_doc4.RG = "3532553";
            cliente_doc4.CNH = "464234";
            cliente_doc4.tituloEleitor = "4143434";

            lista_doc.Add(cliente_doc4);

            ClienteDocumento cliente_doc5 = new ClienteDocumento();
            cliente_doc5.idDocumentoCliente = 5;
            cliente_doc5.CPF = "47219847";
            cliente_doc5.RG = "93247293";
            cliente_doc5.CNH = "2352666";
            cliente_doc5.tituloEleitor = "21412434";

            lista_doc.Add(cliente_doc5);

            dgvDocumentos.DataSource = lista_doc;

        }

 
    }
}
