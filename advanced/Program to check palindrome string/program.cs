using System;

class Program {
    static void Main() {
        string str = "madam";
        string rev = new string(str.Reverse().ToArray());

        if(str == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}
