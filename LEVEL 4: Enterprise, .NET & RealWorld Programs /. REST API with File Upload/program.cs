using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

List<Product> products = new()
{
    new Product(1, "Laptop", "Electronics"),
    new Product(2, "Phone", "Electronics"),
    new Product(3, "Shoes", "Fashion"),
    new Product(4, "Watch", "Fashion"),
    new Product(5, "Tablet", "Electronics")
};

app.MapGet("/products", (
    int page = 1,
    int pageSize = 2,
    string? category = null) =>
{
    var query = products.AsQueryable();

    if (!string.IsNullOrEmpty(category))
    {
        query = query.Where(p => p.Category == category);
    }

    var result = query
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToList();

    return Results.Ok(result);
});

app.Run();

record Product(int Id, string Name, string Category);
