using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.EstruturaDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 3);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            //int tentativas = 0;

            Console.WriteLine("Bem vindo ao jogo de advinha, advinhe o numero secreto!");

            while (tentativasRestantes != 0 && !numeroEncontrado)
            {
               
                Console.WriteLine($"Você tem {tentativasRestantes} tentativas restantes");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);
                
                if(palpite > numeroSecreto)
                {
                    Console.WriteLine("O Numero que você tentou é maior que o numero correto.");

                }
                else if(palpite < numeroSecreto){
                    Console.WriteLine("O NUmero que você tentou é menor que o numero correto");
                }
                else if(palpite == numeroSecreto)
                {
                    Console.WriteLine("Parabéns, você acertou!!!");
                    numeroEncontrado = true;
                }
                tentativasRestantes--;

            }
            if(numeroEncontrado)
                {
                var corAnterior = Console.BackgroundColor;
                Console.WriteLine("Você ganhou!");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.BackgroundColor = corAnterior;

            }
            else if(!numeroEncontrado)
            {
                Console.WriteLine("Suas tentativas acabaram, o numero secreto era " + numeroSecreto);

            }
        }
    }
}
