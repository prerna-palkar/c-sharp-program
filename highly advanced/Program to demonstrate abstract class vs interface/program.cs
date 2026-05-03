using System;

abstract class Shape
{
    public abstract void Draw();
}

interface IColor
{
    void Fill();
}

class Circle : Shape, IColor
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }

    public void Fill()
    {
        Console.WriteLine("Filling Color");
    }
}

class Program
{
    static void Main()
    {
        Circle c = new Circle();
        c.Draw();
        c.Fill();
    }
}
