using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();//Cria uma fila do tipo string

            fila.Enqueue("Shadow The Hedgehog");//Adciona um elemento na fila
            fila.Enqueue("Sonic the Hedgehog");
            fila.Enqueue("Silver the Hedgehog");

            Console.WriteLine("Quem está no topo da fila é {0}", fila.Peek());//Mostra quem está no topo da fila
            Console.WriteLine("O tamanho da fila é : {0}", fila.Count);

            Console.WriteLine("{0} Foi removido da fila", fila.Dequeue());//Remove o elemento do topo da fila e mostra quem foi removido
            Console.WriteLine("O tamanho da fila é : {0}", fila.Count);//Mostra o tamanho da fila

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();//Cria uma fila sem tipo definido

            salada.Enqueue("Alface");
            salada.Enqueue(5);
            salada.Enqueue(3.58);

            Console.WriteLine(salada.Contains("Tapioca"));
            Console.WriteLine(salada.Contains("Alface"));
        }
    }
}
