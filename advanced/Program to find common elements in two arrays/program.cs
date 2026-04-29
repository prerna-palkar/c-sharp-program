using System;
using System.Linq;

class Demo {
    static void Main() {
        int[] a = {1,2,3,4};
        int[] b = {3,4,5,6};

        var common = a.Intersect(b);

        foreach(var i in common)
            Console.WriteLine(i);
    }
}
