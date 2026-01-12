class ArrayContainer : ICalc2
{
    private int[] data;

    public ArrayContainer(int[] data)
    {
        this.data = data;
    }

    public int CountDistinct()
    {
        int count = 0;

        for (int i = 0; i < data.Length; i++)
        {
            bool isUnique = true;
            for (int j = 0; j < i; j++)
            {
                if (data[i] == data[j])
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
                count++;
        }
        return count;
    }

    public int EqualToValue(int valueToCompare)
    {
        int count = 0;
        foreach (int x in data)
            if (x == valueToCompare)
                count++;
        return count;
    }
}