using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
   public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Tenho um Instagram";

        //herança
        protected string CorDoOlho = "Verde";

        //Mesmo projeto (assembly)
        internal ulong NumeroCelular = 5585986544322;

        //herança ou mesmo projeto

        protected internal string JeitoDeFalar = "Uso muitas girias";

        //mesma class ou herança no mesmo projeto (c# >= 7.2)
        private protected string SegredoFamilia = "blablabla";

        //private é o padrão

        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
                Console.WriteLine(CorDoOlho);
                Console.WriteLine(NumeroCelular);
                Console.WriteLine(JeitoDeFalar);
                Console.WriteLine(SegredoFamilia);
                Console.WriteLine(UsaMuitoPhotoshop);
        }

    }
}
