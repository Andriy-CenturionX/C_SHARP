using System;
using System.Collections.Generic;

class Program
{
    delegate bool FilterDelegate(int number);

    static List<int> Filter(List<int> list, FilterDelegate criteria)
    {
        List<int> result = new List<int>();

        foreach (int n in list)
        {
            if (criteria(n))
                result.Add(n);
        }

        return result;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 5, 10, 2, 25, 30, 4 };

        var evenNumbers = Filter(numbers, x => x % 2 == 0);
        var greaterThanTen = Filter(numbers, x => x > 10);

        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
        Console.WriteLine("> 10: " + string.Join(", ", greaterThanTen));
    }
}