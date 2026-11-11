using MinimalASPWEB.Services;
using MinimalASPWEB.Models;
using MinimalASPWEB.ValidationProduct;
using Microsoft.EntityFrameworkCore;
using MinimalASPWEB.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<ProductService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddTransient<ValidationProduct>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        connectionString,
        ServerVersion.AutoDetect(connectionString)
    )
);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();



app.MapGet("/Hello", () => "Hello World!");

app.MapGet("/Products/{id}", (int id, ProductService products) =>
{
    var item = products.GetItemAsync(id);

    if (item == null)
    {
        return Results.NotFound("Not Found");
    }
    
    return Results.Ok(item); 
});

app.MapGet("/Products", (ProductService products) => products.GetAllAsync());

app.MapPost("/Products", async (ProductDto productdto, ProductService products, ValidationProduct Validator) =>
{
    if (!Validator.IsValid(productdto))
    {
        return Results.BadRequest();
    }
    var product = new Product
    {
        Name = productdto.Name,
        Price = productdto.Price,
        Stock = productdto.Stock
    };
    
var item = await products.AddItemAsync(product);
    if (item == null)
    {
        return Results.Conflict(new {mensage = "Name already existent"});
    }


    return Results.Created($"/Product/{item.Id}", item);
});

app.MapPut("/Products/{id}", async (int id, ProductDto updatedProduct, ProductService products, ValidationProduct Validator) =>
{
    if (!Validator.IsValid(updatedProduct))
    {
        return Results.BadRequest();
    }
    var product = new Product
    {
        Id = id,
        Name = updatedProduct.Name,
        Price = updatedProduct.Price,
        Stock = updatedProduct.Stock
    };
    var validation = await products.UpdateItemAsync(id, product);
    if (validation == null)
    {
        return Results.NotFound("Product Not Found");
    }
    return Results.NoContent();
});

app.MapDelete("/Products/{id}", async (int id, ProductService products) =>
{
    
    bool _item = await products.DeleteItemAsync(id);

    if (!_item)
    {
        return Results.NotFound("Product Not Found");
    }

    return Results.NoContent();
});
app.Run(); 
