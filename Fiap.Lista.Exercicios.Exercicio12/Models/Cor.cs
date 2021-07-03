using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Lista.Exercicios.Exercicio12.Models
{
    class Cor
    {
        //Propriedades
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        //Construtores
        public Cor() { }

        public Cor(int r)
        {
            R = r;
        }
        public Cor(int r, int g)
        {
            R = r;
            G = g;
        }

        public Cor(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        //Método
        public string ObterCor()
        {
            return $"({R}, {G}, {B})";
        }
        
    }
}
