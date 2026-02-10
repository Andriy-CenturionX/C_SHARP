using System;

static class DecimalExtensions
{
    public static decimal ToUAH(this decimal amount, decimal rate)
    {
        return amount * rate;
    }
}

class Program
{
    static void Main()
    {
        decimal price = 100.5m;
        Console.WriteLine($"UAH: {price.ToUAH(41.5m)}");
    }
}
