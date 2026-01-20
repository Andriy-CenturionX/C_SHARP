using System;

class Program
{
    static void Main()
    {
        string input = "123a";

        if (int.TryParse(input, out int result))
        {
            Console.WriteLine($"Число: {result}");
        }
        else
        {
            Console.WriteLine("Некоректне число");
        }
    }
}