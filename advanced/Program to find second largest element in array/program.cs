using System;

class Demo {
    static void Main() {
        int[] arr = {12, 35, 1, 10, 34, 1};
        int first = int.MinValue, second = int.MinValue;

        foreach(int num in arr) {
            if(num > first) {
                second = first;
                first = num;
            }
            else if(num > second && num != first) {
                second = num;
            }
        }

        Console.WriteLine("Second Largest: " + second);
    }
}
