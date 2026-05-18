using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outroNumero)
        {
            return num + outroNumero;
        }
        public static int Subtracao(this int num, int outroNumero)
        {
            return num - outroNumero;
        }
    }
    class MetodosDeExtensao
    {
        
        public static void Executar()
        {
            int numero = 5;
            Console.WriteLine(numero.Soma(5));
            Console.WriteLine(numero.Subtracao(5));

            Console.WriteLine(2.Soma(5));
            Console.WriteLine(5.Subtracao(5));
        }
    }
}
