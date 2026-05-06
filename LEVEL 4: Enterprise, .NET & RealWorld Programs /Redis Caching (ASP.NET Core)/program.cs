using Microsoft.Extensions.Caching.Distributed;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost:6379";
});

var app = builder.Build();

app.MapGet("/cache", async (IDistributedCache cache) =>
{
    string key = "data";
    var value = await cache.GetStringAsync(key);

    if (value == null)
    {
        value = "Fresh Data " + DateTime.Now;
        await cache.SetStringAsync(key, value);
    }

    return value;
});

app.Run();
