using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;
        public string Nome
        {
            get
            {
                return "Opcional:" + nome;
            }
            set
            {
                nome = value;
            }

        }
        public double Preco { get; set; }

        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco);//Expressão lambda

        }

        public CarroOpcional() { }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        internal class Props
        {
            public static void Executar()
            {
                var carro1 = new CarroOpcional("Adesivo", 50.99);
                Console.WriteLine(carro1.PrecoComDesconto);

                var carro2 = new CarroOpcional();

                carro2.Nome = "Direção Eletrica";
                carro2.Preco = 5000.99;
                Console.WriteLine(carro2.Nome + " " + carro2.Preco);


            }
        }
    }
}
