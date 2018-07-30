namespace etec.ConsultorioMedico.UI
{
    partial class CadastroAluno
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
            this.lblTituloCadastro = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRm = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.comboAluno = new System.Windows.Forms.ComboBox();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblTituloCadastro
            // 
            this.lblTituloCadastro.AutoSize = true;
            this.lblTituloCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastro.Location = new System.Drawing.Point(50, 46);
            this.lblTituloCadastro.Name = "lblTituloCadastro";
            this.lblTituloCadastro.Size = new System.Drawing.Size(183, 24);
            this.lblTituloCadastro.TabIndex = 0;
            this.lblTituloCadastro.Text = "Cadastro de Aluno";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(51, 145);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 142);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(315, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblRm
            // 
            this.lblRm.AutoSize = true;
            this.lblRm.Location = new System.Drawing.Point(51, 104);
            this.lblRm.Name = "lblRm";
            this.lblRm.Size = new System.Drawing.Size(24, 13);
            this.lblRm.TabIndex = 3;
            this.lblRm.Text = "RM";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(51, 205);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(111, 205);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(296, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(51, 264);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(69, 13);
            this.lblResponsavel.TabIndex = 6;
            this.lblResponsavel.Text = "Responsavel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(51, 319);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(266, 319);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.Click += new System.EventHandler(this.lblSexo_Click);
            // 
            // comboAluno
            // 
            this.comboAluno.FormattingEnabled = true;
            this.comboAluno.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.comboAluno.Location = new System.Drawing.Point(303, 316);
            this.comboAluno.Name = "comboAluno";
            this.comboAluno.Size = new System.Drawing.Size(104, 21);
            this.comboAluno.TabIndex = 11;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(303, 476);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(103, 23);
            this.btnCadastrarAluno.TabIndex = 12;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(111, 316);
            this.maskedTextBox1.Mask = "(99) 0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(126, 20);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 567);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.comboAluno);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblRm);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTituloCadastro);
            this.Name = "CadastroAluno";
            this.Text = "CadastroAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCadastro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRm;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox comboAluno;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

