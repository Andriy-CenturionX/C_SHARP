using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            InitModule();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Message: " + ex.Message);
            Console.WriteLine("Inner: " + ex.InnerException?.Message);
        }
    }

    static void InitModule()
    {
        try
        {
            LoadConfig();
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException(
                "Не вдалося запустити модуль",
                ex
            );
        }
    }

    static void LoadConfig()
    {
        throw new FileNotFoundException("config.json не знайдено");
    }
}