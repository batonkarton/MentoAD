namespace HW6.Task2;

public class ArrayService
{
    public void AddNewPosition()
    {
        int[] numbers = new int[6];

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            Console.WriteLine("Please enter the number: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            
        }

        ShowResultArray(numbers);

        Console.WriteLine("\n Please enter the number: ");
        var newValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please inter the position : ");
        var position = Convert.ToInt32(Console.ReadLine());

        for (int i = numbers.Length - 2; i > position; i--)
        {
            numbers[i + 1] = numbers[i];
        }

        numbers[position] = newValue;

        ShowResultArray(numbers);
    }

    private void ShowResultArray(int[] numbers)
    {
        Console.WriteLine("Yours numbers are : ");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != 0)
            {
                    Console.Write(numbers[i]);
                
            }
        }
    }
}