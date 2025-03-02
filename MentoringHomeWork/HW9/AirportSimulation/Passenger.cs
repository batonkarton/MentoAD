using AirportSimulation;

public class Passenger
{
    public string FirstName { get; }
    public string LastName { get; }
    public DateTime DateOfBirth { get; }
    public Countries.CountryPassengers Country { get; }

    public Passenger(string firstName, string lastName, DateTime dateOfBirth, Countries.CountryPassengers country)
    {
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        DateOfBirth = dateOfBirth;
        Country = country;
    }
}