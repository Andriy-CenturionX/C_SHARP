using System;

class BaseConverter
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Оберіть перетворення:");
            Console.WriteLine("1 Decimal → Binary");
            Console.WriteLine("2 Decimal → Hex");
            Console.WriteLine("3 Binary → Decimal");
            Console.WriteLine("4 Hex → Decimal");

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Введіть число: ");
            string input = Console.ReadLine();

            int result;

            switch (choice)
            {
                case 1:
                    result = int.Parse(input);
                    Console.WriteLine(Convert.ToString(result, 2));
                    break;

                case 2:
                    result = int.Parse(input);
                    Console.WriteLine(Convert.ToString(result, 16));
                    break;

                case 3:
                    result = Convert.ToInt32(input, 2);
                    Console.WriteLine(result);
                    break;

                case 4:
                    result = Convert.ToInt32(input, 16);
                    Console.WriteLine(result);
                    break;

                default:
                    throw new ArgumentException("Невірний вибір");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка формату числа");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Число виходить за межі int");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}