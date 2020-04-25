using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            frm_produtos telaCadastrarProduto = new frm_produtos();
            telaCadastrarProduto.Show();
        }

        private void btnCadCategorias_Click(object sender, EventArgs e)
        {
            frm_categorias telaCadastrarCategoria = new frm_categorias();
            telaCadastrarCategoria.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos telaCadastrarProduto = new frm_produtos();
            telaCadastrarProduto.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias telaCadastrarCategoria = new frm_categorias();
            telaCadastrarCategoria.Show();
        }
    }
}
