using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Lista.Exercicios.Exercicio03.Models
{
    class CalculadoraFinanceira
    {
        public decimal CalcularJurosSimples(decimal capital, decimal taxa, int periodo)
        {            
            return capital * (1 + taxa * periodo);
        }

        public decimal CalcularJurosCompostos(decimal capital, decimal taxa, int periodo)
        {
            //O método Pow funciona com Double, por isso é necessário converter e depois converter novamente para decimal para a multiplicação
            return capital * Convert.ToDecimal(Math.Pow((1 + Convert.ToDouble(taxa)), periodo));
        }
    }
}
