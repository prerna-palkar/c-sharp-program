using System;
using System.Linq;

class Demo {
    static void Main() {
        string s1 = "listen";
        string s2 = "silent";

        bool result = String.Concat(s1.OrderBy(c => c)) ==
                      String.Concat(s2.OrderBy(c => c));

        Console.WriteLine(result ? "Anagram" : "Not Anagram");
    }
}
