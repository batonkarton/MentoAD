namespace AirportSimulation;

public class Passport
{
    private string? PassportNumber { get; }
    private DateTime PassportExpirationDate { get; }

    public Passport(string? passportNumber,DateTime passportExpirationDate)
    {
        PassportNumber = passportNumber;
        PassportExpirationDate = passportExpirationDate;

        if (PassportExpirationDate < DateTime.Today)
        {
            Console.WriteLine("Error: Passport has expired!");
        }
    }
    
    public bool IsPassportValid() => !string.IsNullOrEmpty(PassportNumber) && PassportExpirationDate > DateTime.Today;
}