using Fiap.Lista.Exercicios.Exercicio07.Models;
using System;

namespace Fiap.Lista.Exercicios.Exercicio07
{
    class Exercicio07
    {
        static void Main(string[] args)
        {
            //Criar um objeto Empregado com os valores em seus atributos
            var funcionario = new Empregado("João", "Analista de Sistemas", 5400);

            //Chamar o método para aumentar o salário
            funcionario.AumentarSalario(600);

            //Exibir os dados do funcionário
            Console.WriteLine($"Nome: {funcionario.Nome}, cargo: {funcionario.Funcao} e salário: {funcionario.Salario.ToString("c")}");
        }
    }
}
