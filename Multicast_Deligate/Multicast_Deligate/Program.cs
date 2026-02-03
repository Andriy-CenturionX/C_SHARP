using System;

class Counter
{
    public event Action ThresholdReached;
    private int _value;

    public void Increment()
    {
        _value++;
        if (_value == 10)
            ThresholdReached?.Invoke();
    }
}

class Program
{
    static void Main()
    {
        var counter = new Counter();

        counter.ThresholdReached += () => Console.WriteLine("Handler A");
        counter.ThresholdReached += () => Console.WriteLine("Handler B");

        for (int i = 0; i < 10; i++)
            counter.Increment();
    }
}