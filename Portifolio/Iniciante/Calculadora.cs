using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Iniciante
{
    public class Operacoes
    {
        int X;
        int Y;


        public Operacoes(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Soma()
        {
            int calc = X + Y;
            Console.WriteLine(calc);
        }
        public void Subtracao()
        {
            int calc = X - Y;

            Console.WriteLine(calc);
        }
        public void Divisao()
        {
            int calc = X / Y;
            Console.WriteLine(calc);
        }
        public void Multiplicacao()
        {
            int calc = X * Y;
            Console.WriteLine(calc);
        }
    }



    class Calculadora
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o valor de X");
            if(!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Valor Invalido, encerrando programa...");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Digite o valor de Y");
            if (!int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine("Valor Invalido, encerrando programa...");
                Console.ReadKey();
                return;
            }
            Operacoes operacao = new Operacoes(x, y);
            Console.WriteLine("+ -> Soma\n- -> Subtração\n* -> Multiplicação\n/ -> Divisão\nS -> Sair");
            var opcao = Console.ReadLine();
            switch (opcao?.ToLower())
            {
                case "+":
                    operacao.Soma();
                    break;
                case "-":
                    operacao.Subtracao();
                    break;
                case "*":
                    operacao.Multiplicacao();
                    break;
                case "/":
                    try
                    {
                        operacao.Divisao();
                    }
                    catch (DivideByZeroException) { 
                        Console.WriteLine("Não é possível dividir por zero");
                    }
                    
                    break;
                case "s":
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.ReadKey();


        }
    }
}

