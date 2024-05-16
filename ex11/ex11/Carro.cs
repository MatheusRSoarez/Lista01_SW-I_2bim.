using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    public class Carro
    {
        // Atributos da classe Carro
        public string Modelo { get; set; }
        public int Ano { get; set; }
        private int velocidade;

        // Propriedade Velocidade com encapsulamento para garantir que não seja negativa
        public int Velocidade
        {
            get { return velocidade; }
            private set
            {
                if (value >= 0)
                {
                    velocidade = value;
                }
                else
                {
                    velocidade = 0;  // Velocidade nunca pode ser negativa
                }
            }
        }

        // Construtor da classe Carro
        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
            Velocidade = 0;  // Inicializa a velocidade como zero
        }

        // Método para acelerar o carro (aumentando a velocidade em 10)
        public void Acelerar()
        {
            Velocidade += 10;  // Aumenta a velocidade em 10
            Console.WriteLine($"O carro acelerou para {Velocidade} km/h.");
        }

        // Método para frear o carro (diminuindo a velocidade em 10, mas nunca deixando negativa)
        public void Frear()
        {
            Velocidade -= 10;  // Diminui a velocidade em 10
            Console.WriteLine($"O carro reduziu a velocidade para {Velocidade} km/h.");
        }
    }
}
