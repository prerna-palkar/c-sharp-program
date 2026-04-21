using System;

class Factorial
{
    static int Fact(int n)
    {
        if (n == 0 || n == 1) return 1;
        return n * Fact(n - 1);
    }

    static void Main()
    {
        Console.WriteLine(Fact(5));
    }
}
