using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{
    
    class DesafioAcessarAtribudo
    {
        int a = 10;
        public static void Executar() {


            //Console.WriteLine(int a);

            DesafioAcessarAtribudo desafio = new DesafioAcessarAtribudo();
            Console.WriteLine(desafio.a);
        }
    }
}
