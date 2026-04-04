using System;

class CountDigits
{
    static void Main()
    {
        int num, count = 0;

        Console.Write("Enter number: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            count++;
            num /= 10;
        }

        Console.WriteLine("Total digits = " + count);
    }
}
