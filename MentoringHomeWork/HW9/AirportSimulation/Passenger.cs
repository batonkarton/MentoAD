using System.Runtime.InteropServices.JavaScript;

namespace AirportSimulation;

public class Passenger
{
    private string _firstName;
    private string _lastName;
    private DateTime _dateOfBirth;
    private string _passportNumber;
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Countries.CountryPassengers Country { get; set; }
    public string PassportNumber { get; set; }
    
    public Passport Passport { get; set; }
    public string Name { get; set; }
    
    public Passenger(string firstName, string lastName, DateTime dateOfBirth, Countries.CountryPassengers country, string passportNumber, Passport passport)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Country = country;
        PassportNumber = passportNumber;
        Passport = passport;  
    }

    public bool PassportIsValid() => Passport?.PassportIsValid() ?? false;
}
