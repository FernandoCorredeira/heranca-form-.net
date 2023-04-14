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
    public partial class PessoaFisicaForm : Form
    {
        public PessoaFisicaForm()
        {
            InitializeComponent();
        }

        private void PessoaFisicaForm_Load(object sender, EventArgs e)
        {
            PessoaFisica PF = new PessoaFisica
            {
                Peso = 85.6,
                Altura = 1.80,
                Sexo = "Masculino",
                CPF = "475.654.397-25"
            };
            Pessoa Pessoa = new Pessoa
            {
                Nome = "Fernando",
                Endereco = "Rua blá. 28",
                Telefone = "(11)94878-1548",
                Nacionalidade = "Brasileira"

            };
            lblRespNome.Text = Pessoa.Nome;
            lblRespTelefone.Text = Pessoa.Telefone;
            lblRespNacionalidade.Text = Pessoa.Nacionalidade;
            lblRespEndereco.Text = Pessoa.Endereco;
            lblRespPeso.Text = PF.Peso.ToString();
            lblRespAltura.Text = PF.Altura.ToString();
            lblRespSexo.Text = PF.Sexo;
            lblRespCPF.Text = PF.CPF;



        }
    }
}
