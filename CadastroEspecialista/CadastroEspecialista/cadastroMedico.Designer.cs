namespace CadastroEspecialista
{
    partial class cadastroMedico
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Pacientes";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(46, 122);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(46, 164);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(105, 13);
            this.lblDataNasc.TabIndex = 2;
            this.lblDataNasc.Text = "Data de nascimento:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(46, 203);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(49, 240);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(392, 122);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(34, 13);
            this.lblCargo.TabIndex = 6;
            this.lblCargo.Text = "CEP: ";
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(393, 163);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(38, 13);
            this.lblEspecialidade.TabIndex = 7;
            this.lblEspecialidade.Text = "E-mail:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 122);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(257, 20);
            this.txtNome.TabIndex = 8;
            // 
            // dtNasc
            // 
            this.dtNasc.Location = new System.Drawing.Point(158, 164);
            this.dtNasc.Mask = "00/00/0000";
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(190, 20);
            this.dtNasc.TabIndex = 9;
            this.dtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(83, 203);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(265, 20);
            this.txtCpf.TabIndex = 10;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(112, 240);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(236, 20);
            this.txtEnd.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(226, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Efetuar Cadastro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(433, 122);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(253, 20);
            this.txtCep.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(433, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // cadastroMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 383);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.dtNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEspecialidade);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Name = "cadastroMedico";
            this.Text = "COSMOS - Cadastro de Especialistas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox dtNasc;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

