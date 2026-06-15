using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Intermediario
{
    public class Account
    {
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }
        public int Password { get; set; }

        public void deposit(decimal Amount)
        {
            Balance += Amount;
        }

        public void withDraw(decimal Amount)
        {
            if(Amount > Balance)
            {
                Console.WriteLine("insuficient Balance");
                return;
            }
            Balance -= Amount;
        }

    }

    

    internal class ContaBancaria
    {
        
        public decimal money()
        {
            
            if (!decimal.TryParse(Console.ReadLine(), out decimal Money)) { Console.WriteLine("Invalid"); return 0; }
            return Money;
        }
        public static Account Validation(int UserPassword)
        {
            switch (UserPassword)
            {
                case 1233:
                    Console.WriteLine("Welcome Thiago Matias");
                    return Account UserOne;
                case 1324:
                    Console.WriteLine("Welcome Nate Jacobs");
                    break;
                case 1111:
                    Console.WriteLine("Welcome Dylan Ribeiro");
                    break;
                default:
                    Console.WriteLine("Wrong Password, please take out your card");
                    return;
            }
        }
        public void AccountOptions(int Option, Account User)
        {
            switch (Option)
            {
                case 1:
                    Console.WriteLine("Deposit\n");
                    Console.WriteLine("how much would you like to deposit?");
                    
                    User.deposit(money());
                    break;
                    
                case 2:
                    Console.WriteLine("Withdraw\n");
                    Console.WriteLine("how much would you like to Withdraw?");
                    User.withDraw(money());
                    break;
                case 3:
                    Console.WriteLine("Balance\n");
                    Console.WriteLine($"Your current Balance is: {User.Balance}");
                    break;
                default:
                    Console.WriteLine("Invalid option, please take out your card");
                    break;

            }
        }
        public static void Executar()
        {
            Account UserOne = new Account();
            Account UserTwo = new Account();
            Account UserThree = new Account();
            UserOne.OwnerName = "Thiago Matias";
            UserOne.Balance = 1500;
            UserOne.Password = 1233;
            UserTwo.OwnerName = "Nate Jacobs";
            UserTwo.Balance = 0;
            UserTwo.Password = 1324;
            UserThree.OwnerName = "Dylan Ribeiro";
            UserThree.Balance = 500;
            UserThree.Password = 1111;


            Console.WriteLine("Welcome to ThunderBank, please insert your card...");
            Console.WriteLine("Password:\n");
            if (!int.TryParse(Console.ReadLine(), out int password)) { Console.WriteLine("Invalid, please take out your card"); return; }
            Validation(password);
            
            
            }
        }
    } 
}
