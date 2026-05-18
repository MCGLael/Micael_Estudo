using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            //C# entende que o tipo da variavel é String por conta do texto e das aspas duplas
            var nome = "Micael";
            Console.WriteLine(nome);

            //Aqui ele entende que é int por que inicializou com um valor inteiro
            var idade = 25;
            Console.WriteLine(idade);
        }
    }
    
}
