using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Lista.Exercicios.Exercicio07.Models
{
    class Empregado
    {
        //Propriedades
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public decimal Salario { get; set; }

        //Construtor
        public Empregado(string nome, string funcao, decimal salario)
        {
            Nome = nome;
            Funcao = funcao;
            Salario = salario;
        }

        //Método
        public void AumentarSalario(decimal valor)
        {
            Salario += valor;
        }
    }
}
