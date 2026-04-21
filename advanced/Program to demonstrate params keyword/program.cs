using System;

class ParamsDemo
{
    static int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (int n in numbers)
        {
            total += n;
        }
        return total;
    }

    static void Main()
    {
        Console.WriteLine(Sum(1, 2, 3, 4));
    }
}
