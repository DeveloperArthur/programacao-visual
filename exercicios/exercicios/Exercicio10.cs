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
    public partial class Exercicio10 : Form
    {
        public Exercicio10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = System.Convert.ToInt16(txtCodigo.Text);
            double salario = System.Convert.ToDouble(txtSalario.Text);

            string cargo = "";
            double aumento = 0.0;
            double novoSalario = 0.0;
            double percentual = 0.0;
            if (codigo == 1)
            {
                cargo = "Escrituario";
                percentual = 0.50;
            }
            else if (codigo == 2)
            {
                cargo = "Secretario";
                percentual = 0.35;
            }
            else if (codigo == 3)
            {
                cargo = "Caixa";
                percentual = 0.20;
            }
            else if (codigo == 4)
            {
                cargo = "Gerente";
                percentual = 0.10;
            }
            else if (codigo == 5)
            {
                cargo = "Gerente";
            }

            novoSalario = (salario*percentual) + salario;
            aumento = novoSalario - salario;

            lblCargo.Text = cargo;
            lblAumento.Text = aumento.ToString();

            if (codigo == 5)
                lblNovoSalario.Text = "Nao tem aumento";
            else
                lblNovoSalario.Text = novoSalario.ToString();
        }
    }
}
