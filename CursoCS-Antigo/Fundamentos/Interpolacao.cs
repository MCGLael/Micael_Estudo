using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebroken Gamer";
            string marca = "Positivo";
            double preco = 5000.00;

            //Uma forma de concatenar as variaveis e os textos é usando o simbolo +, mas isso pode gerar um texto confuso
            Console.WriteLine("O " + nome + " da marca " + marca + "custa " + preco + ".");

            //Outra forma é usando a interpolação, que é mais legivel e fácil de entender
            Console.WriteLine("O {0} da marca {1} custa {2}", nome, marca, preco);

            //Uma terceira forma de fazer a interpolação é usando o simbolo $ antes da string, e as variaveis entre chaves {}
            Console.WriteLine($"O {nome} da marca {marca} custa {preco}");

            //Entre {} tambem pode ser feito calculos, como por exemplo:
            Console.WriteLine($"O valor de 1 + 1 é {1 + 1}");
        }
    }
}
