using System;

interface IAnimal
{
    void Eat();
}

interface IMammal
{
    void Walk();
}

class Dog : IAnimal, IMammal
{
    public void Eat()
    {
        Console.WriteLine("Dog eats food");
    }

    public void Walk()
    {
        Console.WriteLine("Dog walks on 4 legs");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Eat();
        d.Walk();
    }
}
