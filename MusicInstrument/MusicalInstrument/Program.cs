using System;

class MusicalInstrument
{
    protected string Name;
    protected string Description;
    protected string HistoryText;

    public MusicalInstrument(string name, string desc, string history)
    {
        Name = name;
        Description = desc;
        HistoryText = history;
    }

    public virtual void Sound() { }
    public void Show() => Console.WriteLine(Name);
    public void Desc() => Console.WriteLine(Description);
    public void History() => Console.WriteLine(HistoryText);
}

class Violin : MusicalInstrument
{
    public Violin() : base("Скрипка", "Струнний інструмент", "З’явилась у XVI столітті") { }
    public override void Sound() => Console.WriteLine("Віііі...");
}

class Program
{
    static void Main()
    {
        MusicalInstrument m = new Violin();
        m.Show();
        m.Sound();
        m.Desc();
        m.History();

        Console.ReadKey();
    }
}
