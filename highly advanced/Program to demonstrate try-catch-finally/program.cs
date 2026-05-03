using System;

class Program
{
    static void Main()
    {
        try
        {
            int x = 10 / 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Always executed");
        }
    }
}
