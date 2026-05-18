using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{
    internal class ValorVsReferencia
    {
        public class Dependente
        {
            public string Nome;
            public int Idade;
        }
        public static void Executar()
        {
            Dependente dep1 = new Dependente { Nome = "Daniel", Idade = 26 };

            Console.WriteLine("O nome do Dependente 1 é: {0} e sua Idade é: {1}", dep1.Nome, dep1.Idade);
            Dependente dep2 = dep1;
            Console.WriteLine("O Nome do Dependente 2 é {0} e sua idade é {1}", dep2.Nome, dep2.Idade);
            dep1.Nome = "Irineu";
            Console.WriteLine("O Nome do Dependente 1 é {0} e sua idade é {1}", dep1.Nome, dep1.Idade);
            Console.WriteLine("O Nome do Dependente 2 é {0} e sua idade é {1}", dep2.Nome, dep2.Idade);

        }
    }
}
