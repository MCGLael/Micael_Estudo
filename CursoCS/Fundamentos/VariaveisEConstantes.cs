using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Area de circunferencia
            double raio = 4.5;
            //declarando variavel e constante
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            //Se colocar numero junto com a concatenação, ele junta como uma string
            Console.WriteLine("O valor da Area é " + area);

            //Para concatenar realizando o calculo:
            //Console.WriteLine("O Valor da Area é: " + (area + 1000));

            //Tipos internos

            //Usanto Booleano para dizer se é verdadeiro ou falso
            bool EstaChovendo = true;
            Console.WriteLine("Esta chovendo? " + EstaChovendo);

            byte idade = 45;
            Console.WriteLine("A Idade é: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            sbyte saldoDeGols2 = sbyte.MaxValue;

            Console.WriteLine("O valor minimo de um sbyte é: " + saldoDeGols);
            Console.WriteLine("O Valor maximo de um sbyte é: " + saldoDeGols2);

            short salario = short.MinValue;
            Console.WriteLine("O Valor minimo de um tipo Short é: " + salario);

            int menorValor = int.MinValue;
            Console.WriteLine("O Menor valor de um tipo Int é: " + menorValor);

            long menorValorLong = long.MinValue;
            Console.WriteLine("O menor valor de um tipo Long é: " + menorValorLong);

            double MenorValorDouble = double.MinValue;
            Console.WriteLine("O menor valor Double é: " + MenorValorDouble);

            char letra = 'x';

            string texto = "Ola mundo denovo";
            Console.WriteLine("Tipo Char só armazena uma letra, no caso: " + letra + " e o tipo String armazena frases: " + texto);

        }
    }
}
