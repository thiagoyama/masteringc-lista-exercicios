using Fiap.Lista.Exercicios.Exercicio08.Models;
using System;

namespace Fiap.Lista.Exercicios.Exercicio08
{
    class Exercicio08
    {
        static void Main(string[] args)
        {
            //Instanciar a classe TrianguloRetangulo com os valores dos catetos
            var triangulo1 = new TrianguloRetangulo(5, 10);

            //Calcular e exibir o valor da hipotenusa
            var hipotenusa = triangulo1.CalcularHipotenusa();
            Console.WriteLine($"O valor da hipotenusa do triângulo retângulo de catetos 5 e 10 é {hipotenusa}");

            //Instanciar a classe TrianguloRetangulo com os outros valores
            var triangulo2 = new TrianguloRetangulo(4, 5);

            //Calcular e exibir o valor da hipotenusa
            Console.WriteLine($"O valor da hipotenusa do triângulo retângulo de catetos 4 e 5 é {triangulo2.CalcularHipotenusa()}");
        }
    }
}
