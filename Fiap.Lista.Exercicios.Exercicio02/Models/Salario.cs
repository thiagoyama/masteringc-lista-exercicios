using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Lista.Exercicios.Exercicio02.Models
{
    class Salario
    {
        public decimal ValorBruto { get; set; }

        public decimal CalcularInss()
        {
            return ValorBruto * 20 / 100;
        }

        public decimal ObterValorLiquido()
        {
            decimal descontoInss = CalcularInss();
            return ValorBruto - descontoInss;
        }
    }
}
