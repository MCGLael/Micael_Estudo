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
    public class UserOne : Account 
    {
        public UserOne()
        {
            OwnerName = "Thiago Matias";
            Balance = 1500;
            Password = 1233;
        }
    
    }
    public class UserTwo : Account
    {
        public UserTwo()
        {
            OwnerName = "Nate Jacobs";
            Balance = 0;
            Password = 1324;
        }

    }
    public class UserThree : Account
    {
        public UserThree()
        {
            OwnerName = "Dylan Ribeiro";
            Balance = 500;
            Password = 1111;
        }

    }


    internal class BankAccount
    {
        
        public static decimal money()
        {
            
            if (!decimal.TryParse(Console.ReadLine(), out decimal Money)) { Console.WriteLine("Invalid"); return 0; }
            return Money;
        }
        public static Account Validation(int UserPassword)
        {
            switch (UserPassword)
            {
                case 1233:
                    return new UserOne();
                case 1324:
                    return new UserTwo();
                case 1111:
                    return new UserThree();
                default:
                    Console.WriteLine("Wrong Password, please take out your card");
                    return null;
            }
        }
        public static void AccountOptions(int Option, Account User)
        {
            
            switch (Option)
            {
                case 1:
                    Console.WriteLine("Deposit\n");
                    Console.WriteLine("how much would you like to deposit?\n");
                    
                    User.deposit(money());
                    break;
                    
                case 2:
                    Console.WriteLine("Withdraw\n");
                    Console.WriteLine("how much would you like to Withdraw?\n");
                    User.withDraw(money());
                    break;
                case 3:
                    Console.WriteLine("Balance\n");
                    Console.WriteLine($"Your current Balance is: {User.Balance}\n");
                    break;
                case 4:
                    Console.WriteLine("Exiting... Please take your card out\n");
                    break;
                default:
                    Console.WriteLine("Invalid option, please take out your card\n");
                    
                    break;

            }
        }
        public static void Executar()
        {
            
            Console.WriteLine("Welcome to ThunderBank, please insert your card...");
            Console.WriteLine("Password:\n");
            if (!int.TryParse(Console.ReadLine(), out int password)) { Console.WriteLine("Invalid, please take out your card"); return; }
            Account User = Validation(password);
            Console.WriteLine($"Welcome {User.OwnerName}\n");
            bool exit = false;
            while (!exit == true)
            {
                Console.WriteLine("What would you like to do?\n1 -> Deposit\n2 -> WithDraw\n3 -> Balance\n4 -> Exit");
                if (!int.TryParse(Console.ReadLine(), out int option)) { Console.WriteLine("Invalid, please take out your card"); return; }
                AccountOptions(option, User);
                if (option == 4) { exit = true; }
            }
            Console.WriteLine("Thank you for using ThunderBank services!");

        }
        }
    } 

