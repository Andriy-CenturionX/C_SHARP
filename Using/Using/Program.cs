using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            using (var writer = new StreamWriter("test.txt"))
            {
                writer.WriteLine("Секретний запис");
                throw new Exception("Бум");
            }
        }
        catch
        {
            Console.WriteLine("Помилка ");
        }

        File.Delete("test.txt");
        Console.WriteLine("Файл видалено");
    }
}
