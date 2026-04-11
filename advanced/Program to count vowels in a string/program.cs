using System;

class Program {
    static void Main() {
        string str = "hello world";
        int count = 0;

        foreach(char ch in str.ToLower())
            if("aeiou".Contains(ch))
                count++;

        Console.WriteLine("Vowels: " + count);
    }
}
