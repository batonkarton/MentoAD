namespace HW._05.Task3;

public class TimeOfDay
{
    public void Main()
    {
        Console.WriteLine("Time now " + DateTime.Now.TimeOfDay);

        TimeSpan date1 = DateTime.Now.TimeOfDay;
        
        switch (date1.Hours)
        {
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Good morning");
                break;
            case 12:
            case 13:
            case 14:
                Console.WriteLine("Good afternoon");
                break;
            case 15:
            case 16:
            case 17:
                Console.WriteLine("Good evening");
                break;
            default:
                Console.WriteLine("Good night");
                break;
        }
    }
}