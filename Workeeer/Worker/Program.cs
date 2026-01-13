using System;

abstract class Worker
{
    public abstract void Print();
}

class President : Worker
{
    public override void Print() => Console.WriteLine("Президент");
}

class Security : Worker
{
    public override void Print() => Console.WriteLine("Охоронець");
}

class Manager : Worker
{
    public override void Print() => Console.WriteLine("Менеджер");
}

class Engineer : Worker
{
    public override void Print() => Console.WriteLine("Інженер");
}

class Program
{
    static void Main()
    {
        Worker w = new Engineer();
        w.Print();

        Console.ReadKey();
    }
}