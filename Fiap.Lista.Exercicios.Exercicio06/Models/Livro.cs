using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Lista.Exercicios.Exercicio06.Models
{
    class Livro
    {
        public string Ibsn { get; set; }
        public string TituloOriginal { get; set; }
        public string TituloPortugues { get; set; }
        public string Autor { get; set; }
        public int QuantidadePaginas { get; set; }
        public int Edicao { get; set; }
        public DateTime DataPublicacao { get; set; }

        public string ObterDetalhes()
        {
            return $"Título original: {TituloOriginal}, título português: {TituloPortugues}";
        }
    }
}
