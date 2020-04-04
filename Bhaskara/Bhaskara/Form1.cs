using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //entrada pra nao dar erro: 1 - 9 - 2
            double a = System.Convert.ToDouble(txtValorA.Text);
            double b = System.Convert.ToDouble(txtValorB.Text);
            double c = System.Convert.ToDouble(txtValorC.Text);

            double delta = b * b - 4 * a * c;
            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (delta < 0)
                lblResposta.Text = "Nao existe raiz de delta";

            lblResposta.Text = "Valor de A1 = " + a1 + "\n" + "Valor de A2 = " + a2;
        }
    }
}
