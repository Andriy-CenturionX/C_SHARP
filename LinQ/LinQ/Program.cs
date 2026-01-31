using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "Abama", "Trump", "Biden" };

        var upper = names.Select(name => name.ToUpper());
        var withLength = names.Select(name => $"{name} ({name.Length})");

        Console.WriteLine(string.Join(", ", upper));
        Console.WriteLine(string.Join(", ", withLength));
    }
}
