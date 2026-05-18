using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "\n Tocando";
        }

    }
    public class Iphone : Celular{
        public override string Assistente()
        {
            return "\n Hello Siri!";
        }
    

    }
    public class Motorola : Celular
    {
        public override string Assistente()
        {
            return "\n Hello Moto!";
        }
        
    }
    
        
    
    internal class Abstract
    {
        public static void Executar()
        {
            List<Celular> Celular = new List<Celular>
            {
                new Iphone(),
                new Motorola()

            };
            foreach(var celula in Celular)
            {
                Console.WriteLine(celula.Tocar());
                Console.WriteLine(celula.Assistente());
            }

        }
    }
}
