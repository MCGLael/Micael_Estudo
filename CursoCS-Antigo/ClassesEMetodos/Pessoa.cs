using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"O {Nome} tem {Idade} de idade");

        }
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}
