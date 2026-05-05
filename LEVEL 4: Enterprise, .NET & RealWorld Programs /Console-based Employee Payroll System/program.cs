```csharp id="7l2m3k"
using System;
using System.Collections.Generic;

class Employee
{
    public int Id;
    public string Name;
    public double BasicSalary;
}

class Program
{
    static List<Employee> employees = new List<Employee>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== Payroll Menu =====");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Calculate Salary");
            Console.WriteLine("4. Search Employee");
            Console.WriteLine("5. Delete Employee");
            Console.WriteLine("6. Exit");

            Console.Write("Enter choice: ");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1: AddEmployee(); break;
                case 2: ViewEmployees(); break;
                case 3: CalculateSalary(); break;
                case 4: SearchEmployee(); break;
                case 5: DeleteEmployee(); break;
                case 6: return;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }

    static void AddEmployee()
    {
        Employee e = new Employee();

        Console.Write("Enter ID: ");
        e.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        e.Name = Console.ReadLine();

        Console.Write("Enter Basic Salary: ");
        double salary = double.Parse(Console.ReadLine());

        if (salary <= 0)
        {
            Console.WriteLine("Invalid salary!");
            return;
        }

        e.BasicSalary = salary;
        employees.Add(e);

        Console.WriteLine("Employee added successfully!");
    }

    static void ViewEmployees()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees found.");
            return;
        }

        foreach (var e in employees)
        {
            Console.WriteLine($"ID: {e.Id}, Name: {e.Name}, Basic Salary: {e.BasicSalary}");
        }
    }

    static void CalculateSalary()
    {
        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());

        var emp = employees.Find(x => x.Id == id);

        if (emp == null)
        {
            Console.WriteLine("Employee not found!");
            return;
        }

        double hra = emp.BasicSalary * 0.20;
        double bonus = emp.BasicSalary * 0.10;
        double tax = emp.BasicSalary * 0.05;

        double netSalary = emp.BasicSalary + hra + bonus - tax;

        Console.WriteLine($"Salary Details for {emp.Name}:");
        Console.WriteLine($"Basic: {emp.BasicSalary}");
        Console.WriteLine($"HRA: {hra}");
        Console.WriteLine($"Bonus: {bonus}");
        Console.WriteLine($"Tax: {tax}");
        Console.WriteLine($"Net Salary: {netSalary}");
    }

    static void SearchEmployee()
    {
        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());

        var emp = employees.Find(x => x.Id == id);

        if (emp == null)
        {
            Console.WriteLine("Employee not found!");
        }
        else
        {
            Console.WriteLine($"Found → ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.BasicSalary}");
        }
    }

    static void DeleteEmployee()
    {
        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());

        employees.RemoveAll(x => x.Id == id);
        Console.WriteLine("Employee deleted!");
    }
}
```
