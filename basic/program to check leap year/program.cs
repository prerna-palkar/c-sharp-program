using System;
class Program {
    static void Main() {
        int year = 2024;
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            Console.WriteLine("Leap Year");
        else
            Console.WriteLine("Not Leap Year");
    }
}
