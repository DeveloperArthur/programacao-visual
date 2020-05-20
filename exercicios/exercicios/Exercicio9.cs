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
    public partial class Exercicio9 : Form
    {
        public Exercicio9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = System.Convert.ToDouble(txtNota1.Text);
            double nota2 = System.Convert.ToDouble(txtNota2.Text);
            double nota3 = System.Convert.ToDouble(txtNota3.Text);

            double media = (nota1 +nota2 + nota3) / 3;
            string mensagem = "";

            if (media >= 0.0 && media < 3.0)
                mensagem = "Reprovado";
            else if (media >= 3.0 && media < 7.0)
                mensagem = "Exame";
            else if (media >= 7.0)
                mensagem = "Aprovado";


            lblMedia.Text = media.ToString();
            lblStatus.Text = mensagem;
        }
    }
}
