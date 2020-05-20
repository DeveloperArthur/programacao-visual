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
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            double salario = System.Convert.ToDouble(txtSalario.Text);
            double gratificacao = salario * 0.05;
            double imposto = salario * 0.07;
            double novoSalario = (salario - imposto) + gratificacao;
            resultado.Text = novoSalario.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
