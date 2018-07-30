namespace etec.ConsultorioMedico.UI
{
    partial class CadastroVoto
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
            this.result = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnPesquisarCandidato = new System.Windows.Forms.Button();
            this.txtRMCandidato = new System.Windows.Forms.TextBox();
            this.btnCadastroVoto = new System.Windows.Forms.Button();
            this.lblRmCandidato = new System.Windows.Forms.Label();
            this.lblVoto = new System.Windows.Forms.Label();
            this.lblResultNome = new System.Windows.Forms.Label();
            this.lblResultResp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(137, 181);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 53;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(41, 181);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(87, 13);
            this.lblCodigo.TabIndex = 52;
            this.lblCodigo.Text = "codigoCandidato";
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(41, 294);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(69, 13);
            this.lblResponsavel.TabIndex = 50;
            this.lblResponsavel.Text = "Responsavel";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(41, 238);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 48;
            this.lblNome.Text = "Nome";
            // 
            // btnPesquisarCandidato
            // 
            this.btnPesquisarCandidato.Location = new System.Drawing.Point(321, 112);
            this.btnPesquisarCandidato.Name = "btnPesquisarCandidato";
            this.btnPesquisarCandidato.Size = new System.Drawing.Size(131, 28);
            this.btnPesquisarCandidato.TabIndex = 47;
            this.btnPesquisarCandidato.Text = "Pesquisar";
            this.btnPesquisarCandidato.UseVisualStyleBackColor = true;
            // 
            // txtRMCandidato
            // 
            this.txtRMCandidato.Location = new System.Drawing.Point(189, 117);
            this.txtRMCandidato.Name = "txtRMCandidato";
            this.txtRMCandidato.Size = new System.Drawing.Size(115, 20);
            this.txtRMCandidato.TabIndex = 46;
            // 
            // btnCadastroVoto
            // 
            this.btnCadastroVoto.Location = new System.Drawing.Point(189, 364);
            this.btnCadastroVoto.Name = "btnCadastroVoto";
            this.btnCadastroVoto.Size = new System.Drawing.Size(103, 23);
            this.btnCadastroVoto.TabIndex = 45;
            this.btnCadastroVoto.Text = "Registrar Voto";
            this.btnCadastroVoto.UseVisualStyleBackColor = true;
            // 
            // lblRmCandidato
            // 
            this.lblRmCandidato.AutoSize = true;
            this.lblRmCandidato.Location = new System.Drawing.Point(42, 120);
            this.lblRmCandidato.Name = "lblRmCandidato";
            this.lblRmCandidato.Size = new System.Drawing.Size(143, 13);
            this.lblRmCandidato.TabIndex = 44;
            this.lblRmCandidato.Text = "Digite o código do candidato";
            // 
            // lblVoto
            // 
            this.lblVoto.AutoSize = true;
            this.lblVoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoto.Location = new System.Drawing.Point(146, 36);
            this.lblVoto.Name = "lblVoto";
            this.lblVoto.Size = new System.Drawing.Size(188, 24);
            this.lblVoto.TabIndex = 43;
            this.lblVoto.Text = "Quadro de votação";
            this.lblVoto.Click += new System.EventHandler(this.lblVoto_Click);
            // 
            // lblResultNome
            // 
            this.lblResultNome.AutoSize = true;
            this.lblResultNome.Location = new System.Drawing.Point(83, 238);
            this.lblResultNome.Name = "lblResultNome";
            this.lblResultNome.Size = new System.Drawing.Size(0, 13);
            this.lblResultNome.TabIndex = 54;
            // 
            // lblResultResp
            // 
            this.lblResultResp.AutoSize = true;
            this.lblResultResp.Location = new System.Drawing.Point(117, 294);
            this.lblResultResp.Name = "lblResultResp";
            this.lblResultResp.Size = new System.Drawing.Size(0, 13);
            this.lblResultResp.TabIndex = 55;
            // 
            // CadastroVoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 451);
            this.Controls.Add(this.lblResultResp);
            this.Controls.Add(this.lblResultNome);
            this.Controls.Add(this.result);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnPesquisarCandidato);
            this.Controls.Add(this.txtRMCandidato);
            this.Controls.Add(this.btnCadastroVoto);
            this.Controls.Add(this.lblRmCandidato);
            this.Controls.Add(this.lblVoto);
            this.Name = "CadastroVoto";
            this.Text = "CadastroVoto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnPesquisarCandidato;
        private System.Windows.Forms.TextBox txtRMCandidato;
        private System.Windows.Forms.Button btnCadastroVoto;
        private System.Windows.Forms.Label lblRmCandidato;
        private System.Windows.Forms.Label lblVoto;
        private System.Windows.Forms.Label lblResultNome;
        private System.Windows.Forms.Label lblResultResp;
    }
}