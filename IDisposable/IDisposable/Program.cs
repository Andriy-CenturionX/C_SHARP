using System;

class Logger : IDisposable
{
    public void Log(string message)
    {
        Console.WriteLine("LOG: " + message);
    }

    public void Dispose()
    {
        Console.WriteLine("Лог закрито, ресурси звільнено");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            using (var logger = new Logger())
            {
                logger.Log("Старт");
                throw new Exception("помилка");
            }
        }
        catch
        {
            Console.WriteLine("Exception перехоплено");
        }
    }
}