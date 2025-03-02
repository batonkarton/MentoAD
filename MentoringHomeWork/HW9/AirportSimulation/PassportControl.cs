namespace AirportSimulation;

public class PassportControl
{
    public static bool IsPassportValidationPassed(Passenger passenger, Passport? passport)
    {
        if (passport == null || !passport.IsPassportValid())
        {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine(
                $"\u274c {passenger.FirstName} {passenger.LastName}: The passport is invalid or expired!");
            Console.ResetColor();
            
            return false;
        }
        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine($"\u2705 {passenger.FirstName} {passenger.LastName}: Passport accepted.");
        Console.ResetColor();
        
        return true;
    }
}