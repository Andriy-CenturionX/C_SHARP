using System;

class Device
{
    protected string Name;
    protected string Description;

    public Device(string name, string desc)
    {
        Name = name;
        Description = desc;
    }

    public virtual void Sound() { }
    public void Show() => Console.WriteLine(Name);
    public void Desc() => Console.WriteLine(Description);
}

class Kettle : Device
{
    public Kettle() : base("Чайник", "Кип’ятить воду") { }
    public override void Sound() => Console.WriteLine("буль-буль");
}

class Microwave : Device
{
    public Microwave() : base("Мікрохвильовка", "Розігріває їжу") { }
    public override void Sound() => Console.WriteLine("пі-пі-пі");
}

class Car : Device
{
    public Car() : base("Автомобіль", "Транспорт") { }
    public override void Sound() => Console.WriteLine("Біііііп!");
}

class Plane : Device
{
    public Plane() : base("F-4 Phantom", "Авіація") { }
    public override void Sound() => Console.WriteLine("БУМ");
    
}

class Program
{
    static void Main()
    {
        Device d = new Car();
        d.Show();
        d.Desc();
        d.Sound();

        Console.ReadKey();
    }
}
