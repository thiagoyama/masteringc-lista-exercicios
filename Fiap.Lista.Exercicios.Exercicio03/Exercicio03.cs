using Fiap.Lista.Exercicios.Exercicio03.Models;
using System;

namespace Fiap.Lista.Exercicios.Exercicio03
{
    class Exercicio03
    {
        static void Main(string[] args)
        {
            //Ler o capital, período e taxa
            Console.WriteLine("Digite o capital");
            decimal capital = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a taxa de juros");
            decimal taxa = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o período");
            int periodo = int.Parse(Console.ReadLine());

            //Instanciar a classe CalculadoraFinanceira
            CalculadoraFinanceira objeto = new CalculadoraFinanceira();
            
            //Calcular a taxa de juros simples e composta
            decimal montanteSimples = objeto.CalcularJurosSimples(capital, taxa, periodo);
            decimal montanteComposto = objeto.CalcularJurosCompostos(capital, taxa, periodo);

            //Exibir o resultado (.ToString("c") -> converte o valor para currency, valor monetário))
            Console.WriteLine($"O montante acumulado com juros simples é {montanteSimples.ToString("c")} \n e com juros compostos é {montanteComposto.ToString("c")}");
        }
    }
}
