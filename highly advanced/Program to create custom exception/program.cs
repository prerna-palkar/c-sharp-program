using System;

class MyException : Exception
{
    public MyException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        try
        {
            throw new MyException("Custom error occurred");
        }
        catch (MyException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
