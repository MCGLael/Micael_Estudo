using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.TopicosAvancados
{
    internal class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;//Nullable é uma struct generica, ou seja, pode ser usada para qualquer tipo de valor, como int, double, bool, etc. Ela é usada para representar um valor que pode ser nulo, ou seja, que pode não ter um valor definido. Para acessar o valor de um nullable, é necessário usar a propriedade Value, que retorna o valor do nullable se ele tiver um valor definido, ou lança uma exceção se ele for nulo. Para verificar se um nullable tem um valor definido, é possível usar a propriedade HasValue, que retorna true se o nullable tiver um valor definido e false se ele for nulo.
            int? num2 = null;//Forma mais simples de declarar um nullable

            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num: {0}", num1);
            }
            else
            {
                Console.WriteLine("A variavel não possui valor.");
            }
            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try
            {
                //int x = num1.Value;//Lança uma exceção, pois num1 é nulo
                //int y = num2.Value;//Lança uma exceção, pois num2 é nulo
                int x = num1.GetValueOrDefault();//Retorna o valor padrão de int, que é 0, pois num1 é nulo
                int y = num2.GetValueOrDefault();//Retorna o valor padrão de int, que é 0, pois num1 é nulo
                Console.WriteLine(x + y);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
