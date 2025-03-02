using AirportSimulation;


public class VisaCheck
{
    public static bool IsVisaRequired(Countries.CountryPassengers country)
    {
        return !Enum.IsDefined(typeof(Countries.CountryPassengers), country);
    }
}
