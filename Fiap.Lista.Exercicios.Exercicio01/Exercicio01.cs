using Fiap.Lista.Exercicios.Exercicio01.Models;
using System;

namespace Fiap.Lista.Exercicios.Exercicio01
{
    class Exercicio01
    {
        static void Main(string[] args)
        {
            //Ler o primero número da soma
            Console.WriteLine("Digite o primeiro número para soma");
            double numero1 = double.Parse(Console.ReadLine());

            //Ler o segundo número da soma
            Console.WriteLine("Digite o segundo número para soma");
            double numero2 = double.Parse(Console.ReadLine());
         
            //Instanciar a classe Calculadora para obter o objeto
            Calculadora objetoCalculadora = new Calculadora();

            //Chamar o método Somar do objeto Calculadora e exibir o resultado
            double soma = objetoCalculadora.Somar(numero1, numero2);
            Console.WriteLine($"A soma de {numero1} e {numero2} é {soma}");

            //Ler o primeiro número da subtração
            Console.WriteLine("Digite o primeiro número para subtrair");
            numero1 = double.Parse(Console.ReadLine());

            //Ler o segundo número da subtração
            Console.WriteLine("Digite o segundo número para subtrair");
            numero2 = double.Parse(Console.ReadLine());

            //Chamar o método Subtrair do objeto Calculadora e exibir o resultado
            double subtracao = objetoCalculadora.Subtrair(numero1, numero2);
            Console.WriteLine($"A subtração de {numero1} e {numero2} é {subtracao}");
        }
    }
}
