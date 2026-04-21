using System;

class StaticDemo
{
    public static void Greet()
    {
        Console.WriteLine("Hello from static method!");
    }

    static void Main()
    {
        StaticDemo.Greet();
    }
}
