using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Colecoes
{
    internal class ColecoesDictcionary
    {
        public static void Executar()
        {
            var jogos = new Dictionary<int, string>();//Cria um dicionário do tipo int e string onde int é a chave e string é o valor

            jogos.Add(1999, "Sonic Adventures");
            jogos.Add(2001, "Shadow Adventures 2");
            jogos.Add(2003, "Sonic Heroes");
            jogos.Add(2005, "Shadow The Hedgehog");
            jogos.Add(2006, "Sonic 06");

            if (jogos.ContainsKey(2005))
            {
                Console.WriteLine("Em 2005 foi lançado {0}", jogos[2005]);
                
            }

            Console.WriteLine(jogos.ContainsValue("Silver the Hedgehog"));//Verifica se o valor "Silver the Hedgehog" existe no dicionário e mostra o resultado

            Console.WriteLine("Removeu?: {0}", jogos.Remove(1999));//Remove o elemento com a chave 1999 do dicionário e mostra se foi removido ou não

            jogos.TryGetValue(1999, out string jogo1999);
            Console.WriteLine("jogo {0}", jogo1999);

            foreach (var games in jogos)
            {
                Console.WriteLine("No ano de {0} saiu o jogo {1}", games.Key, games.Value);
            }


        }
    }
}
