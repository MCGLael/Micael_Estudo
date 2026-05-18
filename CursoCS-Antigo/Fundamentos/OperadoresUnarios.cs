using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var valor1 = 2;
            var valor2 = 3;

            Console.WriteLine(valor1++ == --valor2);
            Console.WriteLine($"Valor 1 incrementado é {valor1} e valor 2 decrementado é {valor2}");

        }
    }
}
