using System;
using System.Threading;

class Program
{
    static void Work()
    {
        Console.WriteLine("Thread running");
    }

    static void Main()
    {
        Thread t = new Thread(Work);
        t.Start();

        Console.WriteLine("Main thread");
    }
}
