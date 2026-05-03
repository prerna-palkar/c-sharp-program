using System;

sealed class A
{
    public void Show()
    {
        Console.WriteLine("Sealed class");
    }
}

// class B : A {}  ❌ Not allowed

class Program
{
    static void Main()
    {
        A obj = new A();
        obj.Show();
    }
}
