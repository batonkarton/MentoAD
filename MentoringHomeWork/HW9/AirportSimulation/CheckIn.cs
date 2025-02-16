namespace AirportSimulation;

public class CheckIn
{
    private Passenger _passenger;
    private BoardingPass boardingPass;
    
    public CheckIn(Passenger passenger)
    {
        _passenger = passenger;
        boardingPass = new BoardingPass(_passenger);
    }

    public void CheckInByAirport()
    {
        Console.WriteLine("Check In By Airport");
        
        PassportControl passportControl = new PassportControl();
        if (!passportControl.ValidatePassport(_passenger))
        {
            Console.WriteLine("\u274c The passenger did not pass the passport check.");
            return;
        }
        
        SecurityCheck securityCheck = new SecurityCheck();
        if (!securityCheck.ValidateSecurity(_passenger))
        {
            Console.WriteLine("\u274c The passenger did not pass the security check.");
            return;
        }
        
        if (VisaCheck.RequiresVisa(_passenger.Country))
        {
            Console.WriteLine("Visa is required.");
        }
        else
        {
            Console.WriteLine("No visa required.");
        }

        boardingPass.PrintBoardingPass();
    }
}

