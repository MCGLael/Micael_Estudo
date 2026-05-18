using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{
    internal class ParametroPadrao
    {
        public static int Somar(int a = 1, int b = 10)
        {
            return a + b;
        }
        public static void Executar()
        {
            Console.WriteLine(Somar(10));
            Console.WriteLine(Somar(10, 30));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b: 7));
        }
    }
}
