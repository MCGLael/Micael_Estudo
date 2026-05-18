using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 6.0;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine($"Você foi {resultado}");
        }
    }
}
