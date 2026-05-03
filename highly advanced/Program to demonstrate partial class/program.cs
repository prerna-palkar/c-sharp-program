using System;

partial class Demo
{
    public void Method1()
    {
        Console.WriteLine("Method 1");
    }
}

partial class Demo
{
    public void Method2()
    {
        Console.WriteLine("Method 2");
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.Method1();
        d.Method2();
    }
}
