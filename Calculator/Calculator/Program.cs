using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        double a = 10;
        double b = 5;

        Console.WriteLine($"Add: {calc.Add(a, b)}");
        Console.WriteLine($"Subtract: {calc.Subtract(a, b)}");
        Console.WriteLine($"Multiply: {calc.Multiply(a, b)}");

        try
        {
            Console.WriteLine($"Divide: {calc.Divide(a, b)}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}