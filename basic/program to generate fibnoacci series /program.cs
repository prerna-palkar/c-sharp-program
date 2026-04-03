using System;

class Fibonacci
{
    static void Main()
    {
        int n, a = 0, b = 1, c;

        Console.Write("Enter number of terms: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");
        Console.Write(a + " " + b + " ");

        for (int i = 2; i < n; i++)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
}
