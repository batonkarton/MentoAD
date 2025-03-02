namespace AirportSimulation;

public class SecurityCheck
{
    public static bool IsSecurityCheckPassed(Passenger passenger)
    {
        Console.WriteLine(
            $"A safety check is underway for the passenger {passenger.FirstName} {passenger.LastName}...");

        Console.WriteLine("Do you have any prohibited items? (yes/no)");
        var input = Console.ReadLine()?.ToLower();

        var hasProhibitedItems = false;
        if (input == "yes")
        {
            hasProhibitedItems = true;
        }
        else if (input != "no")
        {
            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            
            return false;
        }

        if (hasProhibitedItems)
        {
            Console.WriteLine($"\u274c {passenger.FirstName} {passenger.LastName}: Prohibited items found!");
            
            return false;
        }
        
        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine($"\u2705 {passenger.FirstName} {passenger.LastName}: Security check passed.");
        Console.ResetColor();
        
        return true;
    }
}