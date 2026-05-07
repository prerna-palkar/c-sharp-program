using Azure.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddAzureKeyVault(
    new Uri("https://mykeyvault.vault.azure.net/"),
    new DefaultAzureCredential());

var app = builder.Build();

app.MapGet("/", (IConfiguration config) =>
{
    string secret =
        config["DatabasePassword"]!;

    return $"Secret Loaded: {secret}";
});

app.Run();
