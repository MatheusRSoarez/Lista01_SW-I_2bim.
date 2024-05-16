namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CorretoraDeImóveis corretora = new CorretoraDeImóveis();

            bool sair = false;
            while (!sair)
            {
                corretora.ExibirMenu();

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

                Console.Clear(); // Limpa o console para exibir o menu novamente
            }
        }
    }
}
