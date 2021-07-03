using Fiap.Lista.Exercicios.Exercicio06.Models;
using System;

namespace Fiap.Lista.Exercicios.Exercicio06
{
    class Exercicio06
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 2; i++)
            {
                //Instanciar um livro
                Livro livro = new Livro();

                //Ler os dados
                Console.WriteLine($"Livro {i}");
                Console.WriteLine("Digite o ISBN:");
                livro.Ibsn = Console.ReadLine();

                Console.WriteLine("Digite o título original:");
                livro.TituloOriginal = Console.ReadLine();

                Console.WriteLine("Digite o título em portugês:");
                livro.TituloPortugues = Console.ReadLine();

                Console.WriteLine("Digite o autor:");
                livro.Autor = Console.ReadLine();

                Console.WriteLine("Digite a quantidade de páginas:");
                livro.QuantidadePaginas = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a edição:");
                livro.Edicao = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a data de publicação");
                livro.DataPublicacao = DateTime.Parse(Console.ReadLine());

                //Exibir os valores
                Console.WriteLine($"Livro {i}:\n Isbn: {livro.Ibsn}\n Autor: {livro.Autor}\n Quantidade de páginas: {livro.QuantidadePaginas}\n Edição: {livro.Edicao}\n Data publicação: {livro.DataPublicacao} \n Títulos: {livro.ObterDetalhes()} ");
            }
        }
    }
}
