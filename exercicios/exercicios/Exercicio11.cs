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
    public partial class Exercicio11 : Form
    {
        public Exercicio11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int opcao = System.Convert.ToInt16(txtOpcao.Text);
            if (opcao == 1)
                new Exercicio11Opcao1().Show();
            else if (opcao == 2)
                new Exercicio11Opcao2().Show();
            else if (opcao == 3)
                new Exercicio11Opcao3().Show();
        }
    }
}
