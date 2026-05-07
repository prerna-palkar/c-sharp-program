var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        context.Response.StatusCode = 500;

        context.Response.ContentType =
            "application/json";

        await context.Response.WriteAsJsonAsync(
            new
            {
                StatusCode = 500,
                Message =
                    "Internal Server Error"
            });
    });
});

app.MapGet("/", () =>
{
    return "Application Running";
});

app.MapGet("/error", () =>
{
    throw new Exception(
        "Something Went Wrong");
});

app.Run();
