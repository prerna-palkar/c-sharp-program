using System;

class Palindrome
{
    static void Main()
    {
        int num, original, reverse = 0, remainder;

        Console.Write("Enter number: ");
        num = Convert.ToInt32(Console.ReadLine());

        original = num;

        while (num != 0)
        {
            remainder = num % 10;
            reverse = reverse * 10 + remainder;
            num /= 10;
        }

        if (original == reverse)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}
