using System;

class Demo {
    static void Change(int x) {
        x = 50;
    }

    static void Main() {
        int a = 10;
        Change(a);

        Console.WriteLine(a); // 10
    }
}
