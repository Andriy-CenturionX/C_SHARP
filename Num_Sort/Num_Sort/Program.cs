using System;
using System.Linq;

class Program
{
    static int DigitSum(int number)
    {
        number = Math.Abs(number);
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static void Main()
    {
        int[] numbers = { 121, 75, 81 };

        var descending = numbers
            .OrderByDescending(n => DigitSum(n))
            .ToArray();

        var ascending = numbers
            .OrderBy(n => DigitSum(n))
            .ToArray();

        Console.WriteLine("За зростанням:");
        foreach (var n in descending)
            Console.WriteLine(n);

        Console.WriteLine("За спаданням:");
        foreach (var n in ascending)
            Console.WriteLine(n);
    }
}