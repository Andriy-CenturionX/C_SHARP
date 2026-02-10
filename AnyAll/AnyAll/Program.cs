using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}

class Program
{
    static void Main()
    {
        var cart = new List<Product>
        {
            new Product { Name = "Laptop", Price = 45000, Stock = 5 },
            new Product { Name = "Mouse", Price = 800, Stock = 10 }
        };

        bool allInStock = cart.All(p => p.Stock > 0);
        bool hasExpensive = cart.Any(p => p.Price > 10_000);

        Console.WriteLine($"В наявності: {allInStock}");
        Console.WriteLine($"Є дорогий товар: {hasExpensive}");
    }
}
