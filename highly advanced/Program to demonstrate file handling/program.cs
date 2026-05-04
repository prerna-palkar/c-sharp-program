using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.WriteAllText("file.txt", "Hello World");
        string data = File.ReadAllText("file.txt");
        Console.WriteLine(data);
    }
}
