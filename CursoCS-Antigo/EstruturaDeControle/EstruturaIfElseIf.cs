using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.EstruturaDeControle
{
    internal class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite sua idade");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out int idade);
            if (idade < 18)
            {
                Console.WriteLine("Você é menor de idade");
            }else if(idade >= 18 && idade <= 65)
            {
                Console.WriteLine("Você é adulto");
            }else if (idade > 65)
            {
                Console.WriteLine("Você é idoso");
            }
            else
            {
                Console.WriteLine("Idade inválida");
            }
            
            Console.WriteLine("Fim");
        }
    }
}
