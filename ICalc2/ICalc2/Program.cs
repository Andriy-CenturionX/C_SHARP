using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 2, 3, 4, 4, 5 };
        ArrayContainer arr = new ArrayContainer(numbers);

        Console.WriteLine("Унікальних: " + arr.CountDistinct());
        Console.WriteLine("Кількість 2: " + arr.EqualToValue(2));
    }
}