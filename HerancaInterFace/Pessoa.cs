using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaInterFace
{
    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Nacionalidade { get; set; }

        public virtual string DefinirNome(string Nome) {
            this.Nome = Nome;
            return $"Seu nome é {this.Nome}";
        }
        public string MostrarNome()
        {
            return this.Nome;
        }
    }
}
