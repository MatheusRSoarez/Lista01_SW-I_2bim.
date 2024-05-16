namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeProdutos gerenciador = new GerenciadorDeProdutos();

            gerenciador.AdicionarProduto(1, "Mouse", 49.90m);
            gerenciador.AdicionarProduto(2, "Teclado", 99.90m);
            gerenciador.AdicionarProduto(3, "Monitor", 699.90m);

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Listar Produtos");
                Console.WriteLine("2 - Consultar Produto por Código");
                Console.WriteLine("0 - Sair");

                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        gerenciador.ListarProdutos();
                        break;
                    case 2:
                        Console.Write("Digite o código do produto a ser consultado: ");
                        int codigo = int.Parse(Console.ReadLine());
                        gerenciador.ConsultarProduto(codigo);
                        break;
                    case 0:
                        sair = true;
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

                Console.Clear(); // Limpa o console para exibir o menu novamente
            }
        }
    }
}
