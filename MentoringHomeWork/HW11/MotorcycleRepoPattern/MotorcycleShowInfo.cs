namespace ConsoleApp1;

public class MotorcycleShowInfo
{
    public List<Motorcycle> _motorcycles = new List<Motorcycle>();
    public void AskUSerShowIfo(Motorcycle? moto)
    {
        Console.WriteLine("Do you want show info ? (y/n)");
        var answer = Console.ReadKey();

        if (answer.Key == ConsoleKey.Y)
        {
            ShowInfo(moto);
        }
    }

    public void ShowInfo(Motorcycle moto)
    {
        Console.WriteLine(
            $"motorcycle id: {moto.Id}\n Brand: {moto.Brand}\n Year: {moto.Year}\n Mileage: {moto.Mileage}");
    }

    public void ShowAllInfo(IMotorcycleRepository repo)
    {
        List<Motorcycle?> motorcycles = repo.GetMotorcycles();
        
        Console.WriteLine("Motorcycle info:");
        foreach (var motor in motorcycles)
        {
            Console.WriteLine($"ID: {motor.Id}, Brand: {motor.Brand}, Year: {motor.Year}, Mileage: {motor.Mileage}");
        }
    }

}