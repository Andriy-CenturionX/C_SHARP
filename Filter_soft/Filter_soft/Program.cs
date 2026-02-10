using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 45000, Stock = 5 },
            new Product { Name = "Mouse", Category = "Electronics", Price = 800, Stock = 20 },
            new Product { Name = "Keyboard", Category = "Electronics", Price = 1500, Stock = 0 },
            new Product { Name = "Monitor", Category = "Electronics", Price = 12000, Stock = 4 }
        };

        var result = products
            .Where(p => p.Category == "Electronics" && p.Stock > 0)
            .OrderByDescending(p => p.Price);

        foreach (var p in result)
            Console.WriteLine($"{p.Name} - {p.Price}");
    }
}
