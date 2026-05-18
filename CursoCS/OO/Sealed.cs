using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.OO
{
    internal class Sealed
    {
        sealed class SemFilho
        {
            public double ValorFortuna()
            {
                return 1_400_800.65;
            }
        }

            class Avo 
            {
                public virtual bool HonrarFamilia()
                {
                    return true;
                }
            }
            class Pai : Avo
            {
                public override sealed bool HonrarFamilia()
                {
                    return true;
                }
            }
            class FilhoRebelde : Pai { 
            
            //    public override sealed bool HonrarFamilia()
            //    {
            //        return true;
            //    }
            }
        
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorFortuna());
            Pai pai = new Pai();
            Console.WriteLine(pai.HonrarFamilia());
            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarFamilia());
            
        }
    }
}
