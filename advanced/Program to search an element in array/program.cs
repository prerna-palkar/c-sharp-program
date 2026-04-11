using System;

class Program {
    static void Main() {
        int[] arr = {1, 2, 3, 4, 5};
        int key = 3;

        int index = Array.IndexOf(arr, key);

        if(index != -1)
            Console.WriteLine("Found at index " + index);
        else
            Console.WriteLine("Not Found");
    }
}
