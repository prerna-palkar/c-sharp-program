using System;

class Fibonacci
{
    static int Fib(int n)
    {
        if (n <= 1) return n;
        return Fib(n - 1) + Fib(n - 2);
    }

    static void Main()
    {
        int n = 6;
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fib(i) + " ");
        }
    }
}
