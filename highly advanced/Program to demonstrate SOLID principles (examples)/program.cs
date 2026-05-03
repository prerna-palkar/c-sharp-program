using System;

class Invoice
{
    public void Calculate()
    {
        Console.WriteLine("Calculating invoice");
    }
}

class InvoicePrinter
{
    public void Print()
    {
        Console.WriteLine("Printing invoice");
    }
}

class Program
{
    static void Main()
    {
        Invoice i = new Invoice();
        i.Calculate();

        InvoicePrinter p = new InvoicePrinter();
        p.Print();
    }
}
