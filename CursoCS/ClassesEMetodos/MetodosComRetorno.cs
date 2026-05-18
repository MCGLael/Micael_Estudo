using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar (int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public int Dividir(int a, int b)
        {
            return a / b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
    }
    class MetodosComRetorno
    {
        public static void Executar()
        {
            CalculadoraComum c1 = new CalculadoraComum();
            var resultado = c1.Somar(7, 9);

            Console.WriteLine(resultado);
            Console.WriteLine(c1.Subtrair(20, 50));
            Console.WriteLine(c1.Multiplicar(100, 50));
            Console.WriteLine(c1.Dividir(100, 2));

            var calc2 = new CalculadoraCadeia();

            calc2.Somar(5).Multiplicar(10).Imprimir().Limpar().Imprimir();

        }
    }
}
