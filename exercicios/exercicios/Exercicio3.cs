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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            double salario = System.Convert.ToDouble(txtSalario.Text);
            double percentual = System.Convert.ToDouble(txtPercentual.Text);
            double novoSalario = salario * percentual;
            resultado.Text = novoSalario.ToString();
        }
    }
}
