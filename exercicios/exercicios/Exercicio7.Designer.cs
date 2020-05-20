namespace exercicios
{
    partial class Exercicio7
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
            this.lblIdade2080 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.txtAnoAtual = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ano atual";
            // 
            // lblIdade2080
            // 
            this.lblIdade2080.AutoSize = true;
            this.lblIdade2080.Location = new System.Drawing.Point(200, 221);
            this.lblIdade2080.Name = "lblIdade2080";
            this.lblIdade2080.Size = new System.Drawing.Size(0, 17);
            this.lblIdade2080.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade em 2080";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(200, 187);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(0, 17);
            this.lblIdade.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Idade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ano de nascimento";
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(181, 87);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(100, 22);
            this.txtAnoNascimento.TabIndex = 6;
            // 
            // txtAnoAtual
            // 
            this.txtAnoAtual.Location = new System.Drawing.Point(181, 56);
            this.txtAnoAtual.Name = "txtAnoAtual";
            this.txtAnoAtual.Size = new System.Drawing.Size(100, 22);
            this.txtAnoAtual.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(132, 133);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Exercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 305);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtAnoAtual);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIdade2080);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdade2080;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.TextBox txtAnoAtual;
        private System.Windows.Forms.Button btnEnviar;
    }
}