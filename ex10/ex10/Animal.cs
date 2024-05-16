using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    public class Animal
    {
        // Propriedades da classe Animal
        public string Nome { get; set; }
        public string Espécie { get; set; }
        public int Idade { get; set; }

        // Construtor da classe Animal
        public Animal(string nome, string espécie, int idade)
        {
            Nome = nome;
            Espécie = espécie;
            Idade = idade;
        }

        // Método para emitir o som do animal
        public void EmitirSom()
        {
            if (Espécie.ToLower() == "cachorro")
            {
                Console.WriteLine("Au au!");
            }
            else if (Espécie.ToLower() == "gato")
            {
                Console.WriteLine("Miau!");
            }
            else
            {
                Console.WriteLine("Som do animal desconhecido.");
            }
        }
    }

}
