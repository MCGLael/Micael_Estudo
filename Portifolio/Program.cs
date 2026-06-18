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
            Console.WriteLine("Escolha o exemplo que quer executar: \n1 -> Calc\n2 -> TemperatureConverter" +
                "\n3 -> Guessing Game\n4 -> Login System\n5 -> Jo Ken Pô\n6 -> RPG Game\n7 -> Bank Account");
            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                Console.WriteLine("Opção invalida. Encerrando programa...");
                Console.ReadKey();
                return;
            }
            Dictionary<int, (string Name, Action Executar)> Exercicios = new()
            {
                /*INICIANTE*/
                {1, ("Calculator", Calculadora.Executar)},
                {2, ("Temperature convertor", ConversorTemperatura.Executar)},
                {3, ("Guessing Game", JogoAdivinha.Executar)},
                {4, ("Login System", SistemaLogin.Executar)},
                {5, ("Jo Ken Po!", PedraPapelTesoura.Executar)},

                /*INTERMEDIARIO*/
                {6, ("RPG", RpgProject.Executar)},
                {7, ("Bank Account", BankAccount.Executar)}

            };
            if(Exercicios.TryGetValue(opcao, out var Executar))
            {
                Executar.Executar();
            }
            else { 
                Exercicios.Last().Value.Executar();
            }
            foreach(var Exercicio in Exercicios)
            {
                Console.WriteLine($"{Exercicio.Key} - {Exercicio.Value.Name}");
            }
        }
    }
}