using System;
using System.Text.RegularExpressions;

class Demo {
    static void Main() {
        string password = "Abc@1234";

        bool valid = Regex.IsMatch(password,
            @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{6,}$");

        Console.WriteLine(valid ? "Strong Password" : "Weak Password");
    }
}
