using System;
using System.Text.RegularExpressions;

class Demo {
    static void Main() {
        string text = "Order number is 4567";

        Match match = Regex.Match(text, @"\d+");
        Console.WriteLine("Found Number: " + match.Value);
    }
}
