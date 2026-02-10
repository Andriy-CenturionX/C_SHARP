using System;
using System.Collections.Generic;
using System.Linq;

static class EnumerableExtensions
{
    public static IEnumerable<T> SafeEmpty<T>(this IEnumerable<T> source)
    {
        return source ?? Enumerable.Empty<T>();
    }
}

class Program
{
    static void Main()
    {
        List<int> numbers = null;

        foreach (var n in numbers.SafeEmpty())
            Console.WriteLine(n);

        Console.WriteLine("Безпечний foreach закінчився нормально");
    }
}
