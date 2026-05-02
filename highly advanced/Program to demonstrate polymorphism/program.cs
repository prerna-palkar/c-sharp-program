using System;

class MathOp {
    public int Add(int a, int b) {
        return a + b;
    }
    public int Add(int a, int b, int c) {
        return a + b + c;
    }
}

class Program {
    static void Main() {
        MathOp m = new MathOp();
        Console.WriteLine(m.Add(2,3));
        Console.WriteLine(m.Add(2,3,4));
    }
}
