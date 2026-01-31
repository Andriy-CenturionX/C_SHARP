using System;

class Program
{
    delegate void ShowMessage(string message);

    static void Main()
    {
        ShowMessage show;

        
        show = delegate (string msg)
        {
            Console.WriteLine(">>> " + msg);
        };

        show("Hello, abobus");
    }
}