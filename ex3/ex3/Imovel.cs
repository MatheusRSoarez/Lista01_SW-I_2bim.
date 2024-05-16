using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    // Classe Imovel para representar um imóvel
    public class Imovel
    {
        // Atributos da classe
        public string Endereco { get; set; }
        public decimal Preco { get; set; }
        public string Tipo { get; set; }

        // Construtor da classe
        public Imovel(string endereco, decimal preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }

        // Método ToString para imprimir um imóvel de forma legível
        public override string ToString()
        {
            return $"Endereço: {Endereco} | Preço: R${Preco:N2} | Tipo: {Tipo}";
        }
    }

}
