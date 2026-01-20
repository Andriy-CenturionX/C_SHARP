using System;

class Program
{
    static void Main()
    {
        try
        {
            MethodA();
        }
        catch (Exception ex)
        {
            Console.WriteLine("STACK TRACE:");
            Console.WriteLine(ex.StackTrace);
        }
    }

    static void MethodA()
    {
        MethodB();
    }

    static void MethodB()
    {
        try
        {
            MethodC();
        }
        catch
        {
            throw; 
        }
    }


    static void MethodC()
    {
        throw new Exception("Помилка MethodC");
    }
}
