using System;

class Program {
    static void Main() {
        int[] arr = {1, 2, 3, 4, 5};
        int sum = 0;

        foreach(int num in arr)
            sum += num;

        double avg = (double)sum / arr.Length;

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + avg);
    }
}
