using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerancaInterFace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PessoaFisicaForm PFF = new PessoaFisicaForm();
            PFF.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PessoaJuridicaForm PJF = new PessoaJuridicaForm();
            PJF.Show
        }
    }
}
