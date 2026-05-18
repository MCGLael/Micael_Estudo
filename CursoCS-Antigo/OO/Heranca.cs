using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CursoCS.OO;

namespace CursoCS.OO
{
    internal class Heranca
    {
        
        public class Carro
        {
            protected readonly int VelocidadeMaxima;
            int VelocidadeAtual;

            public Carro() { }
            public Carro(int velocidadeMaxima)
            {
                VelocidadeMaxima = velocidadeMaxima;
            }

            protected int AlterarVelocidade(int delta)
            {
                int novaVelocidade = VelocidadeAtual + delta;

                if (novaVelocidade < 0)
                {
                    VelocidadeAtual = 0;
                }
                else if (novaVelocidade > VelocidadeMaxima)
                {
                    VelocidadeAtual = VelocidadeMaxima;
                }
                else
                {
                    VelocidadeAtual = novaVelocidade;
                }
                return VelocidadeAtual;
            }
            public virtual int Acelerar()
            {
                return AlterarVelocidade(5);
            }
            public new int Frear()
            {
                return AlterarVelocidade(-5);
            }
        }

        public class Uno : Carro
        {
            public Uno() : base(200){ }            

        }
        public class Ferrari : Carro
        {
            public Ferrari() : base(200){ }         
            
            public override int Acelerar()
            {
                return AlterarVelocidade(30);
            }
            public new int Frear()
            {
                return AlterarVelocidade(-30);
            }

        }
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            //Console.WriteLine(carro1.AlterarVelocidade()); Não é possível acessar o método AlterarVelocidade fora
            //da classe Carro, pois ele é protegido (protected) e só pode ser acessado dentro da classe Carro ou em classes derivadas (como Uno).,


            Console.WriteLine("Ferrari...");
            Uno carro2 = new Uno();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            //Console.WriteLine(carro1.AlterarVelocidade()); Não é possível acessar o método AlterarVelocidade fora
            //da classe Carro, pois ele é protegido (protected) e só pode ser acessado dentro da classe Carro ou em classes derivadas (como Uno).

            Console.WriteLine("Carro tipo Ferrari");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Carro tipo Uno");
            carro3 = new Uno();//Polimorfismo, o mesmo objeto pode se comportar de formas diferentes, dependendo do tipo que ele é referenciado.
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

        }
    }
}
