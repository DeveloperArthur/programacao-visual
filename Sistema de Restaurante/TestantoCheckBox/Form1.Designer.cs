namespace TestantoCheckBox
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumMesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtQtdChopp = new System.Windows.Forms.TextBox();
            this.txtQtdPetiscos = new System.Windows.Forms.TextBox();
            this.txtQtdRefeicao = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtTaxaServico = new System.Windows.Forms.TextBox();
            this.txtTotalParcial = new System.Windows.Forms.TextBox();
            this.chkChopp = new System.Windows.Forms.CheckBox();
            this.chkRefeicao = new System.Windows.Forms.CheckBox();
            this.chkPetisco = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "N da Mesa";
            // 
            // txtNumMesa
            // 
            this.txtNumMesa.Location = new System.Drawing.Point(185, 55);
            this.txtNumMesa.Name = "txtNumMesa";
            this.txtNumMesa.Size = new System.Drawing.Size(100, 22);
            this.txtNumMesa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pedidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Parcial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total de serviços 8%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total a pagar";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(129, 328);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(110, 48);
            this.btnVerificar.TabIndex = 10;
            this.btnVerificar.Text = "Fechar conta";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtQtdChopp
            // 
            this.txtQtdChopp.Location = new System.Drawing.Point(218, 176);
            this.txtQtdChopp.Name = "txtQtdChopp";
            this.txtQtdChopp.Size = new System.Drawing.Size(100, 22);
            this.txtQtdChopp.TabIndex = 11;
            // 
            // txtQtdPetiscos
            // 
            this.txtQtdPetiscos.Location = new System.Drawing.Point(218, 221);
            this.txtQtdPetiscos.Name = "txtQtdPetiscos";
            this.txtQtdPetiscos.Size = new System.Drawing.Size(100, 22);
            this.txtQtdPetiscos.TabIndex = 12;
            // 
            // txtQtdRefeicao
            // 
            this.txtQtdRefeicao.Location = new System.Drawing.Point(217, 266);
            this.txtQtdRefeicao.Name = "txtQtdRefeicao";
            this.txtQtdRefeicao.Size = new System.Drawing.Size(100, 22);
            this.txtQtdRefeicao.TabIndex = 13;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(451, 278);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 22);
            this.txtTotalPagar.TabIndex = 14;
            // 
            // txtTaxaServico
            // 
            this.txtTaxaServico.Location = new System.Drawing.Point(451, 223);
            this.txtTaxaServico.Name = "txtTaxaServico";
            this.txtTaxaServico.Size = new System.Drawing.Size(100, 22);
            this.txtTaxaServico.TabIndex = 15;
            // 
            // txtTotalParcial
            // 
            this.txtTotalParcial.Location = new System.Drawing.Point(451, 163);
            this.txtTotalParcial.Name = "txtTotalParcial";
            this.txtTotalParcial.Size = new System.Drawing.Size(100, 22);
            this.txtTotalParcial.TabIndex = 16;
            // 
            // chkChopp
            // 
            this.chkChopp.AutoSize = true;
            this.chkChopp.Location = new System.Drawing.Point(63, 178);
            this.chkChopp.Name = "chkChopp";
            this.chkChopp.Size = new System.Drawing.Size(125, 21);
            this.chkChopp.TabIndex = 17;
            this.chkChopp.Text = "Chopp R$ 4,50";
            this.chkChopp.UseVisualStyleBackColor = true;
            // 
            // chkRefeicao
            // 
            this.chkRefeicao.AutoSize = true;
            this.chkRefeicao.Location = new System.Drawing.Point(63, 268);
            this.chkRefeicao.Name = "chkRefeicao";
            this.chkRefeicao.Size = new System.Drawing.Size(148, 21);
            this.chkRefeicao.TabIndex = 18;
            this.chkRefeicao.Text = "Refeição R$ 15,90";
            this.chkRefeicao.UseVisualStyleBackColor = true;
            // 
            // chkPetisco
            // 
            this.chkPetisco.AutoSize = true;
            this.chkPetisco.Location = new System.Drawing.Point(63, 223);
            this.chkPetisco.Name = "chkPetisco";
            this.chkPetisco.Size = new System.Drawing.Size(130, 21);
            this.chkPetisco.TabIndex = 19;
            this.chkPetisco.Text = "Petisco R$ 7,90";
            this.chkPetisco.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 438);
            this.Controls.Add(this.chkPetisco);
            this.Controls.Add(this.chkRefeicao);
            this.Controls.Add(this.chkChopp);
            this.Controls.Add(this.txtTotalParcial);
            this.Controls.Add(this.txtTaxaServico);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtQtdRefeicao);
            this.Controls.Add(this.txtQtdPetiscos);
            this.Controls.Add(this.txtQtdChopp);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumMesa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumMesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtQtdChopp;
        private System.Windows.Forms.TextBox txtQtdPetiscos;
        private System.Windows.Forms.TextBox txtQtdRefeicao;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtTaxaServico;
        private System.Windows.Forms.TextBox txtTotalParcial;
        private System.Windows.Forms.CheckBox chkChopp;
        private System.Windows.Forms.CheckBox chkRefeicao;
        private System.Windows.Forms.CheckBox chkPetisco;
    }
}

