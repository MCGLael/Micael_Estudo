using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{
    public class Cliente 
    {
        public string Nome;
        DateTime Nascimento;
        
        public Cliente(String nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }
        public string GetDataNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }

    internal class ReadyOnly
    {
        public static void Executar()
        {
            var Cliente1 = new Cliente("Isabela Silva", new DateTime(24, 02, 2000));

            Console.WriteLine(Cliente1.Nome);
            Console.WriteLine(Cliente1.GetDataNascimento());

        }
    }
}
