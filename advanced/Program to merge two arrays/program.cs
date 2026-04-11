using System;

class Program {
    static void Main() {
        int[] a = {1, 2, 3};
        int[] b = {4, 5, 6};

        int[] c = new int[a.Length + b.Length];

        a.CopyTo(c, 0);
        b.CopyTo(c, a.Length);

        foreach(int num in c)
            Console.Write(num + " ");
    }
}
