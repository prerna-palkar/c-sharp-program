```csharp
using System;
using System.Collections.Generic;

class Account
{
    public int Id;
    public string Name;
    public double Balance;
}

class Program
{
    static List<Account> accounts = new List<Account>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== Banking Menu =====");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. View All Accounts");
            Console.WriteLine("6. Search Account");
            Console.WriteLine("7. Exit");

            Console.Write("Enter choice: ");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1: CreateAccount(); break;
                case 2: Deposit(); break;
                case 3: Withdraw(); break;
                case 4: CheckBalance(); break;
                case 5: ViewAccounts(); break;
                case 6: SearchAccount(); break;
                case 7: return;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }

    static void CreateAccount()
    {
        Account a = new Account();

        Console.Write("Enter Account ID: ");
        a.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        a.Name = Console.ReadLine();

        a.Balance = 0;

        accounts.Add(a);
        Console.WriteLine("Account created successfully!");
    }

    static void Deposit()
    {
        Console.Write("Enter Account ID: ");
        int id = int.Parse(Console.ReadLine());

        var acc = accounts.Find(x => x.Id == id);

        if (acc == null)
        {
            Console.WriteLine("Account not found!");
            return;
        }

        Console.Write("Enter amount: ");
        double amt = double.Parse(Console.ReadLine());

        if (amt <= 0)
        {
            Console.WriteLine("Invalid amount!");
            return;
        }

        acc.Balance += amt;
        Console.WriteLine("Deposit successful!");
    }

    static void Withdraw()
    {
        Console.Write("Enter Account ID: ");
        int id = int.Parse(Console.ReadLine());

        var acc = accounts.Find(x => x.Id == id);

        if (acc == null)
        {
            Console.WriteLine("Account not found!");
            return;
        }

        Console.Write("Enter amount: ");
        double amt = double.Parse(Console.ReadLine());

        if (amt <= 0)
        {
            Console.WriteLine("Invalid amount!");
        }
        else if (amt > acc.Balance)
        {
            Console.WriteLine("Insufficient balance!");
        }
        else
        {
            acc.Balance -= amt;
            Console.WriteLine("Withdrawal successful!");
        }
    }

    static void CheckBalance()
    {
        Console.Write("Enter Account ID: ");
        int id = int.Parse(Console.ReadLine());

        var acc = accounts.Find(x => x.Id == id);

        if (acc == null)
        {
            Console.WriteLine("Account not found!");
        }
        else
        {
            Console.WriteLine($"Balance: {acc.Balance}");
        }
    }

    static void ViewAccounts()
    {
        if (accounts.Count == 0)
        {
            Console.WriteLine("No accounts found.");
            return;
        }

        foreach (var acc in accounts)
        {
            Console.WriteLine($"ID: {acc.Id}, Name: {acc.Name}, Balance: {acc.Balance}");
        }
    }

    static void SearchAccount()
    {
        Console.Write("Enter Account ID: ");
        int id = int.Parse(Console.ReadLine());

        var acc = accounts.Find(x => x.Id == id);

        if (acc == null)
        {
            Console.WriteLine("Account not found!");
        }
        else
        {
            Console.WriteLine($"Found → ID: {acc.Id}, Name: {acc.Name}, Balance: {acc.Balance}");
        }
    }
}
```
