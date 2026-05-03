using System;

class Demo
{
    public const int x = 10;        // compile-time
    public readonly int y;          // runtime

    public Demo()
    {
        y = 20;
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        Console.WriteLine(d.y);
        Console.WriteLine(Demo.x);
    }
}
