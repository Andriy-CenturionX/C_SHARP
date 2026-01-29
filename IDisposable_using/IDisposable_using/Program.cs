using System;
using System.IO;

class FileWriter : IDisposable
{
    private StreamWriter writer;

    public FileWriter(string path)
    {
        writer = new StreamWriter(path);
    }

    public void Write(string text)
    {
        writer.WriteLine(text);
    }

    public void Dispose()
    {
        writer.Dispose();
    }
}

class Program
{
    static void Main()
    {
        using (var fw = new FileWriter("test.txt"))
        {
            fw.Write("Hello, world!");
            fw.Write("File closed automatically");
        }
    }
}
