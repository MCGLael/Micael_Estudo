using MinimalASPWEB.Models;
using MinimalASPWEB.ValidationProduct;
using System;


namespace MinimalASPWEB.Services

{
    public class ProductService
    {
        private List <Product> Shelf = new List<Product>() {
                new Product(1, "Apple", 3.49, 5),
                new Product(2, "Banana", 5.9, 5),
                new Product(3, "Strawberry", 1.99, 5)
        };

        public IEnumerable<Product> GetAll()
        {
            return Shelf; 
        }

        public Product GetItem(int id)
        {
            var item = Shelf.FirstOrDefault(p => p.Id == id);
            return item;
        }

        public Product? AddItem(String Name, Double Price, int Stock)
        {
            int lastId = (Shelf.Max(p => (int?)p.Id) ?? 0) + 1;
            bool verificationName = Shelf.Any(n => n.Name == Name);
            if (verificationName)
            {
                return null;
            }
            var item = new Product(lastId, Name, Price, Stock);
            Shelf.Add(item);
            return item;
        }

        
    }
     
    }
