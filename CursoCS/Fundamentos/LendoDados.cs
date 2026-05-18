using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            //recebendo o valor do usuario
            Console.Write("qual seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Seu nome é {nome} doidera");

            //Recebendo o valor do usuario e convertendo para int, o '.Parse' é usado para converter para o tipo de variavel desejada
            Console.Write("Qual sua idade?");

            //Convertedo de String para Int utilizando o 'Int.Parse'
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sua idade é {idade}");

            //Convertendo para Double utilizando o 'double.Parse
            Console.Write("Me diga qual sua pretenção salarial");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine($"Então sua pretenção salaria é de R${salario}");

            //OBS, o console pede o ', (Virgula)' para separar os decimais, para que isso não influencie, vamos ver a seguir
            Console.Write("Quanto você ganhava no seu ultimo emprego?");
            double salarioAnterior = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Então você ganhava R${salarioAnterior}");
        }
    }
}
