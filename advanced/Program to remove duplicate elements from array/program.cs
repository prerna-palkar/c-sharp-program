using System;
using System.Linq;

class Program {
    static void Main() {
        int[] arr = {1, 2, 2, 3, 4, 4};

        var unique = arr.Distinct();

        foreach(int num in unique)
            Console.Write(num + " ");
    }
}
