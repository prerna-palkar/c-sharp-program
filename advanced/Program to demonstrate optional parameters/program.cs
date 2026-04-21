using System;

class OptionalDemo
{
    static void Display(string name, int age = 18)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

    static void Main()
    {
        Display("Prerna");
        Display("Rahul", 25);
    }
}
