using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<MyService>();

var provider = services.BuildServiceProvider();
provider.GetService<MyService>().Run();

class MyService { public void Run() => Console.WriteLine("DI works"); }
