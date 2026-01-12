class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        ArrayContainer arr = new ArrayContainer(numbers);

        arr.ShowEven();
        arr.ShowOdd();
    }
}