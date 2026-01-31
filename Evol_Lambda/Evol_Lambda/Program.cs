using System;

class Program
{
    delegate string Greeting(string name);

    static string SayHello(string name)
    {
        return "Hello, " + name;
    }

    static void Main()
    {
        Greeting greet;

        
        greet = SayHello;
        Console.WriteLine(greet("Biden"));

        
        greet = delegate (string name)
        {
            return "Hi, " + name;
        };
        Console.WriteLine(greet("Abama"));

        
        greet = name => $"Hey, {name}!";
        Console.WriteLine(greet("Trumpus"));
    }
}