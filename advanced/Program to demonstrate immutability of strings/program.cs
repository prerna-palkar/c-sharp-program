using System;

class Demo {
    static void Main() {
        string s = "Hello";
        string newStr = s.Replace("H", "Y");

        Console.WriteLine(s);      // Hello
        Console.WriteLine(newStr); // Yello
    }
}
