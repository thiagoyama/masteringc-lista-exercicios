using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Lista.Exercicios.Exercicio10.Models
{
    class Lampada
    {
        //Propriedades
        public string Cor { get; set; }
        public bool EstaAcesa { get; set; }

        //Construtor
        public Lampada() { }

        public Lampada(string cor, bool estaAcesa)
        {
            Cor = cor;
            EstaAcesa = estaAcesa;
        }

        public Lampada(string cor)
        {
            Cor = cor;
            EstaAcesa = true;
        }

    }
}
