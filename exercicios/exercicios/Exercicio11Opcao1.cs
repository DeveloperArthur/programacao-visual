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
    public partial class Exercicio11Opcao1 : Form
    {
        public Exercicio11Opcao1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario = System.Convert.ToDouble(txtSalario.Text);
            double percentual = 0.0;

            if (salario < 500.00)
                percentual = 0.05;
            else if (salario >= 500.00 && salario < 850.00)
                percentual = 0.10;
            else if (salario >= 850.00)
                percentual = 0.15;

            double imposto = salario * percentual;
            
            lblResposta.Text = imposto.ToString();
        }
    }
}
