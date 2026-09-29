
using MinimalASPWEB.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


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
        <h1>Hello and Welcome to my Minimal API!</h1>
        <button id="btn">Click me!</button>

        <script>
            document.getElementById('btn').addEventListener('click', () => {
                alert('JavaScript is working!');
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

app.MapPost("/Products", (ProductDto Productdto) =>
{
    int ultimoId = Shelf.LastOrDefault()?.Id ?? 0;

    /*string name = Productdto.Name;
    double price = Productdto.Price;
    int stock = Productdto.Stock;
    int id = ultimoId+1;*/

    Product newProduct = new Product(ultimoId + 1, Productdto.Name, Productdto.Price, Productdto.Stock);

    Shelf.Add(newProduct);

    return Results.Created($"/Products/{newProduct.Id}", newProduct);
});

app.MapPut("/Products/{id}", (int id, ProductDto updatedProduct) =>
{
    var verifyProduct = Shelf.FirstOrDefault(p => p.Id == id);

    if (verifyProduct == null)
    {
        return Results.NotFound("Product Not Found");
    }
    
    verifyProduct.Name = updatedProduct.Name;
    verifyProduct.Price = updatedProduct.Price;
    verifyProduct.Stock = updatedProduct.Stock;
    return Results.NoContent();
});
app.MapDelete("/Products/{id}", (int id) =>
{
    var verifyProduct = Shelf.FirstOrDefault(p => p.Id == id);

    if (verifyProduct == null)
    {
        return Results.NotFound("Product Not Found");
    }
    
    Shelf.Remove(verifyProduct);
    

    return Results.NoContent();
});
app.Run(); 
;