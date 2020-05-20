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
    public partial class Exercicio8 : Form
    {
        public Exercicio8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int horasTrabalhadas = System.Convert.ToInt16(txtHoras.Text);
            double salario = System.Convert.ToDouble(txtSalario.Text);

            double novoSalario = (salario / 2) * horasTrabalhadas;
            double imposto = novoSalario * 0.03;
            novoSalario = novoSalario - imposto;
            lblNovoSalario.Text = novoSalario.ToString();
        }
    }
}
