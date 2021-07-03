using Fiap.Lista.Exercicios.Exercicio09.Models;
using System;

namespace Fiap.Lista.Exercicios.Exercicio09
{
    class Exercicio09
    {
        static void Main(string[] args)
        {
            //Instanciar a classe Hora com os valores
            var hora = new Hora(12, 40, 15);

            //Chamar o método para obter a hora e exibir a informação
            var horaFormatada = hora.ObterHora();
            Console.WriteLine(horaFormatada);
        }
    }
}
