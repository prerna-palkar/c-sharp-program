using System;

class Demo {
    static void Main() {
        Demo obj = new Demo();
        obj = null;

        GC.Collect();
        Console.WriteLine("Garbage Collection Triggered");
    }
}
