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
    public partial class Exercicio5 : Form
    {
        public Exercicio5()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            double salario = System.Convert.ToDouble(txtSalario.Text);
            double imposto = salario * 0.10;
            double novoSalario = (salario - imposto) + 50;
            resultado.Text = novoSalario.ToString();
        }
    }
}
