using System;

class Demo {
    static void Main() {
        int[] arr = {1,2,3,4};

        Span<int> span = arr;
        span[1] = 100;

        foreach(var i in arr)
            Console.WriteLine(i);
    }
}
