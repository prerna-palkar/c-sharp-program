using System;

class Demo<T> where T : class
{
    public void Print(T value)
    {
        Console.WriteLine(value);
    }
}

class Program
{
    static void Main()
    {
        Demo<string> d = new Demo<string>();
        d.Print("Constraint Example");
    }
}
