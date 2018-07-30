namespace etec.ConsultorioMedico.UI
{
    partial class CadastroEleitor
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
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.lblRmEleitor = new System.Windows.Forms.Label();
            this.lblTituloeleitor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(311, 454);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(103, 23);
            this.btnCadastrarAluno.TabIndex = 25;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            // 
            // lblRmEleitor
            // 
            this.lblRmEleitor.AutoSize = true;
            this.lblRmEleitor.Location = new System.Drawing.Point(59, 160);
            this.lblRmEleitor.Name = "lblRmEleitor";
            this.lblRmEleitor.Size = new System.Drawing.Size(109, 13);
            this.lblRmEleitor.TabIndex = 17;
            this.lblRmEleitor.Text = "Digite o RM do eleitor";
            // 
            // lblTituloeleitor
            // 
            this.lblTituloeleitor.AutoSize = true;
            this.lblTituloeleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloeleitor.Location = new System.Drawing.Point(58, 54);
            this.lblTituloeleitor.Name = "lblTituloeleitor";
            this.lblTituloeleitor.Size = new System.Drawing.Size(188, 24);
            this.lblTituloeleitor.TabIndex = 14;
            this.lblTituloeleitor.Text = "Cadastro de Eleitor";
            this.lblTituloeleitor.Click += new System.EventHandler(this.lblTituloeleitor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 26;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(327, 155);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(131, 28);
            this.btnPesquisar.TabIndex = 27;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 231);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(315, 20);
            this.txtNome.TabIndex = 29;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(59, 234);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 287);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 20);
            this.textBox2.TabIndex = 31;
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(59, 290);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(69, 13);
            this.lblResponsavel.TabIndex = 30;
            this.lblResponsavel.Text = "Responsavel";
            // 
            // CadastroEleitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 517);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.lblRmEleitor);
            this.Controls.Add(this.lblTituloeleitor);
            this.Name = "CadastroEleitor";
            this.Text = "CadastroEleitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Label lblRmEleitor;
        private System.Windows.Forms.Label lblTituloeleitor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblResponsavel;
    }
}