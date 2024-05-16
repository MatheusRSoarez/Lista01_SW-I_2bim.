using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    // Classe Produto para representar um produto
    public class Produto
    {
        // Atributos da classe
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        // Construtor da classe
        public Produto(int codigo, string nome, decimal preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        // Método ToString para imprimir um produto de forma legível
        public override string ToString()
        {
            return $"Código: {Codigo} | Nome: {Nome} | Preço: R${Preco:N2}";
        }
    }

}
