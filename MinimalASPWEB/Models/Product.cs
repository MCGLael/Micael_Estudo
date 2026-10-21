namespace MinimalASPWEB.Models
{
    public class Product
    {
        
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public Product( int id, String name, decimal price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }
    }

    public class ProductDto
    {
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
