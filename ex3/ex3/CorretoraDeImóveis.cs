using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    public class CorretoraDeImóveis
    {
        // Atributos da classe
        private List<Imovel> imoveis;

        // Construtor da classe
        public CorretoraDeImóveis()
        {
            imoveis = new List<Imovel>();
        }

        // Método para inserir um imóvel na lista
        public void InserirImovel(string endereco, decimal preco, string tipo)
        {
            Imovel novoImovel = new Imovel(endereco, preco, tipo);
            imoveis.Add(novoImovel);
            Console.WriteLine("Imóvel adicionado com sucesso!");
        }

        // Método para alterar o preço de um imóvel
        public void AlterarPreco(int indice, decimal novoPreco)
        {
            if (indice >= 0 && indice < imoveis.Count)
            {
                imoveis[indice].Preco = novoPreco;
                Console.WriteLine("Preço do imóvel alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido!");
            }
        }

        // Método para listar todos os imóveis disponíveis
        public void ListarImoveis()
        {
            Console.WriteLine("Imóveis Disponíveis:");
            foreach (var imovel in imoveis)
            {
                Console.WriteLine(imovel);
            }
        }

        // Método para calcular o valor médio dos imóveis
        public void CalcularValorMedio()
        {
            if (imoveis.Count > 0)
            {
                decimal valorTotal = imoveis.Sum(imovel => imovel.Preco);
                decimal valorMedio = valorTotal / imoveis.Count;
                Console.WriteLine($"Valor médio dos imóveis: R${valorMedio:N2}");
            }
            else
            {
                Console.WriteLine("Não há imóveis disponíveis para calcular o valor médio.");
            }
        }

        // Método para exibir um menu de opções
        public void ExibirMenu()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Inserir Imóvel");
            Console.WriteLine("2 - Alterar Preço do Imóvel");
            Console.WriteLine("3 - Apresentar Todos os Imóveis");
            Console.WriteLine("4 - Calcular Valor Médio dos Imóveis");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o endereço do imóvel: ");
                    string endereco = Console.ReadLine();
                    Console.Write("Digite o preço do imóvel: ");
                    decimal preco = decimal.Parse(Console.ReadLine());
                    Console.Write("Digite o tipo do imóvel: ");
                    string tipo = Console.ReadLine();
                    InserirImovel(endereco, preco, tipo);
                    break;
                case 2:
                    Console.Write("Digite o índice do imóvel a ser alterado: ");
                    int indice = int.Parse(Console.ReadLine());
                    Console.Write("Digite o novo preço do imóvel: ");
                    decimal novoPreco = decimal.Parse(Console.ReadLine());
                    AlterarPreco(indice, novoPreco);
                    break;
                case 3:
                    ListarImoveis();
                    break;
                case 4:
                    CalcularValorMedio();
                    break;
                case 0:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

}
