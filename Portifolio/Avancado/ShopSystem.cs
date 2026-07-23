using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Portifolio.Avancado
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }

        public Product(int id, string name, double price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
            
        }

    }
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public double ProductPrice { get; set; }

        public int Quantity { get; set; }

        public CartItem(int productId, string productName, double productPrice, int quantity)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            Quantity = quantity;

        }
    }
        
    
    internal class ShopSystem
    {

        List<Product> products = new List<Product>
        {
            new Product(1, "Bread", 3.5, 10),
            new Product(2, "Eggs", 4, 10),
            new Product(3, "Bread", 3.5, 10 ),
            new Product(4, "Bread", 3.5, 10),
        };
        List<CartItem> cart = new List<CartItem>();
        public void Buy(int itemCode, int amount)
        {
            Product item = products.FirstOrDefault(p => p.Id == itemCode);

            if (item == null)
            {
                Console.WriteLine("Product unavilable");
                return;
            }
            if(item.Stock < amount)
            {
                Console.WriteLine($"There is {item.Stock} avilable");
                return;
            }
            cart.Add(new CartItem(item.Id, item.Name, item.Price, amount));
            item.Stock -= amount;

        }
        public static void Executar()
        {

        }
    }
}
