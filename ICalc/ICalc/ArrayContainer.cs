class ArrayContainer : ICalc
{
    private int[] data;

    public ArrayContainer(int[] data)
    {
        this.data = data;
    }

    public int Less(int valueToCompare)
    {
        int count = 0;
        foreach (int x in data)
            if (x < valueToCompare)
                count++;
        return count;
    }

    public int Greater(int valueToCompare)
    {
        int count = 0;
        foreach (int x in data)
            if (x > valueToCompare)
                count++;
        return count;
    }
}