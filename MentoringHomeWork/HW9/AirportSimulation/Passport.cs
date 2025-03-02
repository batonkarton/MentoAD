using System.Net.Sockets;

namespace AirportSimulation;

public class Passport
{
    public string? PassportNumber { get; set; }
    public DateTime PassportDate { get; set; }
    public DateTime PassportExpirationDate { get; }

    public Passport(string? passportNumber, DateTime passportDate, DateTime passportExpirationDate)
    {
        PassportNumber = passportNumber;
        PassportDate = passportDate;
        PassportExpirationDate = passportExpirationDate;

        if (PassportExpirationDate < DateTime.Today)
        {
            Console.WriteLine("Error: Passport has expired!");
        }
    }
    
    public bool IsPassportValid() => !string.IsNullOrEmpty(PassportNumber) && PassportExpirationDate > DateTime.Today;
}