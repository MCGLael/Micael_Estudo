using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Colecoes
{
    internal class ColecaoStack
    {
        public static void Executar()
        {
            var pilha = new Stack();//Cria uma pilha sem tipo definido

            pilha.Push("Shadow the Hedgehog");//Adciona um elemento na pilha
            pilha.Push(50);
            pilha.Push(true);
            pilha.Push(75.4f);

            foreach(var item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("O {0} foi retirado da pilha", pilha.Pop());//Remove o elemento do topo da pilha e mostra quem foi retirado

            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }
        }
    }
}
