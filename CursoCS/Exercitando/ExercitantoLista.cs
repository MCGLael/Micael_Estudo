using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Exercitando
{
    public abstract class Feiticeiro
    {
        public int HP { get; set; }
        public double MP { get; set; }

        public abstract void Atacar();

        public Feiticeiro(int hp, double mp)//construtor da classe feiticeiro
        {
            HP = hp;
            MP = mp;
        }
    }

    public class FeiticeiroDeFogo : Feiticeiro
    {
        int Dano = 30;
        public FeiticeiroDeFogo(int hp, int mp) : base(hp, mp)
        {

        }
        public override void Atacar()
        {
            Console.WriteLine("Bola de Fogo!");
        }
    }

    public class FeiticeiroDeAgua : Feiticeiro
    {
        int dano = 40;

        public FeiticeiroDeAgua(int hp, int mp): base(hp, mp)
        {
            
        }
        public override void Atacar()
        {
            Console.WriteLine("Correnteza de Agua!");
        }
    }
    internal class ExercitantoLista
    {
        public static void Executar()
        {
            Dictionary<int, Func<Feiticeiro>> character = new Dictionary<int, Func<Feiticeiro>>();
            character.Add(1,() => new FeiticeiroDeFogo(100, 50));
            character.Add(2,() =>new FeiticeiroDeAgua(70, 150));
            Console.WriteLine("Escolha qual Feiticeiro você quer ser" +
                "\n 1 -> Feiticeiro de Fogo" +
                "\n 2 -> Feiticeiro de Agua");
            int.TryParse(Console.ReadLine(), out int opcao);
            character[opcao]().Atacar();
            Console.WriteLine(character[opcao]().MP);
            

        }
    }
}
