namespace AirportSimulation;

public class PassportControl
{
    public bool ValidatePassport(Passenger passenger)
    {
        if (!passenger.PassportIsValid())
        {
            Console.WriteLine($"\u274c {passenger.FirstName} {passenger.LastName}: The passport is invalid or expired!");
            return false;
        }

        Console.WriteLine($"\u2705 {passenger.FirstName} {passenger.LastName}: Passport accepted.");
        return true;
    }
}
