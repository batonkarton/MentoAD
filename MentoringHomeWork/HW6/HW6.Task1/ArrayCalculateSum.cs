namespace HW6.Task1;

public static class ArrayCalculator
{
    public static void ArraySum()
    {
        var rnd = new Random();
        var numbersRnd = new int[20];

        for (var i = 0; i < 20; i++)
        {
            numbersRnd[i] = rnd.Next(100);
        }

        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];
        var numbersSum = new int[numbers.Length];

        for (var i = 0; i < numbers.Length; i++)
        {
            numbersSum[i] = numbersRnd[i] + numbers[i];
        }

        foreach (var t in numbersSum)
        {
            Console.WriteLine(t);
        }
    }
}