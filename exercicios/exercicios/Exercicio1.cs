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
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = System.Convert.ToDouble(txtNota1.Text);
            double nota2 = System.Convert.ToDouble(txtNota2.Text);
            double nota3 = System.Convert.ToDouble(txtNota3.Text);
            double media = (nota1 + nota2 + nota3) / 3;

            resultado.Text = media.ToString();
        }
    }
}
