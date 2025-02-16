namespace AirportSimulation;

public class SecurityCheck
{
    public bool ValidateSecurity(Passenger passenger)
    {
        
        Console.WriteLine($"A safety check is underway for the passenger {passenger.Name}...");
       
        bool hasProhibitedItems = false;  

        if (hasProhibitedItems)
        {
            Console.WriteLine($"\u274c {passenger.Name}: Prohibited items found!");
            return false;
        }

        Console.WriteLine($"\u2705 {passenger.Name}: Security check passed.");
        return true;
    }
}
