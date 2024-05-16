using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    // Classe Tarefa para representar uma tarefa
    public class Tarefa
    {
        // Atributos da classe
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }

        // Construtor da classe
        public Tarefa(string descricao, DateTime dataVencimento)
        {
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }

        // Método ToString para imprimir uma tarefa de forma legível
        public override string ToString()
        {
            return $"Descrição: {Descricao} | Data de Vencimento: {DataVencimento.ToShortDateString()}";
        }
    }

}
