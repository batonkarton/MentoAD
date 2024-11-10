namespace HW._05.Task1;

public class CalculateCount
{
    public void Main()
    {
        Console.WriteLine("Please, enter your number:");

        var getNumber = Convert.ToInt32(Console.ReadLine());
        var result = 0;

        for (int i = 0; i <= getNumber; i++)
        {
            result += i;
        }

        Console.WriteLine(result);
    }
}