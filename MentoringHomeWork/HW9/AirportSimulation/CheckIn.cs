namespace AirportSimulation;

public class CheckIn(Passenger passenger, Passport? passport)
{
    public void StartCheckIn()
    {
        Console.WriteLine("Check In By Airport");

        var passportControl = new PassportControl();
        if (!PassportControl.IsPassportValidationPassed(passenger, passport))
        {
            Console.WriteLine("\u274c The passenger did not pass the passport check.");
            return;
        }

        var securityCheck = new SecurityCheck();
        if (!securityCheck.IsSecurityCheckPassed(passenger))
        {
            Console.WriteLine("\u274c The passenger did not pass the security check.");
            return;
        }

        Console.WriteLine(VisaCheck.IsVisaRequired(passenger.Country) ? "Visa is required." : "No visa required.");
        Console.WriteLine("Welcome on board ");
    }
}