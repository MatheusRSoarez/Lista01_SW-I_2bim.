namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância da classe RegistroDeCompras
            RegistroDeCompras registro = new RegistroDeCompras();

            // Adicionando algumas compras para teste
            registro.AdicionarCompra(new DateTime(2024, 5, 1), "Livro de Programação", 59.90m);
            registro.AdicionarCompra(new DateTime(2024, 5, 5), "Mouse sem Fio", 99.99m);

            // Listando as compras
            registro.ListarCompras();

            // Aguardando a entrada do usuário para encerrar o programa
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
