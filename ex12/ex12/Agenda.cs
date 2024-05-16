using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    public class Agenda
    {
        private List<Pessoa> pessoas = new List<Pessoa>();

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa pessoa = new Pessoa(nome, idade, altura);
            pessoas.Add(pessoa);
        }

        public void RemovePessoa(string nome)
        {
            Pessoa pessoa = BuscaPessoa(nome);
            if (pessoa != null)
            {
                pessoas.Remove(pessoa);
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada na agenda.");
            }
        }

        public Pessoa BuscaPessoa(string nome)
        {
            return pessoas.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }

        public void ImprimeAgenda()
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1 - Armazenar Pessoa");
                Console.WriteLine("2 - Remover Pessoa");
                Console.WriteLine("3 - Buscar Pessoa");
                Console.WriteLine("4 - Imprimir Agenda");
                Console.WriteLine("5 - Sair");

                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.Write("Informe o nome da pessoa: ");
                        string nome = Console.ReadLine();

                        Console.Write("Informe a idade da pessoa: ");
                        int idade = int.Parse(Console.ReadLine());

                        Console.Write("Informe a altura da pessoa (em metros): ");
                        float altura = float.Parse(Console.ReadLine());

                        ArmazenaPessoa(nome, idade, altura);
                        break;
                    case "2":
                        Console.Write("Informe o nome da pessoa a ser removida: ");
                        string nomeRemover = Console.ReadLine();
                        RemovePessoa(nomeRemover);
                        break;
                    case "3":
                        Console.Write("Informe o nome da pessoa a ser buscada: ");
                        string nomeBuscar = Console.ReadLine();
                        Pessoa pessoaBuscada = BuscaPessoa(nomeBuscar);
                        if (pessoaBuscada != null)
                        {
                            Console.WriteLine("Pessoa encontrada na agenda:");
                            Console.WriteLine(pessoaBuscada);
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada na agenda.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Agenda:");
                        ImprimeAgenda();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
