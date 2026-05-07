var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TenantService>();

var app = builder.Build();

app.Use(async (context, next) =>
{
    var tenantService =
        context.RequestServices
        .GetRequiredService<TenantService>();

    string tenant =
        tenantService.GetTenant(context);

    Console.WriteLine($"Current Tenant: {tenant}");

    await next();
});

app.MapGet("/", () =>
{
    return "Multi-Tenant Application Running";
});

app.Run();

public class TenantService
{
    public string GetTenant(HttpContext context)
    {
        return context.Request.Headers["Tenant-ID"]!;
    }
}
