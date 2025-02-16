namespace AirportSimulation;

public class Flight
{
    private string _airportName;
    private int _airportCode;
    private int _idNumberAircraft;
    private string _departureCity;
    private string _destinationCity;
    private DateTime _departureDate;

    public string AirportName
    {
        get => _airportName;
        set => _airportName = value;
    }

    public int AirportCode
    {
        get => _airportCode;
        set => _airportCode = value;
    }

    public int IdNumberAircraft
    {
        get => _idNumberAircraft;
        set => _idNumberAircraft = value;
    }

    public string DepartureCity
    {
        get => _departureCity;
        set => _departureCity = value;
    }

    public string DestinationCity
    {
        get => _destinationCity;
        set => _destinationCity = value;
    }

    public DateTime DepartureDate
    {
        get => _departureDate;
        set => _departureDate = value;
    }

    public Flight(string airportName, int airportCode, int idNumberAircraft, string departureCity,
        string destinationCity, DateTime departureDate)
    {
        _airportName = airportName;
        _airportCode = airportCode;
        _idNumberAircraft = idNumberAircraft;
        _departureCity = departureCity;
        _destinationCity = destinationCity;
        _departureDate = departureDate;
    }

    public void Print()
    {
        Console.WriteLine($"Airport name: {_airportName}, Code: {_airportCode}, Aircraft ID: {_idNumberAircraft}");
        Console.WriteLine(
            $"Departure: {_departureCity} -> {_destinationCity}, Date: {_departureDate:yyyy-MM-dd HH:mm}");
    }
}
