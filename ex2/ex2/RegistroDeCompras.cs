using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    public class RegistroDeCompras
    {
        // Atributos da classe
        private List<Compra> compras;

        // Construtor da classe
        public RegistroDeCompras()
        {
            compras = new List<Compra>();
        }

        // Método para adicionar uma compra
        public void AdicionarCompra(DateTime data, string produto, decimal valor)
        {
            Compra novaCompra = new Compra(data, produto, valor);
            compras.Add(novaCompra);
        }

        // Método para listar todas as compras
        public void ListarCompras()
        {
            Console.WriteLine("Lista de Compras:");
            foreach (var compra in compras)
            {
                Console.WriteLine(compra);
            }
        }
    }
}
