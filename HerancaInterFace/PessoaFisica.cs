using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaInterFace
{
    class PessoaFisica: Pessoa, Recursos
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Sexo { get; set; }
        public string CPF { get; set; }
        //Metodo que sobrescreve (override)
        public override string DefinirNome(string Nome)
        {
            this.Nome = Nome;
            return $"O nome da pessoa fisica é {this.Nome}";
        }
        string Recursos.Andar() {
            return $"Estou andando.";
        }
        void Recursos.Parar()
        {

        }
        string Recursos.Falar(string Falar)
        {
            return $"Estou falando";
        }

    }
}
