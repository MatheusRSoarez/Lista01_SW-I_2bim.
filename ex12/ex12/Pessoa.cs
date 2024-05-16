using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Altura { get; set; }

        public Pessoa(string nome, int idade, float altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Altura: {Altura}m";
        }
    }

}
