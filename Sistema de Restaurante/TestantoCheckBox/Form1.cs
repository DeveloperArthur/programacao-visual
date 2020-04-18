using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestantoCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double valorDoChopp = 4.50;
            double valorDoPetisco = 7.90;
            double valorDaRefeicao = 15.90;

            int numMesa = Convert.ToInt32(txtNumMesa.Text);

            double qtdChopp = Convert.ToDouble(txtQtdChopp.Text);
            double qtdPetisco = Convert.ToDouble(txtQtdPetiscos.Text);
            double qtdRefeicao = Convert.ToDouble(txtQtdRefeicao.Text);

            double resultChopp = 0, resultPetisco = 0, resultRefeicao = 0;

            if (chkChopp.Checked)
                resultChopp = qtdChopp * valorDoChopp;

            if (chkPetisco.Checked)
                resultPetisco = qtdPetisco * valorDoPetisco;

            if (chkRefeicao.Checked)
                resultRefeicao = qtdRefeicao * valorDaRefeicao;

            double totalParcial = resultChopp + resultPetisco + resultRefeicao;
            txtTotalParcial.Text = Convert.ToString(totalParcial);

            double taxaServico = totalParcial * 0.08;
            txtTaxaServico.Text = Convert.ToString(taxaServico);

            double total = totalParcial + taxaServico;
            txtTotalPagar.Text = Convert.ToString(total);

        }
    }
}
