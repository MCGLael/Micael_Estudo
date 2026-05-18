using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Colecoes
{
    class ColecoesSet
    {

        public static void Executar()
        {
            var livro = new Produto("Sonic hte hedgehog", 50.5);//Cria um novo produto chamado livro
            var carrinho = new HashSet<Produto>();//Cria uma lista tipo produto chamada carrinho
            carrinho.Add(livro);

            var combo = new HashSet<Produto>//Cria uma nova lista do tipo produto
            {
                new Produto("Shadow the Hedgehog" , 30.99),
                new Produto("Sonic X Shadow Generations" , 30.70),
                new Produto("Sonic and the Secret Rings" , 10.80),
                new Produto("Sonic and the Secret Rings" , 10.80)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine("O Carrinho contem {0}", carrinho.Count);
            //carrinho.RemoveAt(3);
            foreach (var produto in carrinho)//Percorre a lista e mostra o indice do produto e o nome e preco do produto
            {
                //Console.WriteLine(carrinho.IndexOf(produto));
                Console.WriteLine("{0} {1}R$", produto.Nome, produto.Preco);
            }


        }
    }
}
