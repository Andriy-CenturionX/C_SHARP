using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Price}$";
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Mouse", Price = 20 },
            new Product { Name = "Keyboard", Price = 50 },
            new Product { Name = "Monitor", Price = 200 }
        };

        
        products.Sort((a, b) => a.Price.CompareTo(b.Price));
        Console.WriteLine("By price:");
        products.ForEach(p => Console.WriteLine(p));

        
        products.Sort((a, b) => a.Name.CompareTo(b.Name));
        Console.WriteLine("\nBy name:");
        products.ForEach(p => Console.WriteLine(p));
    }
}