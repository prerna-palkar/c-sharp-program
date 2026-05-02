using System;

class Student {
    public Student() {
        Console.WriteLine("Constructor called");
    }
}

class Program {
    static void Main() {
        Student s = new Student();
    }
}
