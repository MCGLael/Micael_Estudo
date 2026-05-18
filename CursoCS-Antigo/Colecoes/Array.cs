using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            String[] alunos = new string[5];
            alunos [0] = "ana";
            alunos [1] = "Jose";
            alunos [2] = "Jonathan";
            alunos [3] = "Mario";
            alunos [4] = "Moana";

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            double somatorio = 0;
            double[] notas = { 9.0, 5.7, 7.0, 7.6, 9.9 };
            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine("A media da turma é de: {0}", media);

            
        }
    }
}
