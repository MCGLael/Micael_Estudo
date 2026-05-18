using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{
    internal class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero += 1000;
        }
        public static void AlterarOut(out int numero)
        {
            numero = 0;
            numero += 1000;
        }
        public static void Executar()
        {
            int a = 1;
            AlterarRef(ref a);
            Console.WriteLine(a);


            AlterarOut(out int b);
            Console.WriteLine(b);
        }
    }
}
