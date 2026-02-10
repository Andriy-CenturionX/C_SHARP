using System;
using System.Linq;

static class PagingExtensions
{
    public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int page, int size)
    {
        return source.Skip((page - 1) * size).Take(size);
    }
}

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 30);

        var page2 = numbers.Page(2, 10);

        foreach (var n in page2)
            Console.WriteLine(n);
    }
}
