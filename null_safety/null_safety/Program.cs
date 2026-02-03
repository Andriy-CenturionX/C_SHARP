using System;

class Doorbell
{
    public event Action OnRing;

    public void Ring()
    {
        OnRing?.Invoke();
    }
}

class Program
{
    static void Main()
    {
        Doorbell doorbell = new Doorbell();

        doorbell.OnRing += () =>
        {
            Console.WriteLine("подзвонив");
        };

        Console.WriteLine("Натисни Enter, щоб подзвонити");
        Console.ReadLine();

        doorbell.Ring();
    }
}