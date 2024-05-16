using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    // Classe Compra para representar uma compra individual
    public class Compra
    {
        // Atributos da classe
        public DateTime Data { get; set; }
        public string Produto { get; set; }
        public decimal Valor { get; set; }

        // Construtor da classe
        public Compra(DateTime data, string produto, decimal valor)
        {
            Data = data;
            Produto = produto;
            Valor = valor;
        }

        // Método ToString para imprimir uma compra de forma legível
        public override string ToString()
        {
            return $"Data: {Data.ToShortDateString()} | Produto: {Produto} | Valor: R${Valor:N2}";
        }
    }
    }

