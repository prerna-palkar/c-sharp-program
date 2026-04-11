using System;

class Program {
    static void Main() {
        int[] arr = {5, 3, 1, 4, 2};
        Array.Sort(arr);

        Console.WriteLine("Sorted array:");
        foreach(int num in arr)
            Console.Write(num + " ");
    }
}
