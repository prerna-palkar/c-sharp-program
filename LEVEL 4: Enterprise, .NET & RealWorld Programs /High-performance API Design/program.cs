using Microsoft.Extensions.Caching.Memory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMemoryCache();

var app = builder.Build();

app.MapGet("/products",
    async (IMemoryCache cache) =>
{
    string cacheKey = "products";

    if (!cache.TryGetValue(
        cacheKey,
        out List<string>? products))
    {
        await Task.Delay(2000);

        products = new List<string>
        {
            "Laptop",
            "Phone",
            "Tablet"
        };

        var cacheOptions =
            new MemoryCacheEntryOptions()
            .SetAbsoluteExpiration(
                TimeSpan.FromMinutes(5));

        cache.Set(
            cacheKey,
            products,
            cacheOptions);
    }

    return Results.Ok(products);
});

app.Run();
