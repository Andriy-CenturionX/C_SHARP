using System;
using System.Collections.Generic;

abstract class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    protected Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract double CalculateDiscount();
}

class Electronics : Product
{
    public Electronics(string name, double price) : base(name, price) { }
    public override double CalculateDiscount() => Price * 0.10;
}

class Furniture : Product
{
    public Furniture(string name, double price) : base(name, price) { }
    public override double CalculateDiscount() => Price * 0.20;
}

class Program
{
    static void Main()
    {
        List<Product> products = new()
        {
            new Electronics("Ноутбук", 39999),
            new Furniture("Стіл", 4000)
        };

        foreach (var p in products)
            Console.WriteLine($"{p.Name}: знижка {p.CalculateDiscount()}");

        Console.ReadKey();
    }
}
