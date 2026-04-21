using System;

class NamedArgsDemo
{
    static void Show(string name, int age, string city)
    {
        Console.WriteLine($"{name}, {age}, {city}");
    }

    static void Main()
    {
        Show(city: "Pune", name: "Prerna", age: 20);
    }
}
