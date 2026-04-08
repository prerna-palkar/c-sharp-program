using System;
class Program {
    static void Main() {
        int num = 10;
        string binary = "";

        while (num > 0) {
            binary = (num % 2) + binary;
            num /= 2;
        }

        Console.WriteLine("Binary: " + binary);
    }
}
