using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.EstruturaDeControle
{
    internal class EstruturaForeach
    {
        public static void Executar()
        {
            var palavra = "Opa meu bom";

            foreach (var letra in palavra)
            {
                Console.WriteLine($"A letra tual é {letra}");
            }
        }
    }
}
