using System;

class Demo {
    private int[] arr = new int[3];

    public int this[int index] {
        get { return arr[index]; }
        set { arr[index] = value; }
    }

    static void Main() {
        Demo obj = new Demo();
        obj[0] = 100;
        Console.WriteLine(obj[0]);
    }
}
