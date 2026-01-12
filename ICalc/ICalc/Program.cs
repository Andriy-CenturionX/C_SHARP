using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 3, 5, 7, 9 };
        ArrayContainer arr = new ArrayContainer(numbers);

        Console.WriteLine("Менших за 5: " + arr.Less(5));
        Console.WriteLine("Більших за 5: " + arr.Greater(5));
    }
}
