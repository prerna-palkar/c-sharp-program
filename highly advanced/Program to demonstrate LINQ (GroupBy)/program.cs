using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "A", "B", "AA" };

        var group = names.GroupBy(x => x.Length);

        foreach (var g in group)
            Console.WriteLine(g.Key);
    }
}
