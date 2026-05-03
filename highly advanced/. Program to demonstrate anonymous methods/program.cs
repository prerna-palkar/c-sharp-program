using System;

delegate void MyDel();

class Program
{
    static void Main()
    {
        MyDel d = delegate () { Console.WriteLine("Anonymous"); };
        d();
    }
}
