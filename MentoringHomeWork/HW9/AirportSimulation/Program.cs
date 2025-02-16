using AirportSimulation;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter Passport Number: ");
        string passportNumber = Console.ReadLine();

        Console.Write("Enter Passport Issue Date (yyyy-mm-dd): ");
        DateTime passportIssueDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter Passport Expiration Date (yyyy-mm-dd): ");
        DateTime passportExpirationDate = DateTime.Parse(Console.ReadLine());
        
        Passport passport = new Passport(passportNumber, passportIssueDate, passportExpirationDate);
        
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Date of Birth (yyyy-mm-dd): ");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
        
        Console.WriteLine("Select Country: ");
        foreach (var country in Enum.GetValues(typeof(Countries.CountryPassengers)))
        {
            Console.WriteLine($"{(int)country} - {country}");
        }

        int countryChoice = int.Parse(Console.ReadLine());
        Countries.CountryPassengers selectedCountry = (Countries.CountryPassengers)countryChoice;
        
        Passenger passenger = new Passenger(firstName, lastName, dateOfBirth, selectedCountry, passportNumber, passport);
        
        CheckIn checkIn = new CheckIn(passenger);
        checkIn.CheckInByAirport();
    }
}
