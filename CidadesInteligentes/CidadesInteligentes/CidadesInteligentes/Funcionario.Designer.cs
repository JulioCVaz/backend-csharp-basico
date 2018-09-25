namespace CidadesInteligentes
{
    partial class Funcionario
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
            this.lblTituloFunc = new System.Windows.Forms.Label();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimparFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloFunc
            // 
            this.lblTituloFunc.AutoSize = true;
            this.lblTituloFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFunc.Location = new System.Drawing.Point(28, 35);
            this.lblTituloFunc.Name = "lblTituloFunc";
            this.lblTituloFunc.Size = new System.Drawing.Size(259, 25);
            this.lblTituloFunc.TabIndex = 0;
            this.lblTituloFunc.Text = "Cadastro de Funcionários";
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(33, 156);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(38, 13);
            this.lblNomeFunc.TabIndex = 1;
            this.lblNomeFunc.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Location = new System.Drawing.Point(34, 205);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(35, 13);
            this.lblSetor.TabIndex = 3;
            this.lblSetor.Text = "Setor:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(34, 255);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Salário:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 255);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(33, 98);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(78, 98);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(143, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(228, 94);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 9;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(36, 306);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(117, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnLimparFunc
            // 
            this.btnLimparFunc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimparFunc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimparFunc.Location = new System.Drawing.Point(159, 305);
            this.btnLimparFunc.Name = "btnLimparFunc";
            this.btnLimparFunc.Size = new System.Drawing.Size(128, 23);
            this.btnLimparFunc.TabIndex = 11;
            this.btnLimparFunc.Text = "Limpar";
            this.btnLimparFunc.UseVisualStyleBackColor = false;
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 395);
            this.Controls.Add(this.btnLimparFunc);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNomeFunc);
            this.Controls.Add(this.lblTituloFunc);
            this.Name = "Funcionario";
            this.Text = "Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloFunc;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimparFunc;
    }
}