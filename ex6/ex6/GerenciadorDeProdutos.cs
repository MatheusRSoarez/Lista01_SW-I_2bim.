using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    public class GerenciadorDeProdutos
    {
        // Atributos da classe
        private List<Produto> produtos;

        // Construtor da classe
        public GerenciadorDeProdutos()
        {
            produtos = new List<Produto>();
        }

        // Método para adicionar um produto à lista
        public void AdicionarProduto(int codigo, string nome, decimal preco)
        {
            Produto novoProduto = new Produto(codigo, nome, preco);
            produtos.Add(novoProduto);
            Console.WriteLine("Produto adicionado com sucesso!");
        }

        // Método para consultar um produto pelo código
        public void ConsultarProduto(int codigo)
        {
            Produto produto = produtos.FirstOrDefault(p => p.Codigo == codigo);
            if (produto != null)
            {
                Console.WriteLine("Produto encontrado:");
                Console.WriteLine(produto);
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        // Método para listar todos os produtos
        public void ListarProdutos()
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (var produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }
    }
}
