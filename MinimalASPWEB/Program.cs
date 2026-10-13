using MinimalASPWEB.Services;
using MinimalASPWEB.Models;
using MinimalASPWEB.ValidationProduct;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ProductService>();
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

app.MapPost("/Products", (ProductDto product, ProductService products, ValidationProduct Validator) =>
{
    if (!Validator.IsValid(product))
    {
        return Results.BadRequest();
    }
var item = products.AddItem(product.Name, product.Price, product.Stock);
    if (item == null)
    {
        return Results.Conflict(new {mensage = "Name already existent"});
    }


    return Results.Created($"/Product/{item.Id}", item);
});

app.MapPut("/Products/{id}", (int id, ProductDto updatedProduct, ProductService products, ValidationProduct Validator) =>
{
    if (!Validator.IsValid(updatedProduct))
    {
        return Results.BadRequest();
    }
    var validation = products.UpdateItem(id, updatedProduct.Name, updatedProduct.Price, updatedProduct.Stock);
    if (validation == null)
    {
        return Results.NotFound("Product Not Found");
    }
    return Results.NoContent();
});

app.MapDelete("/Products/{id}", (int id, ProductService products) =>
{
    
    bool _item = products.DeleteItem(id);

    if (!_item)
    {
        return Results.NotFound("Product Not Found");
    }

    return Results.NoContent();
});
app.Run(); 
