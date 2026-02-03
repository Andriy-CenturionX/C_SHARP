using System;

class StockMarket
{
    public event EventHandler<(string stock, double price)> PriceChanged;
    private Random rnd = new();

    public void Tick()
    {
        var price = rnd.Next(50, 150);
        PriceChanged?.Invoke(this, ("Apple", price));
    }
}

class TradingBot
{
    public void Subscribe(StockMarket market)
    {
        market.PriceChanged += OnPriceChanged;
    }

    private void OnPriceChanged(object sender, (string stock, double price) e)
    {
        if (e.stock == "Apple" && e.price < 100)
            Console.WriteLine($"BUY APPLE at {e.price}$");
    }
}

class Program
{
    static void Main()
    {
        var market = new StockMarket();
        var bot = new TradingBot();

        bot.Subscribe(market);

        
        for (int i = 0; i < 20; i++)
        {
            market.Tick();
            System.Threading.Thread.Sleep(300);
        }

        Console.ReadKey();
    }
}