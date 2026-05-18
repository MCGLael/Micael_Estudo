using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executoutrabalho1 = true;
            var executoutrabalho2 = false;

            bool comprouTv50 = executoutrabalho1 && executoutrabalho2;
            Console.WriteLine($"Comprou a Tv 50? {comprouTv50}");

            var comprouSorvete = executoutrabalho1 || executoutrabalho2;
            Console.WriteLine($"Comprou Sorvete? {comprouSorvete}");

            var comprouTv32 = executoutrabalho1 ^ executoutrabalho2;
            Console.WriteLine($"comprou Tv 32? {comprouTv32}");

            Console.WriteLine($"Mais saudavel? {!comprouSorvete}");


        }
    }
}
