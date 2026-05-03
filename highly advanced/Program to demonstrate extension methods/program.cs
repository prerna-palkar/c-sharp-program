using System;

static class Ext
{
    public static int Square(this int x)
    {
        return x * x;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(5.Square());
    }
}
