using System;

class Demo {
    static void Show(int[] arr) {
        foreach(int i in arr)
            Console.Write(i + " ");
    }

    static void Main() {
        int[] a = {10, 20, 30};
        Show(a);
    }
}
