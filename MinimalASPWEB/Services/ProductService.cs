using MinimalASPWEB.Models;
using MinimalASPWEB.ValidationProduct;
using System;


namespace MinimalASPWEB.Services

{
    public class ProductService
    {
        private List <Product> Shelf = new List<Product>() {
                new Product(1, "Apple", 3.49m, 5),
                new Product(2, "Banana", 5.9m, 5),
                new Product(3, "Strawberry", 1.99m, 5)
        };

        public IEnumerable<Product> GetAll()
        {
            return Shelf; 
        }

        public Product? GetItem(int id)
        {
            var item = Shelf.FirstOrDefault(p => p.Id == id);
            return item;
        }

        public Product? AddItem(string Name, decimal Price, int Stock)
        {
            int lastId = (Shelf.Max(p => (int?)p.Id) ?? 0) + 1;
            bool verificationName = Shelf.Any(n => n.Name == Name);
            if (verificationName == false)
            {
                return null;
            }
            var item = new Product(lastId, Name, Price, Stock);
            Shelf.Add(item);
            return item;
        }
        public Product? UpdateItem(int Id, string Name, decimal Price, int Stock)
        {
            var updateItem = Shelf.FirstOrDefault(i => i.Id == Id);
            if (updateItem == null)
            {
                return null;
            }
            updateItem.Name = Name;
            updateItem.Price = Price;
            updateItem.Stock = Stock;
            
            
            return updateItem;
        }

        public bool DeleteItem(int Id)
        {
            var item = Shelf.FirstOrDefault(i => i.Id == Id);
            if (item == null)
            {
                return false;
            }
            Shelf.Remove(item);

            return true;
        }

        
    }
     
    }
