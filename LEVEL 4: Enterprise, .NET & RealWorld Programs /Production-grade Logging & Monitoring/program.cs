using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger =
    new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File(
        "logs/app-log.txt",
        rollingInterval:
        RollingInterval.Day)
    .CreateLogger();

builder.Host.UseSerilog();

var app = builder.Build();

app.MapGet("/", () =>
{
    Log.Information(
        "Home Endpoint Accessed");

    return "Logging Enabled";
});

app.MapGet("/error", () =>
{
    try
    {
        int x = 0;
        int result = 10 / x;

        return result;
    }
    catch (Exception ex)
    {
        Log.Error(
            ex,
            "Exception Occurred");

        return "Error Logged";
    }
});

app.Run();
