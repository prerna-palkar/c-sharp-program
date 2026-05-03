using System;

class Base
{
    public virtual void Show()
    {
        Console.WriteLine("Base class");
    }
}

class Derived : Base
{
    public override void Show()
    {
        Console.WriteLine("Derived class");
    }
}

class Program
{
    static void Main()
    {
        Base obj = new Derived();
        obj.Show();
    }
}
