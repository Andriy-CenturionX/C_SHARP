using System;

static class StringExtensions
{
    public static int WordCount(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return 0;

        return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}

class Program
{
    static void Main()
    {
        string text = "Bla Bla Bla ble ble ble blu blu blu, lingan guli guli Vatsa linga gu linga gu";
        Console.WriteLine($"Word count: {text.WordCount()}");
    }
}