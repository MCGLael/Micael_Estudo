using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static CursoCS.OO.Comida;

namespace CursoCS.OO
{
    public class Comida
    {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso;
        }
        public Comida() { }// construtor vazio para poder criar objetos sem passar o peso como parametro



        public class Arroz : Comida
        {

        }
        public class Feijao : Comida
        {

        }
        public class Carne : Comida
        {

        }

        public class Pessoa {

            public double Peso;
       /* public void Comer(Feijao feijao)
        {
            Peso += feijao.Peso;
        }
        public void Comer(Arroz arroz)
        {
            Peso += arroz.Peso;
        }
        public void Comer(Carne carne)
        {
            Peso += carne.Peso;
        }*/
        public void Comer(Comida comida)// O que esta acontecendo é que o metodo esta recebendo um tipo mais generico, ou seja, ele pode receber qualquer tipo de comida
                                        // e ai ele vai verificar qual tipo de comida é e somar o peso da comida ao peso da pessoa.
            {
            Peso += comida.Peso;
            }
        

        }
    }
        internal class Polimorfismo
        {
            public static void Executar()
            {
            Feijao ingrediente1 = new Feijao();
            ingrediente1.Peso = 0.3;
            Arroz ingrediente2 = new Arroz();
            ingrediente1.Peso = 0.25;
            Carne ingrediente3 = new Carne();
            ingrediente1.Peso = 0.50;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 100.0;
            Console.WriteLine($"Cliente Pesa :{cliente.Peso}");
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine("O Cliente agora pesa {0}", cliente.Peso);

        }
        }
    }

