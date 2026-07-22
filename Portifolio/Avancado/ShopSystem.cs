using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Avancado
{
    public class product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public void Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

    }
        
    
    internal class ShopSystem
    {

        List<product> products = new List<product>
        {
            new product{Id = 1, Name = "Bread", Price = 3.5 },
            new product{Id = 2, Name = "Eggs", Price = 4 },
            new product{Id = 3, Name = "Bread", Price = 3.5 },
            new product{Id = 4, Name = "Bread", Price = 3.5 },
        };
        List<product> cart = new List<product>();
        public void Buy()
        {

        }
        public static void Executar()
        {

        }
    }
}
