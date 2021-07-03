using Fiap.Lista.Exercicios.Exercicio05.Models;
using System;

namespace Fiap.Lista.Exercicios.Exercicio05
{
    class Exercicio05
    {
        static void Main(string[] args)
        {
            //Ler o nome e as notas do aluno
            Console.WriteLine("Digite o nome do aluno");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota");
            var n1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a segunda nota");
            var n2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a terceira nota");
            var n3 = double.Parse(Console.ReadLine());

            //Instanciar um objeto Aluno e atribuir o nome e as notas
            var aluno = new Aluno();
            aluno.Nome = nome;
            aluno.AtribuirNotas(n1, n2, n3);

            //Calcular a média do aluno
            var media = aluno.ObterMedia();

            Console.WriteLine($"O aluno {aluno.Nome} obteve a média {media}");
        }
    }
}
