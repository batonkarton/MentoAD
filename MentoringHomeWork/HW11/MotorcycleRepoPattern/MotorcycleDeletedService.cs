namespace ConsoleApp1;

public class MotorcycleDeletedService(IMotorcycleRepository _repo) : MotorcycleShowInfo
{
    MotorcycleService motorcycleService = new MotorcycleService();

    public void DeleteMotorcycle(Motorcycle? motorcycle)
    {
        Console.WriteLine("Do you want to delete all data from motorcycle? (y/n)");
        var inputAnswerData = Console.ReadKey();

        if (inputAnswerData.Key == ConsoleKey.Y)
        {
            _repo.DeleteMotorcycle(motorcycle.Id);
            Console.WriteLine($"Motorcycle with ID {motorcycle.Id} deleted.");
        }
     ShowAllInfo(_repo);
        
    }
    
   
}
