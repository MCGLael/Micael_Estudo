using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.MetodosEFuncoes
{
    delegate double Operacao(int x, int y);
    internal class LambdasDelegate
    {
        public static void Executar()
        {
            Operacao soma = (x, y) => x + y;
            Operacao subtracao = (x, y) => x - y;
            Operacao divisao = (x, y) => x / y;
            Operacao multiplicacao = (x, y) => x * y;

            Console.WriteLine(soma(10, 3));
            Console.WriteLine(subtracao(10, 3));
            Console.WriteLine(divisao(10, 3));
            Console.WriteLine(multiplicacao(10, 3));

        }
    }
}
