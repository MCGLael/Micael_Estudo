using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            var arraylist = new ArrayList
            {"Shadow", true, };
            arraylist.Add(32.14);
            foreach(var item in arraylist)
            {
                Console.WriteLine("{0} -> {1}", item, item.GetType());
            }
        }
    }
}
