using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    // Classe Contato para representar um contato
    public class Contato
    {
        // Atributos da classe
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        // Construtor da classe
        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        // Método ToString para imprimir um contato de forma legível
        public override string ToString()
        {
            return $"Nome: {Nome} | Telefone: {Telefone} | Email: {Email}";
        }
    }
}
