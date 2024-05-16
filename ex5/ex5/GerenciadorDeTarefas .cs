using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    public class GerenciadorDeTarefas
    {
        // Atributos da classe
        private List<Tarefa> tarefas;

        // Construtor da classe
        public GerenciadorDeTarefas()
        {
            tarefas = new List<Tarefa>();
        }

        // Método para adicionar uma tarefa à lista
        public void AdicionarTarefa(string descricao, DateTime dataVencimento)
        {
            Tarefa novaTarefa = new Tarefa(descricao, dataVencimento);
            tarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        // Método para remover uma tarefa da lista
        public void RemoverTarefa(string descricao)
        {
            Tarefa tarefa = tarefas.FirstOrDefault(t => t.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        // Método para listar todas as tarefas
        public void ListarTarefas()
        {
            Console.WriteLine("Lista de Tarefas:");
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine(tarefa);
            }
        }

        // Método para verificar se uma tarefa deve ser executada no dia atual
        public void VerificarTarefaAtual()
        {
            DateTime hoje = DateTime.Today;
            var tarefasHoje = tarefas.Where(t => t.DataVencimento.Date == hoje);
            if (tarefasHoje.Any())
            {
                Console.WriteLine("Tarefas a serem executadas hoje:");
                foreach (var tarefa in tarefasHoje)
                {
                    Console.WriteLine(tarefa);
                }
            }
            else
            {
                Console.WriteLine("Não há tarefas a serem executadas hoje.");
            }
        }
    }
}
