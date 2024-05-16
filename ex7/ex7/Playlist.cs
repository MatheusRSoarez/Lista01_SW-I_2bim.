using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    public class Playlist
    {
        // Atributos da classe
        private List<Musica> listaDeMusicas = new List<Musica>();  // Lista para armazenar as músicas da playlist
        public string dono;  // Atributo para armazenar o dono da playlist

        // Construtor da classe
        public Playlist(string dono)
        {
            this.dono = dono;  // Inicializa o atributo dono com o valor passado como parâmetro
        }

        // Método para adicionar uma música à playlist
        public void AdicionarMúsica(Musica música)
        {
            listaDeMusicas.Add(música);  // Adiciona a música à lista de músicas da playlist
        }

        // Método para tocar uma música aleatória da playlist
        public void TocarMúsicaAleatória()
        {
            if (listaDeMusicas.Count > 0)  // Verifica se a playlist não está vazia
            {
                Random random = new Random();  // Cria uma instância de Random para gerar números aleatórios
                int índiceAleatório = random.Next(listaDeMusicas.Count);  // Gera um índice aleatório dentro do tamanho da lista
                Musica músicaTocada = listaDeMusicas[índiceAleatório];  // Obtém a música correspondente ao índice aleatório
                Console.WriteLine($"Tocando a música: {músicaTocada.nome} - {músicaTocada.autor}");  // Exibe o título e o autor da música
            }
            else
            {
                Console.WriteLine("A playlist está vazia. Adicione músicas antes de tocar.");  // Exibe uma mensagem se a playlist estiver vazia
            }
        }
    }

}
