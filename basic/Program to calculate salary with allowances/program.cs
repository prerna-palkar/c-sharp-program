using System;
class Program {
    static void Main() {
        double basic = 10000;
        double hra = basic * 0.2;
        double da = basic * 0.1;
        double total = basic + hra + da;

        Console.WriteLine("Total Salary: " + total);
    }
}
