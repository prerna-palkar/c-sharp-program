using System;

delegate void MyDelegate();

class Program
{
    static void Show()
    {
        Console.WriteLine("Hello");
    }

    static void Main()
    {
        MyDelegate d = Show;
        d();
    }
}
