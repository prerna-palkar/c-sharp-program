using Microsoft.Extensions.Hosting;

class Worker : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken ct)
    {
        while (!ct.IsCancellationRequested)
        {
            Console.WriteLine("Running...");
            await Task.Delay(2000);
        }
    }
}
