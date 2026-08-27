var builder = WebApplication.CreateBuilder(args);
/*builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
*/
var app = builder.Build();

/*app.UseSwagger();
app.UseSwaggerUI();
*/

List<Product> Shelf = new List<Product>()
{
    new Product(1, "Apple", 3.49, 5),
    new Product(2, "Banana", 5.9, 5),
    new Product(3, "Strawberry", 1.99, 5)

};
app.MapGet("/Hello", () => "Hello World!");

app.MapGet("/Shelf/{id}", (int id) =>
{

    
        var item = Shelf.FirstOrDefault(x => x.Id == id);
    if (item == null)
    {
        return Results.NotFound("Not Found");
    }
    //var item = Shelf.Find(p => p.id == "Apple");
    return Results.Ok(item); //$"Name: {item?.Name}\nPrice: {item?.Price}\nStock: {item?.Stock}";
    
});

app.Run();

public class Product
{
    public int Id { get; set; } 
    public string Name { get; set; }

    public double Price { get; set; }

    public int Stock { get; set; }

    public Product(int id, String name, double price, int stock)
    {
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
    }
}

