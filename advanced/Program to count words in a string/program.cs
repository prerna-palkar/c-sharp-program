using System;

class Program {
    static void Main() {
        string str = "Hello world from CSharp";
        int words = str.Split(' ').Length;

        Console.WriteLine("Words: " + words);
    }
}
