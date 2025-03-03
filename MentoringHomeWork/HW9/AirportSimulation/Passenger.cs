namespace AirportSimulation;

public class Passenger(string firstName, string lastName, DateTime dateOfBirth, CountryPassengers country)
{
    public string FirstName { get; } = firstName ?? throw new ArgumentNullException(nameof(firstName));
    public string LastName { get; } = lastName ?? throw new ArgumentNullException(nameof(lastName));
    public DateTime DateOfBirth { get; } = dateOfBirth;
    public CountryPassengers Country { get; } = country;
}