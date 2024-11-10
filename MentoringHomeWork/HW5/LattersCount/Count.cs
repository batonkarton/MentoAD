namespace LattersCount;

public class Count
{
    public void Main()
    {
        Console.WriteLine("Say something ");

        var txt = Console.ReadLine();
        int count = 0;

        foreach (var item in txt)
        {
            if (item == 'a')
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}