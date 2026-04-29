using System;
using System.Text.RegularExpressions;

class Demo {
    static void Main() {
        string email = "user@gmail.com";

        bool isValid = Regex.IsMatch(email,
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        Console.WriteLine(isValid ? "Valid" : "Invalid");
    }
}
