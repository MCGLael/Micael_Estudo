using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace CursoCS.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    { 
    
        public new void MeuAcessos()
    {
        Console.WriteLine("FilhoNaoReconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop); Privado não é acessível
        }
    }

    public class AmigoDistante
    {
        public void MeusAcessos()
        {
            var sub = new SubCelebridade();
            Console.WriteLine("AmigoDistante...");
            Console.WriteLine(sub.InfoPublica);
            //Console.WriteLine(sub.CorDoOlho); Protegido não é acessível
            //Console.WriteLine(sub.NumeroCelular); Privado não é acessível
            //Console.WriteLine(sub.JeitoDeFalar); Protegido não é acessível
            //Console.WriteLine(sub.SegredoFamilia); Protegido não é acessível
            //Console.WriteLine(sub.UsaMuitoPhotoshop); Privado não é acessível
        }
    }
    internal class Encapsulament
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new FilhoReconhecido().MeusAcessos();
        }
    }
}
