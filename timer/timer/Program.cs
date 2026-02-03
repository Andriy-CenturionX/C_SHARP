using System;
using System.Threading;

class Countdown
{
    public event EventHandler<int> Tick;
    public event EventHandler TimeUp;

    private int _seconds;

    public Countdown(int seconds)
    {
        _seconds = seconds;
    }

    public void Start()
    {
        while (_seconds > 0)
        {
            Tick?.Invoke(this, _seconds);
            Thread.Sleep(1000);
            _seconds--;
        }

        TimeUp?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main()
    {
        var timer = new Countdown(5);

        timer.Tick += (_, sec) =>
            Console.WriteLine($"Залишилось: {sec}...");

        timer.TimeUp += (_, __) =>
        {
            Console.Clear();
            Console.WriteLine("BOOM!");
        };

        timer.Start();
    }
}
