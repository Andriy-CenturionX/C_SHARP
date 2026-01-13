using System;

class Money
{
    protected int whole;
    protected int cents;

    public Money(int whole, int cents)
    {
        SetMoney(whole, cents);
    }

    public void SetMoney(int whole, int cents)
    {
        this.whole = whole + cents / 100;
        this.cents = cents % 100;
    }

    public virtual void Show()
    {
        Console.WriteLine($"{whole}.{cents:D2}");
    }
}

class Product : Money
{
    public string Name { get; set; }

    public Product(string name, int whole, int cents)
        : base(whole, cents)
    {
        Name = name;
    }

    public void ReducePrice(int amount)
    {
        int total = whole * 100 + cents - amount * 100;
        if (total < 0) total = 0;

        whole = total / 100;
        cents = total % 100;
    }

    public override void Show()
    {
        Console.Write($"{Name}: ");
        base.Show();
    }
}

class Program
{
    static void Main()
    {
        Product p = new Product("Iphonchik", 10000, 50);
        p.ReducePrice(500);
        p.Show();

        Console.ReadKey();
    }
}