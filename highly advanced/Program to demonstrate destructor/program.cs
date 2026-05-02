using System;

class Demo {
    ~Demo() {
        Console.WriteLine("Destructor called");
    }
}

class Program {
    static void Main() {
        Demo d = new Demo();
    }
}
