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

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public Product(int id, string name, decimal price, int stock)
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

        public decimal ProductPrice { get; set; }

        public int Quantity { get; set; }

        public CartItem(int productId, string productName, decimal productPrice, int quantity)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            Quantity = quantity;

        }
        
    }
    public class Coupons
    {
        
        public decimal Discount { get; set; }
        public Coupons(decimal discount)
        {
            
            Discount = discount;
        }
    }


    internal class ShopSystem
    {
        Dictionary<int, Coupons> coupon = new()
        {
            {123, new Coupons(10) },
            {122, new Coupons(30) },
            {133, new Coupons(50) },
        };

        static List<Product> products = new List<Product>
        {
            new Product(1, "Bread", 3.5m, 10),
            new Product(2, "Eggs", 4, 10),
            new Product(3, "Bread", 3.5m, 10 ),
            new Product(4, "Bread", 3.5m, 10),
        };
        List<CartItem> cart = new List<CartItem>();

        private Coupons? appliedCoupon;

        public static void ShowProducts()
        {
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} -- Price: {item.Price} -- Stock: {item.Stock}");
            }
        }
        public void Buy(int itemCode, int amount)
        {
            Product item = products.FirstOrDefault(p => p.Id == itemCode);
            CartItem Cartitem = cart.FirstOrDefault(c => c.ProductId == itemCode);
            

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
            if (Cartitem != null)
            {
                Cartitem.Quantity += amount;
                item.Stock -= amount;
                return;
            }

            cart.Add(new CartItem(item.Id, item.Name, item.Price, amount));
            item.Stock -= amount;

        }
        public decimal Total()
        { 
            return cart.Sum(t => t.ProductPrice * t.Quantity); ;
        }
        public void Discount(int code)
        {
            if(coupon.TryGetValue(code, out Coupons foundCoupon))
            {
                appliedCoupon = foundCoupon;
                Console.WriteLine($"You got {appliedCoupon.Discount}% OFF");
            }

        }
        public decimal Chekout()
        {
            decimal total = Total();
            if (appliedCoupon != null)
            {
                total -= total * appliedCoupon.Discount / 100;

            }
            return total;
        }
        public void choice(int option)
        {

        }
        public static void Executar()
        {
            Console.WriteLine("Welcome to Your Shop!");

            int i = 0;
            while(i == 0)
            {
                ShowProducts();
            }

        }
    }
}
