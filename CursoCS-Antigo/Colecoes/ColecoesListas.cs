using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)//Sobrescreve o método equals para comparar os objetos da classe produto
        {
            Produto outroProduto = (Produto)obj;//Faz um cast do objeto para o tipo produto
            bool mesmoNome = Nome == outroProduto.Nome;//Compara o nome do produto com o nome do outro produto
            bool mesmoPreco = Preco == outroProduto.Preco;//Compara o preço do produto com o preço do outro produto
            return mesmoNome && mesmoPreco;//Retorna true se o nome e o preço forem iguais, caso contrário retorna false
        }

        public override int GetHashCode()
        {
            return Nome.Length;//Retorna o tamanho do nome do produto como hash code

        }
        internal class ColecoesListas
        {

            public static void Executar()
            {
                var livro = new Produto("Sonic hte hedgehog", 50.5);//Cria um novo produto chamado livro
                var carrinho = new List<Produto>();//Cria uma lista tipo produto chamada carrinho
                carrinho.Add(livro);

                var combo = new List<Produto>//Cria uma nova lista do tipo produto
            {
                new Produto("Shadow the Hedgehog" , 30.99),
                new Produto("Sonic X Shadow Generations" , 30.70),
                new Produto("Sonic and the Secret Rings" , 10.80)
            };

                carrinho.AddRange(combo);//Adciona a lista combo na lista carrinho
                Console.WriteLine("O Carrinho contem {0}", carrinho.Count);
                carrinho.RemoveAt(3);
                foreach (var produto in carrinho)//Percorre a lista e mostra o indice do produto e o nome e preco do produto
                {
                    Console.WriteLine(carrinho.IndexOf(produto));
                    Console.WriteLine("{0} {1}R$", produto.Nome, produto.Preco);
                }


            }
        }
    }
}
