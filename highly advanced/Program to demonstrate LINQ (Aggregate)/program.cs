using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = { 1, 2, 3 };

        int sum = nums.Aggregate((a, b) => a + b);
        Console.WriteLine(sum);
    }
}
