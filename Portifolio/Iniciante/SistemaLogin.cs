using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Iniciante
{
    public class Usuario
    {
        public string Name { get; set;}
        public string Password { get; set;}

        
    }
    internal class SistemaLogin
    {
        public static void Executar()
        {
            string nome = "admn";
            string senha = "123";
            Usuario user = new Usuario();
            Console.WriteLine("Welcome to Sage's Bank\nInsert your Username and Password...");
            int i = 1;
            while( i <= 3){
               
                Console.Write("Username: "); user.Name = Console.ReadLine();
                Console.Write("Password: "); user.Password = Console.ReadLine();

                
                if(user.Name == nome && user.Password == senha)
                {
                    Console.WriteLine("Welcome {0}", user.Name);
                    return;
                }
                if (i == 3)
                {
                    Console.WriteLine("Too Many tries, please, try again lates");
                    return;
                }
                i++;
                Console.WriteLine("Username or Password incorrect, please verify your credentials \n");
                
                
            }
           


        }
    }
}
