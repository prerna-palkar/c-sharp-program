using System;

class CompoundInterest
{
    static void Main()
    {
        double principal, rate, time, CI, amount;

        Console.Write("Enter Principal: ");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate: ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time: ");
        time = Convert.ToDouble(Console.ReadLine());

        amount = principal * Math.Pow((1 + rate / 100), time);
        CI = amount - principal;

        Console.WriteLine("Compound Interest = " + CI);
    }
}
