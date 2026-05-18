using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            //Realizar conversões de tipos
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 7.8;

            //Realizando a conversão de double para int, o '(int)' é para dizer que eu quero converter para int, porem isso vai truncar o numero, ou seja, vai retirar a parte decimal
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            //Convertendo String para int utilizando o int.Parse()
            Console.WriteLine("Digite sua idade");
                string idadeString = Console.ReadLine();
                int idade = int.Parse(idadeString);
                Console.WriteLine($"Sua idade é: {idade}");

                //Agora utilizando o 'Convert.ToInt32()' para converter a string para int, porem isso vai gerar um erro se o usuario digitar algo que não seja um numero
                idade = Convert.ToInt32(idadeString);
                Console.WriteLine($"Resultado de sua idade é: {idade}");

                //Utilizando o TryParse para converter a string para int, porem isso não vai gerar um erro se o usuario digitar algo que não seja um numero, porem vai retornar 0
                Console.WriteLine("Digite um número um");
                string palavra = Console.ReadLine();
                int numero1;
                int.TryParse(palavra, out numero1);
                Console.WriteLine($"O numero1 é: {numero1}");

                //Uma forma mais enxuta, colocando Console.ReadLine e declarando a variavel numero2 diretamente dentro do TryParse
                Console.WriteLine("Digite um número dois");
                int.TryParse(Console.ReadLine(), out int numero2);
                Console.WriteLine($"O numero2 é: {numero2}");
            
        }
    }
}

