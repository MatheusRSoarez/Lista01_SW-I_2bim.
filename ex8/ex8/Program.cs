namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso das classes Fabricante e Produto
            Fabricante fabricante = new Fabricante("EmpresaXYZ", "Rua Principal, 123", "CidadeA");
            Produto produto = new Produto("ProdutoABC", fabricante, 99.90m);

            Console.WriteLine($"Nome do Produto: {produto.Nome}");
            Console.WriteLine($"Fabricante: {produto.Fabricante.Nome}");
            Console.WriteLine($"Preço: R${produto.Preco:N2}");
        }
    }
}
