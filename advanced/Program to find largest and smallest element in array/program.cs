using System;

class Program {
    static void Main() {
        int[] arr = {5, 2, 9, 1, 7};

        int max = arr[0], min = arr[0];

        foreach(int num in arr) {
            if(num > max) max = num;
            if(num < min) min = num;
        }

        Console.WriteLine("Largest = " + max);
        Console.WriteLine("Smallest = " + min);
    }
}
