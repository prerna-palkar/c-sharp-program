using System;

class Demo<T>
{
    public T Value;
}

class Program
{
    static void Main()
    {
        Demo<int> d = new Demo<int>();
        d.Value = 10;
        Console.WriteLine(d.Value);
    }
}
