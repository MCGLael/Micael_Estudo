using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.EstruturaDeControle
{
    internal class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimento com uma nota de 0 a 5");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out int nota);
                switch(nota){
                    case 0:
                        Console.WriteLine("Péssimo");
                        break;
                    case 1:
                        Console.WriteLine("Ruim");
                        break;
                    case 2:
                        Console.WriteLine("Regular");
                        break;
                    case 3:
                        Console.WriteLine("meh");
                        break;
                    case 4:
                        Console.WriteLine("Bom");
                        break;
                    case 5:
                        Console.WriteLine("Perfeito!");
                        break;
                default:
                    Console.WriteLine("Nota Invalida");
                    break;
                }
            }
        }
    }

