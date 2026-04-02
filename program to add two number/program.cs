using System;

class AddNumbers
{
    static void Main()
    {
        // Taking input from user
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Adding numbers
        int sum = num1 + num2;

        // Display result
        Console.WriteLine("Sum = " + sum);

        Console.ReadLine(); // Pause screen
    }
}
