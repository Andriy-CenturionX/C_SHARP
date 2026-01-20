using System;

class Program
{
    static void Main()
    {
        try
        {
            ProcessOrder();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

            foreach (var key in ex.Data.Keys)
            {
                Console.WriteLine($"{key}: {ex.Data[key]}");
            }
        }
    }

    static void ProcessOrder()
    {
        try
        {
            throw new Exception("Помилка обробки замовлення");
        }
        catch (Exception ex)
        {
            ex.Data.Add("OrderId", 123);
            ex.Data.Add("Time", DateTime.Now);
            ex.Data.Add("User", "Admin");

            throw; 
        }
    }
}