using System;

class Program
{
    static void Main()
    {
        Func<int, int> f = x => x * 2;
        Action<string> a = x => Console.WriteLine(x);
        Predicate<int> p = x => x > 5;

        Console.WriteLine(f(3));
        a("Hello");
        Console.WriteLine(p(10));
    }
}
