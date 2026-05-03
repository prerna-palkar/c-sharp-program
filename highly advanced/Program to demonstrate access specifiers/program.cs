using System;

class Demo
{
    public int a = 10;
    private int b = 20;
    protected int c = 30;

    public void Show()
    {
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}

class Program : Demo
{
    static void Main()
    {
        Program obj = new Program();
        Console.WriteLine(obj.a);
        Console.WriteLine(obj.c);
        obj.Show();
    }
}
