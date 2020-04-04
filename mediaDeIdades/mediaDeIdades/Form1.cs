using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaDeIdades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade1 = System.Convert.ToInt16(txtIdade1.Text);
            int idade2 = System.Convert.ToInt16(txtIdade2.Text);
            int idade3 = System.Convert.ToInt16(txtIdade3.Text);
            int media = (idade1 + idade2 + idade3) / 3;
            lblResposta.Text = "A media das idades é "+media;
        }
    }
}
