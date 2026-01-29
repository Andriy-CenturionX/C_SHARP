public record Passport(string Series, string Number, string OwnerName);

class Program
{
    static void Main()
    {
        var passport = new Passport("AA", "123456", "Ivan Bimbenko");

        Console.WriteLine(passport.Series);
        Console.WriteLine(passport.Number);
        Console.WriteLine(passport.OwnerName);

        
    }
}