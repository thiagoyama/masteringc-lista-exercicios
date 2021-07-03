using Fiap.Lista.Exercicios.Exercicio04.Models;
using System;

namespace Fiap.Lista.Exercicios.Exercicio04
{
    class Exercicio04
    {
        static void Main(string[] args)
        {
            //Ler o raio do círculo (que é a metade do lado do quadrado)
            Console.WriteLine("Digite o raio");
            double raio = double.Parse(Console.ReadLine());

            //Instanciar o quadrado e circulo
            Quadrado objetoQuadrado = new Quadrado();
            Circulo objetoCirculo = new Circulo();

            //Calcular as áreas
            double areaCirculo = objetoCirculo.CalcularArea(raio);
            double areaQuadrado = objetoQuadrado.CalcularArea(raio * 2);

            //Exibir o resultado (.ToString("n2") -> formada o número em duas casas decimais)
            Console.WriteLine($"A área do círculo é {areaCirculo.ToString("n2")} \nA área do quadrado é {areaQuadrado.ToString("n2")}\n e a área cinza é {(areaQuadrado-areaCirculo).ToString("n2")}");
        }
    }
}
