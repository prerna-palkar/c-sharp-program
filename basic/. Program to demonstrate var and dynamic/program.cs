using System;
class Program {
    static void Main() {
        var a = 10;        // compile-time type (int)
        dynamic b = 20;    // runtime type

        b = "Hello";       // allowed in dynamic

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
