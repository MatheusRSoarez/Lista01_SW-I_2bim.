namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Exemplo de uso da classe Livro
                Livro livro = new Livro("Dom Quixote", "Miguel de Cervantes");
                Console.WriteLine($"Título: {livro.Titulo}");
                Console.WriteLine($"Autor: {livro.Autor}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao criar o livro: {ex.Message}");
            }
            
        }
    }
}
