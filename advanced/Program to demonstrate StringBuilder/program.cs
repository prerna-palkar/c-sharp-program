using System;
using System.Text;

class Program {
    static void Main() {
        StringBuilder sb = new StringBuilder("Hello");

        sb.Append(" World");
        sb.Replace("World", "C#");
        sb.Insert(5, " Beautiful");
        sb.Remove(5, 10);

        Console.WriteLine(sb);
    }
}
