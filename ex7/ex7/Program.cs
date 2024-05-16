namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Bem-vindo(a) à sua playlist! *****");  // Exibe uma mensagem de boas-vindas ao usuário

            Console.Write("Informe o nome do dono da playlist: ");  // Solicita ao usuário o nome do dono da playlist
            string donoDaPlaylist = Console.ReadLine();  // Lê o nome do dono da playlist informado pelo usuário

            Playlist minhaPlaylist = new Playlist(donoDaPlaylist);  // Cria uma nova playlist com o dono informado

            while (true)  // Loop infinito para manter o programa em execução até que o usuário escolha sair
            {
                Console.WriteLine("\nOpções:");  // Exibe as opções disponíveis para o usuário
                Console.WriteLine("1 - Adicionar música");  // Opção para adicionar uma música à playlist
                Console.WriteLine("2 - Tocar música aleatória");  // Opção para tocar uma música aleatória da playlist
                Console.WriteLine("3 - Sair");  // Opção para sair do programa

                Console.Write("Escolha uma opção: ");  // Solicita ao usuário que escolha uma opção
                string escolha = Console.ReadLine();  // Lê a opção escolhida pelo usuário

                if (escolha == "1")  // Se a escolha for adicionar música
                {
                    Console.Write("Informe o nome da música: ");  // Solicita o nome da música ao usuário
                    string nome = Console.ReadLine();  // Lê o nome da música informado pelo usuário

                    Console.Write("Informe o nome do autor: ");  // Solicita o nome do autor ao usuário
                    string autor = Console.ReadLine();  // Lê o nome do autor informado pelo usuário

                    Console.Write("Informe o nome da gravadora: ");  // Solicita o nome da gravadora ao usuário
                    string gravadora = Console.ReadLine();  // Lê o nome da gravadora informado pelo usuário

                    Musica novaMusica = new Musica(nome, autor, gravadora);  // Cria uma nova música com as informações fornecidas
                    minhaPlaylist.AdicionarMúsica(novaMusica);  // Adiciona a nova música à playlist
                }
                else if (escolha == "2")  // Se a escolha for tocar música aleatória
                {
                    minhaPlaylist.TocarMúsicaAleatória();  // Toca uma música aleatória da playlist
                }
                else if (escolha == "3")  // Se a escolha for sair
                {
                    break;  // Encerra o loop e sai do programa
                }
                else  // Se a escolha não for válida
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");  // Exibe uma mensagem de opção inválida
                }
            }

        }
    }
}
