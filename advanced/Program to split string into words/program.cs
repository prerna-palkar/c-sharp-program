using System;

class Demo {
    static void Main() {
        string str = "Welcome to C Sharp";
        string[] words = str.Split(' ');

        foreach(string w in words)
            Console.WriteLine(w);
    }
}
