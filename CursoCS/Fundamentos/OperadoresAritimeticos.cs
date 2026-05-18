using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Fundamentos
{
    internal class OperadoresAritimeticos
    {
        public static void Executar()
        {
            //Preco Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.3;

            double total = preco + imposto;
            var totalComDesconto = total - (total* desconto);
            Console.WriteLine($"O Preço final é: {totalComDesconto}");

            //Calculando IMC
            double peso = 99.8;
            double altura = 1.70;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"O IMC é: {imc}");

            //Numero par ou impar
            int par = 24;
            int impar = 65;
            Console.WriteLine($"{par / 2} Tem resto {par % 2}");
            Console.WriteLine($"{impar / 2} Tem resto {impar % 2}");

        }
    }
}
