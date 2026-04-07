using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        int[] arr = {1, 2, 2, 3, 4, 4, 5};
        HashSet<int> unique = new HashSet<int>(arr);

        foreach (int num in unique)
            Console.Write(num + " ");
    }
}
