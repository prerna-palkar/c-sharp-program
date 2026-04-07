using System;
class Program {
    static void Main() {
        string text = "I am learning C sharp programming";
        int count = text.Split(' ').Length;

        Console.WriteLine("Word Count: " + count);
    }
}
