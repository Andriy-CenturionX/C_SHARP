using System;

class ArrayContainer : IOutput2
{
    private int[] data;

    public ArrayContainer(int[] data)
    {
        this.data = data;
    }

    public void ShowEven()
    {
        Console.WriteLine("Парні:");
        foreach (int x in data)
            if (x % 2 == 0)
                Console.Write(x + " ");
        Console.WriteLine();
    }

    public void ShowOdd()
    {
        Console.WriteLine("Непарні:");
        foreach (int x in data)
            if (x % 2 != 0)
                Console.Write(x + " ");
        Console.WriteLine();
    }
}