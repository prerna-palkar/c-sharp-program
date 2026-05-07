using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.MicrosoftAccount;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddAuthentication(options =>
    {
        options.DefaultScheme =
            CookieAuthenticationDefaults.AuthenticationScheme;
    })
    .AddCookie()

    .AddGoogle(options =>
    {
        options.ClientId =
            "GOOGLE_CLIENT_ID";

        options.ClientSecret =
            "GOOGLE_CLIENT_SECRET";
    })

    .AddMicrosoftAccount(options =>
    {
        options.ClientId =
            "MICROSOFT_CLIENT_ID";

        options.ClientSecret =
            "MICROSOFT_CLIENT_SECRET";
    });

var app = builder.Build();

app.UseAuthentication();

app.UseAuthorization();

app.MapGet("/", () =>
{
    return "OAuth Login Enabled";
});

app.Run();
