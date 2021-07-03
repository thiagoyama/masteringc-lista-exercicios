using Fiap.Lista.Exercicios.Exercicio10.Models;
using System;

namespace Fiap.Lista.Exercicios.Exercicio10
{
    class Exercicio10
    {
        static void Main(string[] args)
        {
            //Instanciar 3 lampadas
            //Construtor padrão
            var lampada1 = new Lampada();

            //Construtor com a cor
            //Ler a cor
            Console.WriteLine("Digite a cor da lâmpada");
            string cor = Console.ReadLine();
            
            //Instanciar a lampada com a cor
            var lampada2 = new Lampada(cor);

            //Construtor com a cor e está acesa
            //Ler a cor
            Console.WriteLine("Digite a cor da lâmpada");
            cor = Console.ReadLine();

            //Ler se está acesa
            Console.WriteLine("Está acesa?");
            var acesa = bool.Parse(Console.ReadLine());

            //Instanciar a lamapada com a cor e se está acesa
            var lampada3 = new Lampada(cor, acesa);

            //Exibir os valores dos objetos
            Console.WriteLine($"A lampada 1 possui a cor: {lampada1.Cor} e está acesa: {lampada1.EstaAcesa}");
            Console.WriteLine($"A lampada 2 possui a cor: {lampada2.Cor} e está acesa: {lampada2.EstaAcesa}");
            Console.WriteLine($"A lampada 3 possui a cor: {lampada3.Cor} e está acesa: {lampada3.EstaAcesa}");
        }
    }
}
