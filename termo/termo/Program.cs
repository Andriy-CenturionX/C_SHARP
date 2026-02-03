using System;

class TemperatureArgs : EventArgs
{
    public double OldTemperature { get; }
    public double NewTemperature { get; }

    public TemperatureArgs(double oldT, double newT)
    {
        OldTemperature = oldT;
        NewTemperature = newT;
    }
}

class Thermostat
{
    private double _temperature;

    public event EventHandler<TemperatureArgs> TemperatureChanged;

    public void SetTemperature(double newTemp)
    {
        if (_temperature == newTemp) return;

        var old = _temperature;
        _temperature = newTemp;

        TemperatureChanged?.Invoke(
            this,
            new TemperatureArgs(old, newTemp)
        );
    }
}

class Program
{
    static void Main()
    {
        var thermostat = new Thermostat();

        
        thermostat.TemperatureChanged += OnTemperatureChanged;

        thermostat.SetTemperature(20);
        thermostat.SetTemperature(23);
        thermostat.SetTemperature(25); 
        thermostat.SetTemperature(18);

        Console.ReadKey();
    }

    static void OnTemperatureChanged(object sender, TemperatureArgs e)
    {
        Console.WriteLine(
            $"Температура змінилась з {e.OldTemperature}°C на {e.NewTemperature}°C"
        );
    }
}