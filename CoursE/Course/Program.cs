using System;

class Course
{
    public string Name { get; set; }
    public int Duration { get; set; }

    public Course(string name, int duration)
    {
        Name = name;
        Duration = duration;
    }

    public override string ToString()
    {
        return $"Курс: {Name}, Тривалість: {Duration} годин";
    }
}

class OnlineCourse : Course
{
    public string Platform { get; set; }

    public OnlineCourse(string name, int duration, string platform)
        : base(name, duration)
    {
        Platform = platform;
    }

    public override string ToString()
    {
        return base.ToString() + $", Платформа: {Platform}";
    }
}

class Program
{
    static void Main()
    {
        Course c = new Course("C#", 40);
        OnlineCourse oc = new OnlineCourse("OOP", 30, "Udemy");

        Console.WriteLine(c);
        Console.WriteLine(oc);

        Console.ReadKey();
    }
}
