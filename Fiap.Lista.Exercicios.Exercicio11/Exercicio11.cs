using Fiap.Lista.Exercicios.Exercicio11.Models;
using System;

namespace Fiap.Lista.Exercicios.Exercicio11
{
    class Exercicio11
    {
        static void Main(string[] args)
        {
            //Ler os dados do primeiro ponto
            Console.WriteLine("Digite o x do primeiro ponto");
            var x = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o y do primeiro ponto");
            var y = float.Parse(Console.ReadLine());

            //Instanciar o primeiro ponto com o construtor padrão
            var ponto1 = new Ponto()
            {
                X = x,
                Y = y
            };

            //Ler os dados do segundo ponto
            Console.WriteLine("Digite o x do segundo ponto");
            x = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o y do segundo ponto");
            y = float.Parse(Console.ReadLine());

            //Instanciar o primeiro ponto com o construtor padrão
            var ponto2 = new Ponto(x,y);

            //Calcular a distância e exibir o resultado
            Console.WriteLine($"A distância entre os pontos é {ponto1.CalcularDistancia(ponto2)}");
        }
    }
}
