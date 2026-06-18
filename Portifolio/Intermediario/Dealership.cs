using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Intermediario
{
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
    }
    internal class Dealership
    {
        Dictionary<int , (string Model, string Brand, double price)> cars = new()
        {
            {1, ("4X4", "Mistubishi", 50000.50) },
            {2, ("Sedan", "Honda", 30000.00) },
            {3, ("Hatch", "Volkswagen", 20000.00) },
            {4, ("SUV", "Volkswagen", 20000.00) }
        };
        public static void Executar()
        {

        }
    }
}
