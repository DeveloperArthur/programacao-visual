namespace mediaDeIdades
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
            this.lblIdade1 = new System.Windows.Forms.Label();
            this.lblIdade2 = new System.Windows.Forms.Label();
            this.lblIdade3 = new System.Windows.Forms.Label();
            this.txtIdade1 = new System.Windows.Forms.TextBox();
            this.txtIdade2 = new System.Windows.Forms.TextBox();
            this.txtIdade3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIdade1
            // 
            this.lblIdade1.AutoSize = true;
            this.lblIdade1.Location = new System.Drawing.Point(94, 31);
            this.lblIdade1.Name = "lblIdade1";
            this.lblIdade1.Size = new System.Drawing.Size(150, 17);
            this.lblIdade1.TabIndex = 0;
            this.lblIdade1.Text = "Digite a primeira idade";
            // 
            // lblIdade2
            // 
            this.lblIdade2.AutoSize = true;
            this.lblIdade2.Location = new System.Drawing.Point(94, 112);
            this.lblIdade2.Name = "lblIdade2";
            this.lblIdade2.Size = new System.Drawing.Size(154, 17);
            this.lblIdade2.TabIndex = 1;
            this.lblIdade2.Text = "Digite a segunda idade";
            // 
            // lblIdade3
            // 
            this.lblIdade3.AutoSize = true;
            this.lblIdade3.Location = new System.Drawing.Point(94, 193);
            this.lblIdade3.Name = "lblIdade3";
            this.lblIdade3.Size = new System.Drawing.Size(140, 17);
            this.lblIdade3.TabIndex = 2;
            this.lblIdade3.Text = "Digite a tereira idade";
            // 
            // txtIdade1
            // 
            this.txtIdade1.Location = new System.Drawing.Point(97, 60);
            this.txtIdade1.Name = "txtIdade1";
            this.txtIdade1.Size = new System.Drawing.Size(145, 22);
            this.txtIdade1.TabIndex = 3;
            // 
            // txtIdade2
            // 
            this.txtIdade2.Location = new System.Drawing.Point(97, 143);
            this.txtIdade2.Name = "txtIdade2";
            this.txtIdade2.Size = new System.Drawing.Size(145, 22);
            this.txtIdade2.TabIndex = 4;
            // 
            // txtIdade3
            // 
            this.txtIdade3.Location = new System.Drawing.Point(97, 226);
            this.txtIdade3.Name = "txtIdade3";
            this.txtIdade3.Size = new System.Drawing.Size(145, 22);
            this.txtIdade3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(94, 383);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 17);
            this.lblResposta.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 363);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdade3);
            this.Controls.Add(this.txtIdade2);
            this.Controls.Add(this.txtIdade1);
            this.Controls.Add(this.lblIdade3);
            this.Controls.Add(this.lblIdade2);
            this.Controls.Add(this.lblIdade1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdade1;
        private System.Windows.Forms.Label lblIdade2;
        private System.Windows.Forms.Label lblIdade3;
        private System.Windows.Forms.TextBox txtIdade1;
        private System.Windows.Forms.TextBox txtIdade2;
        private System.Windows.Forms.TextBox txtIdade3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResposta;
    }
}

