namespace AirportSimulation;

public class BoardingPass
{
    public Passenger Passenger { get; }

    public BoardingPass(Passenger passenger)
    {
        Passenger = passenger;
    }

    public void PrintBoardingPass()
    {
        Console.WriteLine($"The boarding pass: {Passenger.FirstName} {Passenger.LastName}, " +
                          $"{Passenger.DateOfBirth.ToShortDateString()}, Countrie: {Passenger.Country}");
    }
}
