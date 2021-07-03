using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Lista.Exercicios.Exercicio09.Models
{
    class Hora
    {
        //Propriedades
        public int Horas { get; set; }
        public int Minutos { get; set; }
        public int Segundos { get; set; }

        //Construtore
        public Hora(int hora, int minuto, int segundo)
        {
            Horas = hora;
            Minutos = minuto;
            Segundos = segundo;
        }

        //Método
        public string ObterHora()
        {
            return $"{Horas}:{Minutos}:{Segundos}";
        }

    }
}
