using System;

class Program {
    static void Main() {
        int[] arr = new int[5];

        Console.WriteLine("Enter 5 elements:");
        for(int i = 0; i < 5; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Array elements:");
        foreach(int num in arr)
            Console.Write(num + " ");
    }
}
