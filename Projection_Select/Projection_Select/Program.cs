using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 45000 },
            new Product { Name = "Mouse", Price = 800 }
        };

        var tags = products.Select(p => $"Товар: {p.Name} - {p.Price} грн");

        foreach (var t in tags)
            Console.WriteLine(t);
    }
}
