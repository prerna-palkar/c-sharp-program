using System;

class Program
{
    static void Main()
    {
        Type t = typeof(string);

        Console.WriteLine("Type Name: " + t.Name);

        foreach (var method in t.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
