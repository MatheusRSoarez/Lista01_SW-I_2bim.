using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    public class Fabricante
    {
        // Propriedades da classe Fabricante
        public string Nome { get; set; }
        public string Endereço { get; set; }
        public string Cidade { get; set; }

        // Construtor da classe Fabricante
        public Fabricante(string nome, string endereço, string cidade)
        {
            Nome = nome;
            Endereço = endereço;
            Cidade = cidade;
        }
    }

}
