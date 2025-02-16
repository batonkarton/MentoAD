using AirportSimulation;


public class VisaCheck
{
    public static bool RequiresVisa(Countries.CountryPassengers country)
    {
        return !Enum.IsDefined(typeof(Countries.CountryPassengers), country);
    }
}
