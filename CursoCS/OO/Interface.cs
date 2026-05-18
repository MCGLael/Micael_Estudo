using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.OO
{
    internal class Interface
    {
        interface OperacaoBinaria
        {
            int Operacao(int a, int b);
        }

        class  Soma : OperacaoBinaria 
        {
            public int Operacao(int a, int b) { 
            return a + b;
            }

        }
        class  Subtracao : OperacaoBinaria 
        {
            public int Operacao(int a, int b) { 
            return a - b;
            }

        }
        class  Divisao : OperacaoBinaria 
        {
            public int Operacao(int a, int b) { 
            return a / b;
            }

        }
        class  Multiplicacao : OperacaoBinaria 
        {
            public int Operacao(int a, int b) { 
            return a * b;
            }

        }
        public class Calculadora
        {

            List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
            {
                new Soma(),
                new Subtracao(),
                new Divisao(),
                new Multiplicacao()
            };
            public string ExecutarOperacoes(int a, int b)
            {
                string resultado = "";
                foreach (var calculadora in operacoes)
                {
                    resultado += $"Usando {calculadora.GetType().Name} = {calculadora.Operacao(a, b)}\n";
                }
                return resultado;
            }
        }
        
        public static void Executar()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.ExecutarOperacoes(100, 2);
            Console.WriteLine(resultado);

        }
    }
}
