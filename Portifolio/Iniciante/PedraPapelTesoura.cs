using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Iniciante
{
    public enum Options
    {
        Pedra =1,
        Papel,
        Tesoura
    }
   
    
    internal class PedraPapelTesoura
    {
        public static void Executar()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors game!!!");
            
            var update = false;
            while (!update == true)
            {
                Console.WriteLine("Rock -> 1\nPaper -> 2\nScissors -> 3\nExit -> 0\n");

                if (!int.TryParse(Console.ReadLine(), out int option) || option < 0 || option > 3) { Console.WriteLine("Invalid\n"); continue; }
                if (option == 0) { update = true; continue; }

                int jogada = new Random().Next(1, 4);
                Options pc_opt = (Options)jogada;
                Options player = (Options)option;
                if (option == (int)pc_opt)
                {
                    Console.WriteLine($"Computer: {pc_opt}");
                    Console.WriteLine($"You: {player}");
                    Console.WriteLine("Draw!!!\n");
                } else if (option == 1 && (int)pc_opt == 3 || option == 2 && (int)pc_opt == 1 || option == 3 && (int)pc_opt == 2) { 
                    Console.WriteLine($"Computer: {pc_opt}");
                Console.WriteLine($"You: {player}");
                Console.WriteLine("You Win!!!\n"); }
                else
                {
                    Console.WriteLine($"Computer: {pc_opt}");
                    Console.WriteLine($"You: {player}");
                    Console.WriteLine("You Lose!!!\n");
                }
                


            }
            Console.WriteLine("Thank you for playing");


        }
        
    }
}
