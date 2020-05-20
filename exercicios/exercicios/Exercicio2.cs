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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            double salario = System.Convert.ToDouble(txtSalario.Text);
            double novoSalario = salario * 1.25;
            resultado.Text = novoSalario.ToString();
        }
    }
}
