namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso da classe Animal
            Animal cachorro = new Animal("Rex", "Cachorro", 5);
            cachorro.EmitirSom();  // Imprime "Au au!"

            Animal gato = new Animal("Whiskers", "Gato", 3);
            gato.EmitirSom();  // Imprime "Miau!"

            Animal papagaio = new Animal("Loro", "Papagaio", 10);
            papagaio.EmitirSom();  // Imprime "Som do animal desconhecido."
        }
    }
}
