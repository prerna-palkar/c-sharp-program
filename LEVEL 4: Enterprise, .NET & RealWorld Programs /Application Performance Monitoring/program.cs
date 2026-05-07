using Microsoft.ApplicationInsights.Extensibility;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationInsightsTelemetry(
    options =>
    {
        options.ConnectionString =
            builder.Configuration["ApplicationInsights:ConnectionString"];
    });

var app = builder.Build();

app.MapGet("/", () =>
{
    return "Application Monitoring Enabled";
});

app.Run();
