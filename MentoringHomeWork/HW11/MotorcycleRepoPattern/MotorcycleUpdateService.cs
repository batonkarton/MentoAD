namespace ConsoleApp1;

public class MotorcycleUpdateService(IMotorcycleRepository repo) : MotorcycleShowInfo
{
    private readonly IMotorcycleRepository _repo = repo;

    public void UpdateMotorcycle(Motorcycle? motorcycle)
    {
        Console.WriteLine("Do you want to update the motorcycle (y/n?");
        var inputAnswer = Console.ReadKey();

        if (inputAnswer.Key == ConsoleKey.Y)
        {
            Console.WriteLine("What would you like to update? (id, brand, year, mileage)");
            var inputUpdate = Console.ReadLine()?.ToLower();

            Console.WriteLine($"Enter new value for {inputUpdate}:");
            var newValue = Console.ReadLine();

            switch (inputUpdate)
            {
                case "id":
                    if (int.TryParse(newValue, out int newId))
                        motorcycle.Id = newId;
                    break;
                case "brand":
                    motorcycle.Brand = newValue;
                    break;
                case "year":
                    if (int.TryParse(newValue, out int newYear))
                        motorcycle.Year = newYear;
                    break;
                case "mileage":
                    if (int.TryParse(newValue, out int newMileage))
                        motorcycle.Mileage = newMileage;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            _repo.UpdateMotorcycle(motorcycle);
            Console.WriteLine("Motorcycle updated");
            ShowInfo(motorcycle);
            
            Console.WriteLine("Do you want see all motorcycles? (y/n)");
            var inputSeeAll = Console.ReadKey();

            if (inputSeeAll.Key == ConsoleKey.Y)
            {
                ShowAllInfo(_repo);
            }
            
        }else ShowAllInfo(_repo);
    }
    
   
}