using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.EstruturaDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {

            //for(int i = 10; i!=0 ; i--)
            //{
            //    Console.WriteLine($"O valor atual é: {i}");
            //}
            double somatorio = 0;
            string entrada;

            Console.WriteLine("Qual o tamanho da turma?");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for(int i = 1; i <= tamanhoTurma; i++)
            {
                Console.WriteLine($"Informe a nota do aluno {i}: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine($"A Media da turma é: {media}");
        }
    }
}
