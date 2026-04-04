using System;

class PrimeRange
{
    static void Main()
    {
        int start, end;

        Console.Write("Enter start: ");
        start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter end: ");
        end = Convert.ToInt32(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            int count = 0;

            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    count++;
            }

            if (count == 2)
                Console.WriteLine(i);
        }
    }
}
