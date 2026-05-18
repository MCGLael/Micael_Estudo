using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.MetodosEFuncoes
{
    internal class DelegateComFuncoesAnonimas
    {
        delegate string StringOperacao(string s);
        public static void Executar()
        {

            StringOperacao inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);

            };
            var inv = inverter("C# é Show");
            Console.WriteLine(inv);
        }
    }
}
