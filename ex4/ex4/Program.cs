namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica agenda = new AgendaTelefonica();

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Adicionar Contato");
                Console.WriteLine("2 - Remover Contato");
                Console.WriteLine("3 - Buscar Contato");
                Console.WriteLine("4 - Listar Contatos");
                Console.WriteLine("0 - Sair");

                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do contato: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o telefone do contato: ");
                        string telefone = Console.ReadLine();
                        Console.Write("Digite o email do contato: ");
                        string email = Console.ReadLine();
                        agenda.AdicionarContato(nome, telefone, email);
                        break;
                    case 2:
                        Console.Write("Digite o nome do contato a ser removido: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemoverContato(nomeRemover);
                        break;
                    case 3:
                        Console.Write("Digite o nome do contato a ser buscado: ");
                        string nomeBuscar = Console.ReadLine();
                        agenda.BuscarContato(nomeBuscar);
                        break;
                    case 4:
                        agenda.ListarContatos();
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
