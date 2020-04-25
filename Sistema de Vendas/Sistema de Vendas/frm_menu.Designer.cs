namespace Sistema_de_Vendas
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.btnCadCategorias = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Cadastro";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.produtoToolStripMenuItem.Text = "Cadastros";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCadProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCadProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnCadProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnCadProduto.Image")));
            this.btnCadProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadProduto.Location = new System.Drawing.Point(26, 42);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(99, 91);
            this.btnCadProduto.TabIndex = 3;
            this.btnCadProduto.Text = "Cadastrar produtos";
            this.btnCadProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadProduto.UseVisualStyleBackColor = false;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // btnCadCategorias
            // 
            this.btnCadCategorias.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCadCategorias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCadCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnCadCategorias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadCategorias.Image = ((System.Drawing.Image)(resources.GetObject("btnCadCategorias.Image")));
            this.btnCadCategorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadCategorias.Location = new System.Drawing.Point(143, 42);
            this.btnCadCategorias.Name = "btnCadCategorias";
            this.btnCadCategorias.Size = new System.Drawing.Size(92, 91);
            this.btnCadCategorias.TabIndex = 4;
            this.btnCadCategorias.Text = "Cadastrar categorias";
            this.btnCadCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadCategorias.UseVisualStyleBackColor = false;
            this.btnCadCategorias.Click += new System.EventHandler(this.btnCadCategorias_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(518, 338);
            this.Controls.Add(this.btnCadCategorias);
            this.Controls.Add(this.btnCadProduto);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Button btnCadCategorias;
    }
}

