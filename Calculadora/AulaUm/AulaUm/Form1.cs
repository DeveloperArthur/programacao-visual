using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        //método construtor
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtValor1.Text);
            int valor2 = int.Parse(txtValor2.Text);
            int resultado = valor1 + valor2;

            MessageBox.Show("Resultado é: " + resultado);
        }
    }
}
