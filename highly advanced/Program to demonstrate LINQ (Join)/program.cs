using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var a = new[] { new { Id = 1 } };
        var b = new[] { new { Id = 1, Name = "X" } };

        var join = a.Join(b, x => x.Id, y => y.Id, (x, y) => y.Name);

        foreach (var i in join)
            Console.WriteLine(i);
    }
}
