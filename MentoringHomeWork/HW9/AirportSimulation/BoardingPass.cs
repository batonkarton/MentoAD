namespace AirportSimulation;

public class BoardingPass(Passenger passenger)
{
    public void PrintBoardingPass()
    {
        Console.WriteLine($"The boarding pass: {passenger.FirstName} {passenger.LastName}, " +
                          $"{passenger.DateOfBirth.ToShortDateString()}, Countries: {passenger.Country}");
    }
}
