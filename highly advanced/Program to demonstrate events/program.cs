using System;

class Program
{
    public delegate void Notify();
    public event Notify OnNotify;

    static void Main()
    {
        Program p = new Program();
        p.OnNotify += () => Console.WriteLine("Event triggered");
        p.OnNotify?.Invoke();
    }
}
