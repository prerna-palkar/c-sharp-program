using System;
using System.Linq;

class Demo {
    static void Main() {
        int[] arr = {1,2,2,3,3,4};

        var duplicates = arr.GroupBy(x => x)
                            .Where(g => g.Count() > 1)
                            .Select(g => g.Key);

        foreach(var d in duplicates)
            Console.WriteLine(d);
    }
}
