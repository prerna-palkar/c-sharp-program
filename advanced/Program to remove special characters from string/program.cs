using System;
using System.Text.RegularExpressions;

class Demo {
    static void Main() {
        string str = "Hello@#123!";
        string clean = Regex.Replace(str, "[^a-zA-Z0-9]", "");
        Console.WriteLine(clean);
    }
}
