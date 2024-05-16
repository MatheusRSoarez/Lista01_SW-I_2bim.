namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso da classe Carro
            Carro meuCarro = new Carro("Sedan", 2022);
            meuCarro.Acelerar();  // Acelera o carro
            meuCarro.Acelerar();  // Acelera novamente
            meuCarro.Frear();  // Freia o carro

            // Tentativa de frear além do limite
            meuCarro.Frear();  // A velocidade não fica negativa
        }
    }
}
