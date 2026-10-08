using MinimalASPWEB.Services;
using MinimalASPWEB.Models;
using MinimalASPWEB.ValidationProduct;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ProductService>();
builder.Services.AddTransient<ValidationProduct>();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();



app.MapGet("/Hello", () => "Hello World!");

app.MapGet("/Products/{id}", (int id, ProductService products) =>
{
    var item = products.GetItem(id);

    if (item == null)
    {
        return Results.NotFound("Not Found");
    }
    
    return Results.Ok(item); 
});

app.MapGet("/Products", (ProductService products) => products.GetAll());

app.MapPost("/Products", (ProductDto Productdto, ValidationProduct Validator) =>
{
    int ultimoId = shelf.LastOrDefault()?.Id ?? 0;

    if (!Validator.IsValid(Productdto))
    {
        return Results.BadRequest();
    }
   
    Product newProduct = new Product(ultimoId + 1, Productdto.Name, Productdto.Price, Productdto.Stock);

    shelf.Add(newProduct);

    return Results.Created($"/Products/{newProduct.Id}", newProduct);
});

app.MapPut("/Products/{id}", (int id, ProductDto updatedProduct, ValidationProduct Validator) =>
{
    var verifyProduct = shelf.FirstOrDefault(p => p.Id == id);
    
    
    if (verifyProduct == null)
    {
        return Results.NotFound("Product Not Found");
    }
    if (!Validator.IsValid(updatedProduct))
    {
        return Results.BadRequest();
    }

    
    
    verifyProduct.Name = updatedProduct.Name;
    verifyProduct.Price = updatedProduct.Price;
    verifyProduct.Stock = updatedProduct.Stock;
    return Results.NoContent();
});
app.MapDelete("/Products/{id}", (int id) =>
{
    var verifyProduct = shelf.FirstOrDefault(p => p.Id == id);

    if (verifyProduct == null)
    {
        return Results.NotFound("Product Not Found");
    }
    
    shelf.Remove(verifyProduct);
    

    return Results.NoContent();
});
app.Run(); 
