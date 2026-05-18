using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{

    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.5;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            
        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }
    class AtributosEstaticos
    {

        public static void Executar()
        {
            var produto1 = new Produto("Ovo", 15.0);

            var produto2 = new Produto("Picanha", 50.5);

            Console.WriteLine($"O Valor do produto com desconto é de : {produto1.CalcularDesconto()}");
            Console.WriteLine($"O Valor do produto com desconto é de : {produto2.CalcularDesconto()}");

        }
    }
}
