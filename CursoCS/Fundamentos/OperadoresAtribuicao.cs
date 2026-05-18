using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            Console.WriteLine("Valor inicial: {0}", num1);
            num1 = 7;
            Console.WriteLine("Valor subistituindo valor por 7: {0}", num1);
            num1 += 3; // num1 = num1 + 3
            Console.WriteLine("Valor + 3: {0}", num1);
            num1 -= 1; // num1 = num1 - 1
            Console.WriteLine("valor - 1: {0}", num1);
            num1 *= 2; // num1 = num1 * 2
            Console.WriteLine("valor vezes 2: {0}", num1);
            num1 /= 2; // num1 = num1 / 2
            Console.WriteLine("valor dividido por 2: {0}", num1);

            int a = 1;
            int b = a;

            a++;
            b--;

            Console.WriteLine($"{a} {b}");
        }
    }
}
