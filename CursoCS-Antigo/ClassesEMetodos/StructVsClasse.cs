using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{
    struct SPonto
    {
       public int X;
        public int Y;
    }
    public class CPonto
    {
        public int X;
        public int Y;
        
    }
    internal class StructVsClasse
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            Console.WriteLine("Y: {0}",ponto1.Y);
            Console.WriteLine("X: {0}", ponto1.X);

            SPonto copiaPonto1 = ponto1;
            ponto1.X = 5;

            Console.WriteLine("O valor do Ponto 1 é: {0}",ponto1.X);
            Console.WriteLine("O valor do Copia Ponto 1 é {0}",copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 10, Y = 20 };
            Console.WriteLine("O valor de X do Ponto 2 é {0} e o Valor de Y é {1}", ponto2.X, ponto2.Y);
            CPonto copiaPonto2 = ponto2;
            ponto2.X = 30;
            Console.WriteLine("O valor de X do Copia Ponto 2 é {0} e o Valor de Y é {1}", copiaPonto2.X, copiaPonto2.Y);
            Console.WriteLine("O valor de X do Ponto 2 é {0} e o Valor de Y é {1}", ponto2.X, ponto2.Y);
        }
    }
}
