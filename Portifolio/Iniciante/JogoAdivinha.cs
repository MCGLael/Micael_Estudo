using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Iniciante
{

    internal class JogoAdivinha
    {
        public static void Executar()
        {

            Console.WriteLine("Bem vindo ao jogo de adivinha, você terá 5 chances para adivinhar um numero entre 0 e 10 ");
            int opcao;
            int i = 0;
            //int random;
            int random = new Random().Next(0, 11);
            do
            {
                i++;
                Console.WriteLine($"{i}/5 Chances");
                
                Console.WriteLine("\nDigite um numero entre 0 a 10");

                if (!int.TryParse(Console.ReadLine(), out opcao)|| opcao > 10 || opcao <0)
                {Console.WriteLine("Opção invalida, tente novamente");continue; }

                
                if (opcao == random)
                {
                    Console.WriteLine("\nCorreto! Meus parabens, você ganhou!");
                    
                    return;
                }
                else
                {
                    Console.WriteLine("\nErrado!");
                    
                }
                

            } while ( i < 5);
            Console.WriteLine("\nSuas chances acabaram, o numero correto era: {0} ToT", random);

        }
    }


}


