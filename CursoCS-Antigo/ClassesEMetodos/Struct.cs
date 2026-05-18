using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;

        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }
    internal class Struct
    {
        public static void Executar()
        {
            var cord = new Coordenada(5, 7);
            Console.WriteLine(cord.X);
            Console.WriteLine(cord.Y);

            cord.MoverNaDiagonal(10);
            Console.WriteLine(cord.X);
            Console.WriteLine(cord.Y);
        }
    }
}
