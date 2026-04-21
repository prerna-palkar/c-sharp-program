using System;

class OutRefDemo
{
    static void UsingOut(out int x)
    {
        x = 10; // must assign
    }

    static void UsingRef(ref int y)
    {
        y += 5;
    }

    static void Main()
    {
        int a;
        UsingOut(out a);
        Console.WriteLine("Out: " + a);

        int b = 10;
        UsingRef(ref b);
        Console.WriteLine("Ref: " + b);
    }
}
