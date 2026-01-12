using System;

class Television : IRemoteControl
{
    public void TurnOn() => Console.WriteLine("Телевізор увімкнено");
    public void TurnOff() => Console.WriteLine("Телевізор вимкнено");
    public void SetChannel(int channel) =>
        Console.WriteLine("Канал телевізора: " + channel);
}