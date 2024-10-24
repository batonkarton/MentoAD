// See https://aka.ms/new-console-template for more information

namespace HW03.Birthday;

class Birthday
{
    private int month;
    private int year;
    private int monthCurrent;
    private int yearCurrent;
    public void Run()
    {
        BirthYear();
        CurrentYear();
        AgeDetermination();
    }
    void BirthYear()
    {
        Console.WriteLine("Введите месяц своего рождения:");
        month =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите год своего рождения:");
        year = Convert.ToInt32(Console.ReadLine());
    }
    private void CurrentYear()
    {
        Console.WriteLine("Введите месяц текущего года:");
        monthCurrent =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Какой сейчас год?:");
        yearCurrent = Convert.ToInt32(Console.ReadLine());
    }

    private void AgeDetermination()
    {
        int resultMonth = monthCurrent - month;
        int resultYear = yearCurrent - year;
        if (resultMonth < 0)
        {
            resultYear--;
        }
        Console.WriteLine("Ваш возраст:" /*+ resultMonth + " месяцев и */ + resultYear + " лет");
    }
    static void Main(string[] args)
    {
        Birthday birthday = new Birthday();
        birthday.Run();
    }
}