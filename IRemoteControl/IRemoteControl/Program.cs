class Program
{
    static void Main()
    {
        IRemoteControl tv = new Television();
        tv.TurnOn();
        tv.SetChannel(7);
        tv.TurnOff();

        IRemoteControl radio = new Radio();
        radio.TurnOn();
        radio.SetChannel(101);
        radio.TurnOff();
    }
}