using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.EstruturaDeControle
{
    internal class UsandoContinue
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a quantidade de numeros que vai ser analizado");
            var dado = Console.ReadLine();
            int.TryParse(dado, out int valor);
            Console.WriteLine($"Lendo os valores{valor}");

            for(int i = 1; i <= valor; i++)
            {
                if(i % 2 != 0)
                {
                    continue; // Pula a iteração atual se o número for par
                }
                Console.Write(i + " ");
            }
        }
    }
}
