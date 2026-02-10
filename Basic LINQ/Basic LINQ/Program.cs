using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 5, 8, 12, 3, 20 };

        var result = numbers.Where(n => n > 5 && n % 2 == 0);

        Console.WriteLine("Парні > 5:");
        foreach (var n in result)
            Console.WriteLine(n);
    }
}