namespace CidadesInteligentes
{
    partial class PessoaDocumento
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblTituloDoc = new System.Windows.Forms.Label();
            this.lblNomeDoc = new System.Windows.Forms.Label();
            this.lblEnderecoDoc = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblCTPS = new System.Windows.Forms.Label();
            this.lblCNH = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNomeDoc = new System.Windows.Forms.TextBox();
            this.txtEnderecoDoc = new System.Windows.Forms.TextBox();
            this.cmEstadoDoc = new System.Windows.Forms.ComboBox();
            this.txtDataNascDoc = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCTPS = new System.Windows.Forms.TextBox();
            this.txtCNH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquise por nome ou código";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(313, 64);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(120, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblTituloDoc
            // 
            this.lblTituloDoc.AutoSize = true;
            this.lblTituloDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDoc.Location = new System.Drawing.Point(545, 36);
            this.lblTituloDoc.Name = "lblTituloDoc";
            this.lblTituloDoc.Size = new System.Drawing.Size(255, 25);
            this.lblTituloDoc.TabIndex = 4;
            this.lblTituloDoc.Text = "Cadastro de Documentos";
            // 
            // lblNomeDoc
            // 
            this.lblNomeDoc.AutoSize = true;
            this.lblNomeDoc.Location = new System.Drawing.Point(479, 115);
            this.lblNomeDoc.Name = "lblNomeDoc";
            this.lblNomeDoc.Size = new System.Drawing.Size(38, 13);
            this.lblNomeDoc.TabIndex = 5;
            this.lblNomeDoc.Text = "Nome:";
            // 
            // lblEnderecoDoc
            // 
            this.lblEnderecoDoc.AutoSize = true;
            this.lblEnderecoDoc.Location = new System.Drawing.Point(479, 156);
            this.lblEnderecoDoc.Name = "lblEnderecoDoc";
            this.lblEnderecoDoc.Size = new System.Drawing.Size(56, 13);
            this.lblEnderecoDoc.TabIndex = 6;
            this.lblEnderecoDoc.Text = "Endereço:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(479, 197);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 7;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(479, 237);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(107, 13);
            this.lblDataNasc.TabIndex = 8;
            this.lblDataNasc.Text = "Data de Nascimento:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(479, 305);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 9;
            this.lblRG.Text = "RG:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(479, 337);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 10;
            this.lblCPF.Text = "CPF:";
            // 
            // lblCTPS
            // 
            this.lblCTPS.AutoSize = true;
            this.lblCTPS.Location = new System.Drawing.Point(479, 368);
            this.lblCTPS.Name = "lblCTPS";
            this.lblCTPS.Size = new System.Drawing.Size(38, 13);
            this.lblCTPS.TabIndex = 11;
            this.lblCTPS.Text = "CTPS:";
            // 
            // lblCNH
            // 
            this.lblCNH.AutoSize = true;
            this.lblCNH.Location = new System.Drawing.Point(479, 402);
            this.lblCNH.Name = "lblCNH";
            this.lblCNH.Size = new System.Drawing.Size(33, 13);
            this.lblCNH.TabIndex = 12;
            this.lblCNH.Text = "CNH:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(513, 468);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(165, 23);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "Atualizar Dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(684, 468);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(165, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // txtNomeDoc
            // 
            this.txtNomeDoc.Location = new System.Drawing.Point(523, 112);
            this.txtNomeDoc.Name = "txtNomeDoc";
            this.txtNomeDoc.Size = new System.Drawing.Size(326, 20);
            this.txtNomeDoc.TabIndex = 15;
            // 
            // txtEnderecoDoc
            // 
            this.txtEnderecoDoc.Location = new System.Drawing.Point(542, 153);
            this.txtEnderecoDoc.Name = "txtEnderecoDoc";
            this.txtEnderecoDoc.Size = new System.Drawing.Size(307, 20);
            this.txtEnderecoDoc.TabIndex = 16;
            // 
            // cmEstadoDoc
            // 
            this.cmEstadoDoc.FormattingEnabled = true;
            this.cmEstadoDoc.Location = new System.Drawing.Point(550, 189);
            this.cmEstadoDoc.Name = "cmEstadoDoc";
            this.cmEstadoDoc.Size = new System.Drawing.Size(187, 21);
            this.cmEstadoDoc.TabIndex = 17;
            // 
            // txtDataNascDoc
            // 
            this.txtDataNascDoc.Location = new System.Drawing.Point(592, 234);
            this.txtDataNascDoc.Mask = "00/00/0000";
            this.txtDataNascDoc.Name = "txtDataNascDoc";
            this.txtDataNascDoc.Size = new System.Drawing.Size(144, 20);
            this.txtDataNascDoc.TabIndex = 18;
            this.txtDataNascDoc.ValidatingType = typeof(System.DateTime);
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(523, 305);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(326, 20);
            this.txtRG.TabIndex = 19;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(523, 337);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(326, 20);
            this.txtCPF.TabIndex = 20;
            // 
            // txtCTPS
            // 
            this.txtCTPS.Location = new System.Drawing.Point(524, 368);
            this.txtCTPS.Name = "txtCTPS";
            this.txtCTPS.Size = new System.Drawing.Size(325, 20);
            this.txtCTPS.TabIndex = 21;
            // 
            // txtCNH
            // 
            this.txtCNH.Location = new System.Drawing.Point(524, 402);
            this.txtCNH.Name = "txtCNH";
            this.txtCNH.Size = new System.Drawing.Size(325, 20);
            this.txtCNH.TabIndex = 22;
            // 
            // PessoaDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 575);
            this.Controls.Add(this.txtCNH);
            this.Controls.Add(this.txtCTPS);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtDataNascDoc);
            this.Controls.Add(this.cmEstadoDoc);
            this.Controls.Add(this.txtEnderecoDoc);
            this.Controls.Add(this.txtNomeDoc);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblCNH);
            this.Controls.Add(this.lblCTPS);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblEnderecoDoc);
            this.Controls.Add(this.lblNomeDoc);
            this.Controls.Add(this.lblTituloDoc);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PessoaDocumento";
            this.Text = "PessoaDocumento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblTituloDoc;
        private System.Windows.Forms.Label lblNomeDoc;
        private System.Windows.Forms.Label lblEnderecoDoc;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblCTPS;
        private System.Windows.Forms.Label lblCNH;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtNomeDoc;
        private System.Windows.Forms.TextBox txtEnderecoDoc;
        private System.Windows.Forms.ComboBox cmEstadoDoc;
        private System.Windows.Forms.MaskedTextBox txtDataNascDoc;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtCTPS;
        private System.Windows.Forms.TextBox txtCNH;
    }
}