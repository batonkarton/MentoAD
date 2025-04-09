using Serilog;
namespace ConsoleApp1;

public class MotorcycleUpdateService : MotorcycleShowInfo
{
    private readonly MotorcycleService _motorcycleService = new();

    public void Update(MotorcycleRepository repository)
    {
        Console.WriteLine("Do you want to update the motorcycle (y/n?) \n");
        var inputAnswer = Console.ReadKey();
        Log.Information("The user chooses:{KEY} to update the motorcycle ID", inputAnswer.Key);
        
        if (inputAnswer.Key == ConsoleKey.Y)
        {
            var selectedMotorcycle = _motorcycleService.SelectMotorcycle();

            Console.WriteLine("What would you like to update? ( brand, year, mileage)\n");
            var inputUpdate = Console.ReadLine()?.ToLower();

            Console.WriteLine($"Enter new value for {inputUpdate}:");
            var newValue = Console.ReadLine();

            switch (inputUpdate)
            {
                case "brand":
                    selectedMotorcycle.Brand = newValue;
                    Log.Information("Brand updated");
                    break;
                case "year":
                    if (int.TryParse(newValue, out var newYear))
                        selectedMotorcycle.Year = newYear;
                    Log.Information("Year updated");
                    break;
                case "mileage":
                    if (int.TryParse(newValue, out var newMileage))
                        selectedMotorcycle.Mileage = newMileage;
                    Log.Information("Mileage updated");
                    break;
                default:
                    Log.Warning("Invalid input");
                    break;
            }

            repository.Update(selectedMotorcycle);
            Console.WriteLine("Motorcycle updated");
            ShowInfo(selectedMotorcycle);

            Console.WriteLine("Do you want see all motorcycles? (y/n)");
            var inputSeeAll = Console.ReadKey();

            if (inputSeeAll.Key == ConsoleKey.Y)
            {
                ShowAllInfo(repository);
            }
        }
        else ShowAllInfo(repository);
    }
}