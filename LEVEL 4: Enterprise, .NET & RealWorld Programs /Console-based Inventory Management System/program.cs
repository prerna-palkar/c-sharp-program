```csharp id="inv5x9"
using System;
using System.Collections.Generic;

class Product
{
    public int Id;
    public string Name;
    public int Quantity;
    public double Price;
}

class Program
{
    static List<Product> products = new List<Product>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== Inventory Menu =====");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Stock In");
            Console.WriteLine("4. Stock Out");
            Console.WriteLine("5. Search Product");
            Console.WriteLine("6. Delete Product");
            Console.WriteLine("7. Exit");

            Console.Write("Enter choice: ");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1: AddProduct(); break;
                case 2: ViewProducts(); break;
                case 3: StockIn(); break;
                case 4: StockOut(); break;
                case 5: SearchProduct(); break;
                case 6: DeleteProduct(); break;
                case 7: return;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }

    static void AddProduct()
    {
        Product p = new Product();

        Console.Write("Enter Product ID: ");
        p.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        p.Name = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        int qty = int.Parse(Console.ReadLine());

        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine());

        if (qty < 0 || price <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        p.Quantity = qty;
        p.Price = price;

        products.Add(p);
        Console.WriteLine("Product added successfully!");
    }

    static void ViewProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        foreach (var p in products)
        {
            Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Qty: {p.Quantity}, Price: {p.Price}");
        }
    }

    static void StockIn()
    {
        Console.Write("Enter Product ID: ");
        int id = int.Parse(Console.ReadLine());

        var prod = products.Find(x => x.Id == id);

        if (prod == null)
        {
            Console.WriteLine("Product not found!");
            return;
        }

        Console.Write("Enter quantity to add: ");
        int qty = int.Parse(Console.ReadLine());

        if (qty <= 0)
        {
            Console.WriteLine("Invalid quantity!");
            return;
        }

        prod.Quantity += qty;
        Console.WriteLine("Stock updated!");
    }

    static void StockOut()
    {
        Console.Write("Enter Product ID: ");
        int id = int.Parse(Console.ReadLine());

        var prod = products.Find(x => x.Id == id);

        if (prod == null)
        {
            Console.WriteLine("Product not found!");
            return;
        }

        Console.Write("Enter quantity to remove: ");
        int qty = int.Parse(Console.ReadLine());

        if (qty <= 0)
        {
            Console.WriteLine("Invalid quantity!");
        }
        else if (qty > prod.Quantity)
        {
            Console.WriteLine("Not enough stock!");
        }
        else
        {
            prod.Quantity -= qty;
            Console.WriteLine("Stock deducted!");
        }
    }

    static void SearchProduct()
    {
        Console.Write("Enter Product ID: ");
        int id = int.Parse(Console.ReadLine());

        var prod = products.Find(x => x.Id == id);

        if (prod == null)
        {
            Console.WriteLine("Product not found!");
        }
        else
        {
            Console.WriteLine($"Found → ID: {prod.Id}, Name: {prod.Name}, Qty: {prod.Quantity}, Price: {prod.Price}");
        }
    }

    static void DeleteProduct()
    {
        Console.Write("Enter Product ID: ");
        int id = int.Parse(Console.ReadLine());

        products.RemoveAll(x => x.Id == id);
        Console.WriteLine("Product deleted!");
    }
}
```
