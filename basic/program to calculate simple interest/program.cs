using System;

class SimpleInterest
{
    static void Main()
    {
        double principal, rate, time, SI;

        Console.Write("Enter Principal: ");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate: ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time: ");
        time = Convert.ToDouble(Console.ReadLine());

        SI = (principal * rate * time) / 100;

        Console.WriteLine("Simple Interest = " + SI);
    }
}
