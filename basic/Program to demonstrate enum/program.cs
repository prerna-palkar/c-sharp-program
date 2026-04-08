using System;

enum Days { Monday, Tuesday, Wednesday }

class Program {
    static void Main() {
        Days d = Days.Wednesday;
        Console.WriteLine(d);
        Console.WriteLine((int)d); // index value
    }
}
