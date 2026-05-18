using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{

    class Membros
    {

        public static void Executar()
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Micael";
            p1.Idade = 20;
            p1.ApresentarNoConsole();

            var p2 = new Pessoa();
            p2.Nome = "Lael";
            p2.Idade = 18;
            var apresentacao = p2.Apresentar();
            Console.WriteLine(apresentacao.Length);
            Console.WriteLine(apresentacao);

        }

    }
}