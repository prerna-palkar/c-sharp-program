using System;

[Obsolete("Use NewMethod instead")]
class Demo
{
    public void OldMethod()
    {
        Console.WriteLine("Old Method");
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.OldMethod();
    }
}
