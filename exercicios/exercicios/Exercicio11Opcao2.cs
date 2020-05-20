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
    public partial class Exercicio11Opcao2 : Form
    {
        public Exercicio11Opcao2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario = System.Convert.ToDouble(txtSalario.Text);
            double aumento = 0.0;
            double novoSalario = 0.0;

            if (salario > 1500)
                aumento = 25.00;
            else if (salario >= 750 && salario <= 1500)
                aumento = 50.00;
            else if (salario >= 450 && salario < 750)
                aumento = 75.00;
            else if (salario < 450)
                aumento = 100;

            novoSalario = salario + aumento;
            lblResposta.Text = novoSalario.ToString();
        }
    }
}
