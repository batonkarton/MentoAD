namespace LattersCount;

public class Counts
{
    public void Main()
    {
        Console.WriteLine("Say something ");

        var txt = Console.ReadLine().ToUpper();
        int count = 0;

        foreach (var item in txt)
        {
            if (item == 'A')
            {
                count++;
            }
            else if (item == 'А')
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}