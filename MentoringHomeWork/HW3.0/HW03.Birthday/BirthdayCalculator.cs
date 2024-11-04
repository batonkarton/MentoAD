namespace HW03.Birthday;

public class BirthdayCalculator
{
    private int _year;
    private int _month; 
    private int _monthCurrent;
    private int _yearCurrent;
    
    public void CalculatePersonAge()
    {
        GetBirthdayMonth();
        GetBirthYear();
        
        GetCurrentMonth();
        GetCurrentYear();
        
        GetAgeDetermination();
    }
    
    private void GetBirthdayMonth()
    {
        Console.WriteLine("Please enter month of your date of birth:");
        _month = Convert.ToInt32(Console.ReadLine());
    }
    
    private void GetBirthYear()
    {
        Console.WriteLine("Please enter year of your date of birth::");
        _year = Convert.ToInt32(Console.ReadLine());
    }
    
    private void GetCurrentMonth()
    {
        Console.WriteLine("Please enter current month:");
        _monthCurrent =Convert.ToInt32(Console.ReadLine());
    }
    
    private void GetCurrentYear()
    {
        Console.WriteLine("Please enter current year:");
        _yearCurrent = Convert.ToInt32(Console.ReadLine());
    }

    private void GetAgeDetermination()
    {
        var resultMonth = _monthCurrent - _month;
        var resultYear = _yearCurrent - _year;
        
        if (resultMonth < 0)
        {
            resultYear--;
        }
        
        Console.WriteLine($"Your age: {resultYear} years");
    }
}