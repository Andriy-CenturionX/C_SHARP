using System;

class Program
{
    
    delegate double MathOperation(double a, double b);

    
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static void Main()
    {
        
        MathOperation op;

        
        op = Add;
        Console.WriteLine("Add: " + op(10, 5));   

        
        op = Subtract;
        Console.WriteLine("Subtract: " + op(10, 5));
    }
}