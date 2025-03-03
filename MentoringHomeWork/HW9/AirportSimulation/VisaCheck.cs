namespace AirportSimulation;

public static class VisaCheck
{
    public static bool IsVisaRequired(CountryPassengers country)
    {
        return !Enum.IsDefined(typeof(CountryPassengers), country);
    }
}