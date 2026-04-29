using System;

class Demo {
    static void Main() {
        int[] arr = {1,2,3,5};
        int n = 5;

        int expected = n*(n+1)/2;
        int actual = 0;

        foreach(int i in arr)
            actual += i;

        Console.WriteLine("Missing: " + (expected - actual));
    }
}
