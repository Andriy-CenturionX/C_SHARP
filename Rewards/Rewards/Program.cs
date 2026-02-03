using System;

class Player
{
    private int _coins;
    public event EventHandler<int> CoinCollected;

    public void CollectCoin()
    {
        _coins++;
        CoinCollected?.Invoke(this, _coins);
    }
}

class AchievementSystem
{
    public void Subscribe(Player p)
    {
        p.CoinCollected += OnCoinCollected;
    }

    private void OnCoinCollected(object sender, int coins)
    {
        if (coins == 100)
            Console.WriteLine("REWARD UNLOCKED: Very Good!");
    }
}

class UISystem
{
    public void Subscribe(Player p)
    {
        p.CoinCollected += (_, coins) =>
            Console.WriteLine($"Score: {coins}");
    }
}

class Program
{
    static void Main()
    {
        var player = new Player();

        var achievements = new AchievementSystem();
        var ui = new UISystem();

        achievements.Subscribe(player);
        ui.Subscribe(player);

        
        for (int i = 0; i < 100; i++)
        {
            player.CollectCoin();
        }

        Console.ReadKey();
    }
}