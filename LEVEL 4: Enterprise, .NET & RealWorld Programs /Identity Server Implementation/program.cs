using Duende.IdentityServer.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddIdentityServer()
    .AddInMemoryClients(new List<Client>
    {
        new Client
        {
            ClientId = "client_app",

            AllowedGrantTypes =
                GrantTypes.ClientCredentials,

            ClientSecrets =
            {
                new Secret("secret123".Sha256())
            },

            AllowedScopes =
            {
                "api1"
            }
        }
    })
    .AddInMemoryApiScopes(new List<ApiScope>
    {
        new ApiScope("api1", "My API")
    })
    .AddDeveloperSigningCredential();

var app = builder.Build();

app.UseIdentityServer();

app.Run();
