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
    public partial class Exercicio6 : Form
    {
        public Exercicio6()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double base1 = System.Convert.ToDouble(txtBase.Text);
            double altura = System.Convert.ToDouble(txtAltura.Text);
            double area = (base1 * altura) / 2;
            resultado.Text = area.ToString();
        }
    }
}
