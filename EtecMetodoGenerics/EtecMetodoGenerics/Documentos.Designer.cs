namespace EtecMetodoGenerics
{
    partial class Documentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvDocumentos = new System.Windows.Forms.DataGridView();
            this.clienteDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDocumentoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloEleitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDocumentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.AutoGenerateColumns = false;
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocumentoClienteDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.cNHDataGridViewTextBoxColumn,
            this.tituloEleitorDataGridViewTextBoxColumn});
            this.dgvDocumentos.DataSource = this.clienteDocumentoBindingSource;
            this.dgvDocumentos.Location = new System.Drawing.Point(32, 54);
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.Size = new System.Drawing.Size(546, 150);
            this.dgvDocumentos.TabIndex = 0;
            //this.dgvDocumentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentos_CellContentClick);
            // 
            // clienteDocumentoBindingSource
            // 
            this.clienteDocumentoBindingSource.DataSource = typeof(Classes.ClienteDocumento);
            // 
            // idDocumentoClienteDataGridViewTextBoxColumn
            // 
            this.idDocumentoClienteDataGridViewTextBoxColumn.DataPropertyName = "idDocumentoCliente";
            this.idDocumentoClienteDataGridViewTextBoxColumn.HeaderText = "idDocumentoCliente";
            this.idDocumentoClienteDataGridViewTextBoxColumn.Name = "idDocumentoClienteDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            // 
            // cNHDataGridViewTextBoxColumn
            // 
            this.cNHDataGridViewTextBoxColumn.DataPropertyName = "CNH";
            this.cNHDataGridViewTextBoxColumn.HeaderText = "CNH";
            this.cNHDataGridViewTextBoxColumn.Name = "cNHDataGridViewTextBoxColumn";
            // 
            // tituloEleitorDataGridViewTextBoxColumn
            // 
            this.tituloEleitorDataGridViewTextBoxColumn.DataPropertyName = "tituloEleitor";
            this.tituloEleitorDataGridViewTextBoxColumn.HeaderText = "tituloEleitor";
            this.tituloEleitorDataGridViewTextBoxColumn.Name = "tituloEleitorDataGridViewTextBoxColumn";
            // 
            // Documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 262);
            this.Controls.Add(this.dgvDocumentos);
            this.Name = "Documentos";
            this.Text = "Documentos";
            this.Load += new System.EventHandler(this.Documentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDocumentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocumentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocumentoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloEleitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clienteDocumentoBindingSource;
    }
}