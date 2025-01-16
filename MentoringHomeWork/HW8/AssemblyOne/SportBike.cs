using AssemblyOne;

public class SportBike : Motorcycle
{
    public string SportName { get; set; }
    public string SportType { get; set; }

    SportBike.MotorcycleEngine Engine { get; set; }
    private string _st1 = "vin";

    public void Start()
    {
        Console.WriteLine("SportBike Start");
    }

    private void MotorcycleEngine()
    {
        var engine = "gas";
    }

    private protected void CarEngine()
    {
        var engineOfCar = "diesel";
    }
}
    
