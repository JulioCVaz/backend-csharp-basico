namespace CidadesInteligentes
{
    partial class Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNameCliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEnderecoClientes = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtSexoClientes = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSelecioneEmpresa = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnLimparClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(392, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 321);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtNameCliente
            // 
            this.txtNameCliente.AutoSize = true;
            this.txtNameCliente.Location = new System.Drawing.Point(27, 96);
            this.txtNameCliente.Name = "txtNameCliente";
            this.txtNameCliente.Size = new System.Drawing.Size(38, 13);
            this.txtNameCliente.TabIndex = 2;
            this.txtNameCliente.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 3;
            // 
            // txtEnderecoClientes
            // 
            this.txtEnderecoClientes.AutoSize = true;
            this.txtEnderecoClientes.Location = new System.Drawing.Point(27, 138);
            this.txtEnderecoClientes.Name = "txtEnderecoClientes";
            this.txtEnderecoClientes.Size = new System.Drawing.Size(56, 13);
            this.txtEnderecoClientes.TabIndex = 4;
            this.txtEnderecoClientes.Text = "Endereço:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 20);
            this.textBox2.TabIndex = 5;
            // 
            // txtSexoClientes
            // 
            this.txtSexoClientes.AutoSize = true;
            this.txtSexoClientes.Location = new System.Drawing.Point(27, 178);
            this.txtSexoClientes.Name = "txtSexoClientes";
            this.txtSexoClientes.Size = new System.Drawing.Size(32, 13);
            this.txtSexoClientes.TabIndex = 6;
            this.txtSexoClientes.Text = "sexo:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Empresa 1",
            "Empresa 2",
            "Empresa 3",
            "Empresa 4",
            "Empresa 5",
            "Empresa 6",
            "Empresa 7",
            "Empresa 8"});
            this.listBox1.Location = new System.Drawing.Point(30, 238);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 95);
            this.listBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // txtSelecioneEmpresa
            // 
            this.txtSelecioneEmpresa.AutoSize = true;
            this.txtSelecioneEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecioneEmpresa.Location = new System.Drawing.Point(27, 222);
            this.txtSelecioneEmpresa.Name = "txtSelecioneEmpresa";
            this.txtSelecioneEmpresa.Size = new System.Drawing.Size(129, 13);
            this.txtSelecioneEmpresa.TabIndex = 10;
            this.txtSelecioneEmpresa.Text = "Selecione a empresa:";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(30, 343);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(126, 23);
            this.btnCadastrarCliente.TabIndex = 11;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            // 
            // btnLimparClientes
            // 
            this.btnLimparClientes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimparClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimparClientes.Location = new System.Drawing.Point(163, 342);
            this.btnLimparClientes.Name = "btnLimparClientes";
            this.btnLimparClientes.Size = new System.Drawing.Size(142, 23);
            this.btnLimparClientes.TabIndex = 12;
            this.btnLimparClientes.Text = "Limpar";
            this.btnLimparClientes.UseVisualStyleBackColor = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 395);
            this.Controls.Add(this.btnLimparClientes);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.txtSelecioneEmpresa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtSexoClientes);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtEnderecoClientes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNameCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtNameCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtEnderecoClientes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtSexoClientes;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txtSelecioneEmpresa;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnLimparClientes;
    }
}