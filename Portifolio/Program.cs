using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portifolio.Iniciante;
using Portifolio.Intermediario;

namespace Portifolio
{
    public class Programa
    {

        public static void Main()
        {
            Console.WriteLine("Escolha o exemplo que quer executar: \n1 -> Calc\n2 -> TemperatureConverter\n3 -> Guessing Game\n4 -> Login System\n5 -> Jo Ken Pô\n6 -> RPG Game");
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
                case 3:
                    JogoAdivinha.Executar();
                    break;
                case 4:
                    SistemaLogin.Executar();
                    break;
                case 5:
                    PedraPapelTesoura.Executar();
                    break;
                case 6:
                    RpgProject.Executar();
                    break;
                default:
                    Console.WriteLine("Opção invalida, encerrando programa...");
                    return;
            }



        }
    }
}