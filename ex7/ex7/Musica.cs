using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    public class Musica
    {
        // Atributos da classe
        public string nome;  // Atributo para armazenar o nome da música
        public string autor;  // Atributo para armazenar o autor da música
        public string gravadora;  // Atributo para armazenar a gravadora da música

        // Construtor da classe
        public Musica(string nome, string autor, string gravadora)
        {
            // Inicializa os atributos da classe com os valores passados como parâmetros
            this.nome = nome;
            this.autor = autor;
            this.gravadora = gravadora;
        }
    }
}
