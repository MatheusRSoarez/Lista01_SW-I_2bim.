using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    public class Produto
    {
        // Propriedades da classe Produto
        private string nome;
        private Fabricante fabricante;
        private decimal preco;

        // Propriedade Nome com encapsulamento para garantir que não seja vazio
        public string Nome
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nome = value;
                }
                else
                {
                    throw new ArgumentException("O nome do produto não pode ser vazio.");
                }
            }
        }

        // Propriedade Fabricante
        public Fabricante Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        // Propriedade Preço com encapsulamento para garantir que seja positivo
        public decimal Preco
        {
            get { return preco; }
            set
            {
                if (value >= 0)
                {
                    preco = value;
                }
                else
                {
                    throw new ArgumentException("O preço do produto deve ser positivo.");
                }
            }
        }

        // Construtor da classe Produto
        public Produto(string nome, Fabricante fabricante, decimal preco)
        {
            Nome = nome;
            Fabricante = fabricante;
            Preco = preco;
        }
    }
}
