using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.EstruturaDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;
            //double nota;

            Console.Write("Digite a nota do aluno ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.Write("O Aluno se comportou? S/N ");
            entrada = Console.ReadLine();
            bomComportamento = entrada.ToLower() == "s";

            if(nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de Honra!");
            }
            else
            {
                Console.WriteLine("Meh");
            }






        }
    }
}
