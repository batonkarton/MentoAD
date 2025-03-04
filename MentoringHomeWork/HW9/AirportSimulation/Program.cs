namespace AirportSimulation;

public class Program
{
    public static void Main()
    {
        string? passportNumber;
        while (true)
        {
            Console.Write("Enter Passport Number: ");
            passportNumber = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(passportNumber))
            {
                break;
            }
            
            Console.WriteLine("Passport number cannot be empty. Please enter a valid passport number.");
        }

        while (true)
        {
            Console.Write("Enter Passport Issue Date (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out _))
            {
                break;
            }

            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Invalid date format. Please try again.");
            Console.ResetColor();
        }

        DateTime passportExpirationDate;
        while (true)
        {
            Console.Write("Enter Passport Expiration Date (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out passportExpirationDate))
            {
                break;
            }

            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Invalid date format. Please try again.");
            Console.ResetColor();
        }

        var passport = new Passport(passportNumber, passportExpirationDate);

        Console.Write("Enter First Name: ");
        var firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        var lastName = Console.ReadLine();

        DateTime dateOfBirth;
        while (true)
        {
            Console.Write("Enter Date of Birth (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
            {
                break;
            }

            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Invalid date format. Please try again.");
            Console.ResetColor();
        }

        Console.WriteLine("Select Country:");
        foreach (var country in Enum.GetValues(typeof(CountryPassengers)))
        {
            Console.WriteLine($"{(int)country} - {country}");
        }

        CountryPassengers selectedCountry;
        while (true)
        {
            Console.Write("Enter country number: ");
            if (int.TryParse(Console.ReadLine(), out var countryChoice) &&
                Enum.IsDefined(typeof(CountryPassengers), countryChoice))
            {
                selectedCountry = (CountryPassengers)countryChoice;
         
                break;
            }

            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Invalid selection. Please try again.");
            Console.ResetColor();
        }

        if (firstName == null) return;
        if (lastName == null) return;
        var passenger = new Passenger(firstName, lastName, dateOfBirth, selectedCountry);

        var checkIn = new CheckIn(passenger, passport);
        checkIn.StartCheckIn();
    }
}