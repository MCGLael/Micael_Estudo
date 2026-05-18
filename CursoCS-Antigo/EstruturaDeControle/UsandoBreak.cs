using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.EstruturaDeControle
{
    internal class UsandoBreak
    {
        public static void Executar()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var numero in numeros)
            {
                if (numero == 4)
                {
                    Console.WriteLine("Quatro encontrado, saindo do loop.");
                    break; // Sai do loop quando encontrar o número 4
                }
                Console.WriteLine($"Número atual: {numero}");
            }
        }
    }
}
