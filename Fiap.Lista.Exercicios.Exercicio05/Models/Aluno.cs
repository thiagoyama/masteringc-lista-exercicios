using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Lista.Exercicios.Exercicio05.Models
{
    class Aluno
    {
        public Disciplina Disciplina { get; set; }
        public string Nome { get; set; }

        public void AtribuirNotas(double nota1, double nota2, double nota3)
        {
            //Valida se a propriedade possui um objeto, se não possuir, cria um novo objeto
            if (Disciplina == null)
                Disciplina = new Disciplina();

            Disciplina.Nota1 = nota1;
            Disciplina.Nota2 = nota2;
            Disciplina.Nota3 = nota3;
        }

        public double ObterMedia()
        {
            return Disciplina.ObterMedia();
        }
    }
}
