using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{
    public class Moto
    {

        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada)//Construtor para inicializar os atributos
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        public Moto() { }


        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(String marca)
        {
            Marca = marca;
        }
        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(String modelo)
        {
            Modelo = modelo;
        }
        public int GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(int cilindrada)
        {
            Cilindrada = Math.Abs(cilindrada);
        }
        internal class GettersESetters
        {
            public static void Executar()
            {
                var moto1 = new Moto("Honda", "Ninja ZK-6B", 700);

                Console.WriteLine(moto1.GetMarca());
                Console.WriteLine(moto1.GetModelo());
                Console.WriteLine(moto1.GetCilindrada());

                var moto2 = new Moto();
                moto2.SetMarca("Hyunday");
                moto2.SetModelo("CG Titan");
                moto2.SetCilindrada(-500);
                Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
            }
        }
    }
}
