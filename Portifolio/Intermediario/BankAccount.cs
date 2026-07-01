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

        public Account(string ownername, decimal balance, int password)
        {
            OwnerName = ownername;
            Balance = balance;
            Password = password;
        }
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

    internal class BankAccount
    {
        static List<Account> accounts = new()
            {
                new Account("Thiago Matias", 1500, 1111),
                new Account("Nate Jacobs", 0, 1221),
                new Account("Dylan Ribeiro", 600, 1234)

            };

        public static decimal money()
        {
            if (!decimal.TryParse(Console.ReadLine(), out decimal Money)) { Console.WriteLine("Invalid"); return 0; }
            return Money;
        }
        public static Account Login(int UserPassword)
        {

            foreach(Account account in accounts)
            {
                if(UserPassword == account.Password)
                {
                    return account;
                }     
            }
            return null;
            
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
            Account User = Login(password);
            if(User == null) { Console.WriteLine("User Invalid. Exit program"); return; }
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

