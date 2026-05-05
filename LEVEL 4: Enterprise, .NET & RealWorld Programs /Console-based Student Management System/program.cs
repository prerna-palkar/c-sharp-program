```csharp
using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
    public int Marks;
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1.Add 2.View 3.Update 4.Delete 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Student s = new Student();
                    Console.Write("ID: "); s.Id = int.Parse(Console.ReadLine());
                    Console.Write("Name: "); s.Name = Console.ReadLine();
                    Console.Write("Marks: "); s.Marks = int.Parse(Console.ReadLine());
                    students.Add(s);
                    break;

                case 2:
                    foreach (var st in students)
                        Console.WriteLine($"{st.Id} {st.Name} {st.Marks}");
                    break;

                case 3:
                    Console.Write("Enter ID: ");
                    int uid = int.Parse(Console.ReadLine());
                    foreach (var st in students)
                        if (st.Id == uid)
                        {
                            Console.Write("New Name: "); st.Name = Console.ReadLine();
                            Console.Write("New Marks: "); st.Marks = int.Parse(Console.ReadLine());
                        }
                    break;

                case 4:
                    Console.Write("Enter ID: ");
                    int did = int.Parse(Console.ReadLine());
                    students.RemoveAll(x => x.Id == did);
                    break;

                case 5: return;
            }
        }
    }
}
```
