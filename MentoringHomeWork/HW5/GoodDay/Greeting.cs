namespace GoodDay;

public class Greeting
{
    public void Main()
    {
        Console.WriteLine("Time now " + DateTime.Now.TimeOfDay);

        TimeSpan date1 = DateTime.Now.TimeOfDay;

        if (date1.Hours >= 9 && date1.Hours < 12)
        {
            Console.WriteLine("Good morning");
        }
        else if (date1.Hours >= 12 && date1.Hours < 15)
        {
            Console.WriteLine("Good day");
        }
        else if (date1.Hours >= 15 && date1.Hours < 23)
        {
            Console.WriteLine("Good evening");
        }
        else
        {
            Console.WriteLine("Good night");
        }
    }
}