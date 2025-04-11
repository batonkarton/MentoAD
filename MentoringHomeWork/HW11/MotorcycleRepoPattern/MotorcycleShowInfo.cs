namespace ConsoleApp1;

public class MotorcycleShowInfo
{
    protected static void ShowInfo(Motorcycle moto)
    {
        Console.WriteLine(
            $"motorcycle id: {moto.Id}\n Brand: {moto.Brand}\n Year: {moto.Year}\n Mileage: {moto.Mileage}");
    }

    protected static void ShowAllInfo(IMotorcycleRepository repo)
    {
        var motorcycles = repo.GetAll();

        Console.WriteLine("Motorcycle info:");
        
        foreach (var motor in motorcycles)
        {
            Console.WriteLine($"ID: {motor.Id}, Brand: {motor.Brand}, Year: {motor.Year}, Mileage: {motor.Mileage}");
        }
    }
}