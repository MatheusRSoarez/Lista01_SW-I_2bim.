using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    public class AgendaTelefonica
    {
        // Atributos da classe
        private List<Contato> contatos;

        // Construtor da classe
        public AgendaTelefonica()
        {
            contatos = new List<Contato>();
        }

        // Método para adicionar um contato à lista
        public void AdicionarContato(string nome, string telefone, string email)
        {
            Contato novoContato = new Contato(nome, telefone, email);
            contatos.Add(novoContato);
            Console.WriteLine("Contato adicionado com sucesso!");
        }

        // Método para remover um contato da lista
        public void RemoverContato(string nome)
        {
            Contato contato = contatos.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine("Contato removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        // Método para buscar um contato por nome
        public void BuscarContato(string nome)
        {
            Contato contato = contatos.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (contato != null)
            {
                Console.WriteLine(contato);
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        // Método para listar todos os contatos
        public void ListarContatos()
        {
            Console.WriteLine("Lista de Contatos:");
            foreach (var contato in contatos)
            {
                Console.WriteLine(contato);
            }
        }
    }
}
