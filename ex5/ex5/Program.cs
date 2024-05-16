namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Adicionar Tarefa");
                Console.WriteLine("2 - Remover Tarefa");
                Console.WriteLine("3 - Listar Tarefas");
                Console.WriteLine("4 - Verificar Tarefa a ser Executada Hoje");
                Console.WriteLine("0 - Sair");

                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a descrição da tarefa: ");
                        string descricao = Console.ReadLine();
                        Console.Write("Digite a data de vencimento da tarefa (dd/mm/aaaa): ");
                        DateTime dataVencimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        gerenciador.AdicionarTarefa(descricao, dataVencimento);
                        break;
                    case 2:
                        Console.Write("Digite a descrição da tarefa a ser removida: ");
                        string descricaoRemover = Console.ReadLine();
                        gerenciador.RemoverTarefa(descricaoRemover);
                        break;
                    case 3:
                        gerenciador.ListarTarefas();
                        break;
                    case 4:
                        gerenciador.VerificarTarefaAtual();
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
