using System;

static class Utility
{
    public static void Show()
    {
        Console.WriteLine("Static class method");
    }
}

class Program
{
    static void Main()
    {
        Utility.Show();
    }
}
