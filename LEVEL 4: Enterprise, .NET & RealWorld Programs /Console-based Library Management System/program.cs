```csharp
using System;
using System.Collections.Generic;

class Book
{
    public int Id;
    public string Title;
    public bool Issued;
}

class Program
{
    static List<Book> books = new List<Book>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== Library Menu =====");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Issue Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Search Book");
            Console.WriteLine("6. Exit");

            Console.Write("Enter choice: ");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1: AddBook(); break;
                case 2: ViewBooks(); break;
                case 3: IssueBook(); break;
                case 4: ReturnBook(); break;
                case 5: SearchBook(); break;
                case 6: return;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }

    static void AddBook()
    {
        Book b = new Book();

        Console.Write("Enter Book ID: ");
        b.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Title: ");
        b.Title = Console.ReadLine();

        b.Issued = false;

        books.Add(b);
        Console.WriteLine("Book added successfully!");
    }

    static void ViewBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        foreach (var b in books)
        {
            Console.WriteLine($"ID: {b.Id}, Title: {b.Title}, Issued: {b.Issued}");
        }
    }

    static void IssueBook()
    {
        Console.Write("Enter Book ID to issue: ");
        int id = int.Parse(Console.ReadLine());

        var book = books.Find(x => x.Id == id);

        if (book == null)
        {
            Console.WriteLine("Book not found!");
        }
        else if (book.Issued)
        {
            Console.WriteLine("Book is already issued!");
        }
        else
        {
            book.Issued = true;
            Console.WriteLine("Book issued successfully!");
        }
    }

    static void ReturnBook()
    {
        Console.Write("Enter Book ID to return: ");
        int id = int.Parse(Console.ReadLine());

        var book = books.Find(x => x.Id == id);

        if (book == null)
        {
            Console.WriteLine("Book not found!");
        }
        else if (!book.Issued)
        {
            Console.WriteLine("Book was not issued!");
        }
        else
        {
            book.Issued = false;
            Console.WriteLine("Book returned successfully!");
        }
    }

    static void SearchBook()
    {
        Console.Write("Enter Book ID to search: ");
        int id = int.Parse(Console.ReadLine());

        var book = books.Find(x => x.Id == id);

        if (book == null)
        {
            Console.WriteLine("Book not found!");
        }
        else
        {
            Console.WriteLine($"Found → ID: {book.Id}, Title: {book.Title}, Issued: {book.Issued}");
        }
    }
}
```
