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
            while(!update == true)
            {
                Console.WriteLine("Rock -> 1\nPaper -> 2\nScissors -> 3\nExit -> 0");
                if (!int.TryParse(Console.ReadLine(), out int option)) { Console.WriteLine("Invalid"); }
                int jogada = new Random().Next(1, 4);
                Options pc_opt = (Options)jogada;
                if(option == (int)pc_opt)
                {
                    Console.WriteLine("Draw");
                }else if(option == 1 && (int)pc_opt == 2)
                    Console.WriteLine($"Computer: {pc_opt}");
                    Console.WriteLine($"You: {option}");
                Console.WriteLine("You Lose!");

            }
            Console.WriteLine("Thank you for playing");


        }
        
    }
}
