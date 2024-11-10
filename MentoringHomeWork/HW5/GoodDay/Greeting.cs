namespace GoodDay;

public class Greeting
{
    public void Main()
    {
        Console.WriteLine("Time now " + DateTime.Now.TimeOfDay);

        TimeSpan date1 = DateTime.Now.TimeOfDay;

        switch (date1.Hours)
        {
            case >= 9 and < 12:
                Console.WriteLine("Good morning");
                break;
            case >= 12 and < 15:
                Console.WriteLine("Good day");
                break;
            case >= 15 and < 23:
                Console.WriteLine("Good evening");
                break;
            default:
                Console.WriteLine("Good night");
                break;
        }
    }
}