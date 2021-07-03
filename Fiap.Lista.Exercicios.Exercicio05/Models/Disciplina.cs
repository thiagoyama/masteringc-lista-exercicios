using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Lista.Exercicios.Exercicio05.Models
{
    class Disciplina
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double ObterMedia()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }
    }
}
