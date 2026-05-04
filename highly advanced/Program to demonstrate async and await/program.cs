using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await DoWork();
        Console.WriteLine("Finished");
    }

    static async Task DoWork()
    {
        await Task.Delay(1000);
        Console.WriteLine("Working...");
    }
}
