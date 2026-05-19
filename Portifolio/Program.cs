using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Iniciante
{
    public class Programa
    {

        public static void Main()
        {
            Console.WriteLine("Escolha o exemplo que quer executar: \n1 -> Calculadora\n2 -> Conversor de temperatura");
            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                Console.WriteLine("Opção invalida. Encerrando programa...");
                Console.ReadKey();
                return;
            }
            switch (opcao)
            {
                case 1:
                        Calculadora.Executar();
                    break;
                case 2:
                    ConversorTemperatura.Executar();
                    break;
                default:
                    Console.WriteLine("Opção invalida, encerrando programa...");
                    return;
            }



        }
    }
}