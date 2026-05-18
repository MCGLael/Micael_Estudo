using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.ClassesEMetodos
{
   class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro()
        {

        }
    }

    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Modelo = "Corola";
            carro1.Fabricante = "Mytsubishi";
            carro1.Ano = 1475;
            Console.WriteLine($"O Modelo do carro é {carro1.Modelo} O fabricante é {carro1.Fabricante} e o ano fabricado foi de {carro1.Ano}");

            var carro2 = new Carro("Fusca", "Hyunday", 1500);
            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");

            var carro3 = new Carro()
            {
                Modelo = "Celta",
                Fabricante = "Casimiro",
                Ano = 2020

            };
            Console.WriteLine($"{carro3.Modelo} {carro3.Fabricante} {carro3.Ano}");

        }
    }
}
