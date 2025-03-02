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
            else
            {
                Console.WriteLine("Passport number cannot be empty. Please enter a valid passport number.");
            }
        }

        DateTime passportIssueDate;
        while (true)
        {
            Console.Write("Enter Passport Issue Date (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out passportIssueDate))
            {
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine("Invalid date format. Please try again.");
                Console.ResetColor();
            }
        }

        DateTime passportExpirationDate;
        while (true)
        {
            Console.Write("Enter Passport Expiration Date (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out passportExpirationDate))
            {
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine("Invalid date format. Please try again.");
                Console.ResetColor();
            }
        }

        var passport = new Passport(passportNumber, passportIssueDate, passportExpirationDate);

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
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine("Invalid date format. Please try again.");
                Console.ResetColor();
            }
        }

        Console.WriteLine("Select Country:");
        foreach (var country in Enum.GetValues(typeof(Countries.CountryPassengers)))
        {
            Console.WriteLine($"{(int)country} - {country}");
        }

        Countries.CountryPassengers selectedCountry;
        while (true)
        {
            Console.Write("Enter country number: ");
            if (int.TryParse(Console.ReadLine(), out var countryChoice) &&
                Enum.IsDefined(typeof(Countries.CountryPassengers), countryChoice))
            {
                selectedCountry = (Countries.CountryPassengers)countryChoice;
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine("Invalid selection. Please try again.");
                Console.ResetColor();
            }
        }

        if (firstName == null) return;
        if (lastName == null) return;
        var passenger = new Passenger(firstName, lastName, dateOfBirth, selectedCountry);

        var checkIn = new CheckIn(passenger, passport);
        checkIn.StartCheckIn();
    }
}