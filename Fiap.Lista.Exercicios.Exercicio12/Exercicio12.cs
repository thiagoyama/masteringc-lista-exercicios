using Fiap.Lista.Exercicios.Exercicio12.Models;
using System;

namespace Fiap.Lista.Exercicios.Exercicio12
{
    class Exercicio12
    {
        static void Main(string[] args)
        {
            //Instanciar a cor com o construtor que recebe 3 parâmetros
            var cor1 = new Cor(10, 100, 20); //Red, Green, Blue

            //Instanciar a cor com o construtor que recebe 2 parâmetros
            var cor2 = new Cor(125, 30); //Red, Green

            //Instanciar a cor com o construtor que recebe 1 parâmetro
            var cor3 = new Cor(50); //Red

            //Instanciar a cor com o construtor padrão
            var cor4 = new Cor();

            //Exibir os valores das cores, formatada
            Console.WriteLine($"A cor1 é {cor1.ObterCor()}");
            Console.WriteLine($"A cor2 é {cor2.ObterCor()}");
            Console.WriteLine($"A cor3 é {cor3.ObterCor()}");
            Console.WriteLine($"A cor4 é {cor4.ObterCor()}");

        }
    }
}
