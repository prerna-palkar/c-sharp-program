var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter("fixed", opt =>
    {
        opt.PermitLimit = 5;
        opt.Window = TimeSpan.FromSeconds(10);
    });
});

var app = builder.Build();

app.UseRateLimiter();

app.MapGet("/", () => "Hello")
   .RequireRateLimiting("fixed");

app.Run();
