using System;

class Program {
    static void Main() {
        int[] arr = {1, 2, 3, 4, 5};
        Array.Reverse(arr);

        foreach(int num in arr)
            Console.Write(num + " ");
    }
}
