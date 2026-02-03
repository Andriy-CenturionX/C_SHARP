using System;

class Messenger
{
    public event EventHandler<string> MessageReceived;

    public void Receive(string message)
    {
        MessageReceived?.Invoke(this, message);
    }
}

class Program
{
    static void Main()
    {
        var m = new Messenger();
        m.MessageReceived += (sender, msg) =>
        {
            Console.WriteLine($"Message: {msg}");
        };

        m.Receive("Hello .NET!");
    }
}
