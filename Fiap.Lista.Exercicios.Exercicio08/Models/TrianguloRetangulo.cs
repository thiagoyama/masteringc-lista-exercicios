using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Lista.Exercicios.Exercicio08.Models
{
    class TrianguloRetangulo
    {
        //Propriedades
        public double Cateto1 { get; set; }
        public double Cateto2 { get; set; }

        //Construtores
        public TrianguloRetangulo() {}

        public TrianguloRetangulo(double cateto1, double cateto2)
        {
            Cateto1 = cateto1;
            Cateto2 = cateto2;
        }

        //Método
        public double CalcularHipotenusa()
        {
            var hipotenusa = Math.Sqrt(Math.Pow(Cateto1, 2) + Math.Pow(Cateto2, 2));
            return hipotenusa;
        }

    }
}
