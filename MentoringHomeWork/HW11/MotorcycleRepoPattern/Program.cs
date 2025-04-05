namespace ConsoleApp1;

public class Program
{
    public static void Main()
    {
        IMotorcycleRepository repo = new MotorcycleRepository();

        var service = new MotorcycleService();
        var newMoto = service.CreateMotorcycleFromUser();
        service.AskUSerShowIfo(newMoto);
        
        repo.CreateMotorcycle(newMoto);
        
        var retrievedMotorcycle = repo.GetMotorcycleById(newMoto.Id);
        Console.WriteLine($"Motorcycle: {retrievedMotorcycle.Brand}, {retrievedMotorcycle.Year}");
        
        MotorcycleUpdateService updateService = new MotorcycleUpdateService(repo);
        updateService.UpdateMotorcycle(newMoto);

        var deleteService = new MotorcycleDeletedService(repo);
        deleteService.DeleteMotorcycle(newMoto);
    }
}