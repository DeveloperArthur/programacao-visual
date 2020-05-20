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
    public partial class Exercicio11Opcao3 : Form
    {
        public Exercicio11Opcao3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario = System.Convert.ToDouble(txtSalario.Text);
            if (salario <= 700)
                lblResposta.Text = "Mal remunerado";
            else
                lblResposta.Text = "Bem remunerado";
        }
    }
}
