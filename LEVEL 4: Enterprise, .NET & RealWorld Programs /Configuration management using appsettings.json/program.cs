{
  "AppName": "MyApp"
}
var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json");
var config = builder.Build();

Console.WriteLine(config["AppName"]);
