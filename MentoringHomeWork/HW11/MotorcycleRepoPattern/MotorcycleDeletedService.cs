using Serilog;
namespace ConsoleApp1;

public class MotorcycleDeletedService : MotorcycleShowInfo
{
    private readonly MotorcycleService _motorcycleService = new();
    
    public void Delete(MotorcycleRepository repository)
    {
        Console.WriteLine("Do you want to delete all data from motorcycle? (y/n)");
        var inputAnswerData = Console.ReadKey();
        Log.Information("The user chooses:{KEY} to delete the motorcycle ID", inputAnswerData.Key);

        if (inputAnswerData.Key == ConsoleKey.Y)
        {
            var motorcycleToDelete = _motorcycleService.SelectMotorcycleById();
            if (motorcycleToDelete == null)
            {
                Console.WriteLine("Motorcycle not found.");
                Log.Warning("Motorcycle not found.");
                return;
            }
            
            try
            {
                repository.Delete(motorcycleToDelete);
                Console.WriteLine($"Motorcycle with ID {motorcycleToDelete.Id} deleted.");
                Log.Information("motorcycle with ID {id} deleted.", motorcycleToDelete.Id);
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
        }
    }
}