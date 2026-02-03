using System;

class SimpleButton
{
    public event Action OnClick;

    public void Press()
    {
        OnClick?.Invoke();
    }
}

class Program
{
    static void Main()
    {
        var btn = new SimpleButton();
        btn.OnClick += () => Console.WriteLine("Button clicked");

        btn.Press();
    }
}
