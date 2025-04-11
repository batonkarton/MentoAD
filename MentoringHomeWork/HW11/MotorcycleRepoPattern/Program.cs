using Serilog;

namespace ConsoleApp1;
public class Program
{
    public static void Main()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
        Log.Information("Starting up");
        
        var service = new MotorcycleService();
        
        Log.Information("Created new motorcycle");
        var newMoto = service.CreateMotorcycleFromUser();
        service.SaveMotorcycle(newMoto);

        Log.Information("Get motorcycle by id");
        var retrievedMotorcycle = service.GetMotorcycleById(newMoto?.Id ?? 0);
        Console.WriteLine($"Motorcycle: {retrievedMotorcycle?.Brand}, {retrievedMotorcycle?.Year}");
        
        service.AskUserToCreateMotorcycle();

        Log.Information("Updated new motorcycle with ID: {ID}");
        service.UpdateMotorcycle();
        Log.Information("motorcycle updated");

        Log.Information("deleted motorcycle");
        service.DeleteMotorcycle();
        
        Log.Information("Application finished");
        
        Log.CloseAndFlush();
    }
}