using Fiap.Lista.Exercicios.Exercicio02.Models;
using System;

namespace Fiap.Lista.Exercicios.Exercicio02
{
    class Exercicio02
    {
        static void Main(string[] args)
        {
            //Ler o salário
            Console.WriteLine("Digite o salário");
            decimal valor = decimal.Parse(Console.ReadLine());

            //Criar um objeto do tipo Salario
            Salario objetoSalario = new Salario();

            //Atribuir o valor bruto no objeto salário
            objetoSalario.ValorBruto = valor;

            //Calcular o valor do inss 
            decimal valorInss = objetoSalario.CalcularInss();

            //Calcular o valor do salário liquido
            decimal salarioLiquido = objetoSalario.ObterValorLiquido();

            //Exibir os valores
            Console.WriteLine($"O salário bruto é {objetoSalario.ValorBruto}, o desconto do inss é {valorInss} e o salário líquido é {salarioLiquido}");

        }
    }
}
