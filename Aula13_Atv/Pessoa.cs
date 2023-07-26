using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13_Atv
{
    internal class Pessoa
    {
        public string nome, rua, cidade;
        int idade;
        public Pessoa(string nome, string rua, string cidade, int idade)
        {
            this.nome = nome;
            this.rua = rua;
            this.cidade = cidade;
            this.idade = idade;
        }
    }
}
