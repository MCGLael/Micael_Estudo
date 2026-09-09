

using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
/*builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
*/
var app = builder.Build();

/*app.UseSwagger();
app.UseSwaggerUI();
*/

app.MapGet("/", () =>
{
    var htmlContent = """
    <!DOCTYPE html>
    <html lang="pt-BR">
    <head>
        <meta charset="UTF-8">
        <title>Minimal API com JS</title>
    </head>
    <body>
        <h1>Olá da Minimal API!</h1>
        <button id="btn">Clique aqui</button>

        <script>
            document.getElementById('btn').addEventListener('click', () => {
                alert('JavaScript executado direto do Program.cs!');
            });
        </script>
    </body>
    </html>
    """;

    return Results.Content(htmlContent, "text/html", System.Text.Encoding.UTF8);
});

List<Product> Shelf = new List<Product>()
{
    new Product(1, "Apple", 3.49, 5),
    new Product(2, "Banana", 5.9, 5),
    new Product(3, "Strawberry", 1.99, 5)

};
app.MapGet("/Hello", () => "Hello World!");

app.MapGet("/Products/{id}", (int id) =>
{

    
        var item = Shelf.FirstOrDefault(x => x.Id == id);
    if (item == null)
    {
        return Results.NotFound("Not Found");
    }
    //var item = Shelf.Find(p => p.id == "Apple");
    return Results.Ok(item); //$"Name: {item?.Name}\nPrice: {item?.Price}\nStock: {item?.Stock}";
    
});
app.MapGet("/Products", () => Shelf);

app.MapPost("/Products", (Product newProduct) =>
{
    int ultimoId = Shelf.LastOrDefault()?.Id ?? 0;
    newProduct.Id = ultimoId+1;
    Shelf.Add(newProduct);
    return Results.Created($"/Products/{newProduct.Id}", newProduct);
});

app.MapPut("/Products/{id}", (int id, Product updatedProduct) =>
{
    var verifyProduct = Shelf.FirstOrDefault(p => p.Id == id);

    if (verifyProduct == null)
    {
        return Results.NotFound("Product Not Found");
    }
    
    verifyProduct.Name = updatedProduct.Name;
    verifyProduct.Price = updatedProduct.Price;
    verifyProduct.Stock = updatedProduct.Stock;

    /*Shelf.Remove(verifyProduct);
    Shelf.Add(updatedProduct);*/

    return Results.NoContent();
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

