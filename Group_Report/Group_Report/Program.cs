using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 45000 },
            new Product { Name = "Mouse", Category = "Electronics", Price = 800 },
            new Product { Name = "Desk", Category = "Furniture", Price = 7000 }
        };

        var report = products
            .GroupBy(p => p.Category)
            .Select(g => new
            {
                Category = g.Key,
                Count = g.Count(),
                AveragePrice = g.Average(p => p.Price)
            });

        foreach (var r in report)
            Console.WriteLine($"{r.Category}: {r.Count}, avg = {r.AveragePrice}");
    }
}