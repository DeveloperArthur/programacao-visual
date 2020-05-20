using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios
{
    public partial class Exercicio7 : Form
    {
        public Exercicio7()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int anoAtual = System.Convert.ToInt16(txtAnoAtual.Text);
            int anoNascimento = System.Convert.ToInt16(txtAnoNascimento.Text);

            int idade = anoAtual - anoNascimento;
            int idadeEm2080 = 2080 - anoNascimento;

            lblIdade.Text = idade.ToString();
            lblIdade2080.Text = idadeEm2080.ToString();
        }
    }
}
