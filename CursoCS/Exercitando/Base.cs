using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCS.Exercitando.Base;

namespace CursoCS.Exercitando
{
    internal class Base

    {
        public class Exercicios
        {
            public Exercicios()
            {
                Console.WriteLine("simbora");
            }

            public Exercicios(string a)
            {
                Console.WriteLine(a + "bigael");
            }
        }

        public class Filha : Exercicios
        {
            public Filha()
            {
                Console.WriteLine("Sem parametro");
            }
            public Filha(string a) : base(a)
        {
            Console.WriteLine(a + " Isso");
        }

     }
        public static void Executar()
        {
            Exercicios tiago = new Exercicios("Tiago");
            Exercicios monjuro = new Exercicios();
            Filha alicia = new Filha("Ali");
            Filha josias = new Filha();

            Console.Read();





        }
    }
}
