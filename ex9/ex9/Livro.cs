using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    public class Livro
    {
        // Propriedade Título com encapsulamento para garantir que não seja vazio
        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    titulo = value;
                }
                else
                {
                    throw new ArgumentException("O título do livro não pode ser vazio.");
                }
            }
        }

        // Propriedade Autor com encapsulamento para garantir que não seja vazio
        private string autor;
        public string Autor
        {
            get { return autor; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    autor = value;
                }
                else
                {
                    throw new ArgumentException("O autor do livro não pode ser vazio.");
                }
            }
        }

        // Construtor da classe Livro
        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }
}
