using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Lista.Exercicios.Exercicio11.Models
{
    class Ponto
    {
        //Propriedades
        public float X { get; set; }
        public float Y { get; set; }

        //Construtores
        public Ponto() { }

        public Ponto(float x, float y)
        {
            X = x;
            Y = y;
        }

        //Métodos
        public double CalcularDistancia(Ponto ponto)
        {
            var dx = ponto.X - X;
            var dy = ponto.Y - Y;
            var distancia = Math.Sqrt(dx * dx + dy * dy);
            return distancia;
        }

    }
}
