using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Somar(50, 50);
            Console.WriteLine($"A Soma é: {resultado}");

            Console.WriteLine(CalculadoraEstatica.Somar(50, 100));

            var multresult = CalculadoraEstatica.Multiplicar(30, 2);
            Console.WriteLine($"Resultado da multiplicação é: {multresult}");
        }

    }
}
