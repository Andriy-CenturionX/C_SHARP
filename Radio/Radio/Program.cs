using System;

class RadioStation
{
    public event Action<string> NewsBroadcast;

    public void Broadcast(string news)
    {
        NewsBroadcast?.Invoke(news);
    }
}

class Program
{
    static void Main()
    {
        var radio = new RadioStation();

        Action<string> car = n => Console.WriteLine("Car: " + n);
        Action<string> home = n => Console.WriteLine("Home: " + n);
        Action<string> spy = n => Console.WriteLine("Spy: " + n);

        radio.NewsBroadcast += car;
        radio.NewsBroadcast += home;
        radio.NewsBroadcast += spy;

        radio.Broadcast("News #1");

        radio.NewsBroadcast -= spy; 

        radio.Broadcast("News #2");
    }
}