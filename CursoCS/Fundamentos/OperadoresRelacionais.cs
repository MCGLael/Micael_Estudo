using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //double nota = 6.0;
            Console.Write("Qual sua nota? ");
            double.TryParse(Console.ReadLine(), out double nota);
            double media = 7.0;
            Console.WriteLine($"Valor de nota acima do permetido: {nota > 10.0}");
            Console.WriteLine($"Valor de nota abaixo do permetido: {nota < 0.0}");
            Console.WriteLine($"Aprovado: {nota >= media}");
            Console.WriteLine($"Recuperação: {nota <= media && nota > 3.0}");
            Console.WriteLine($"Reprovado: {nota <= 3.0}");
        }
    }
}
