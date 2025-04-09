using Serilog;
namespace ConsoleApp1;

public class MotorcycleService : MotorcycleShowInfo
{
    private readonly MotorcycleRepository _repository = new();
    
    public Motorcycle? CreateMotorcycleFromUser()
    {
        var moto = new Motorcycle();
        ValidateMotorcycleFromUser(moto);
        
        return moto;
    }

    public void AskUserToCreateMotorcycle()
    {
        while (true)
        {
            Console.WriteLine("Do you want to create a new motorcycle? y/n");
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.Y)
            {
                var newMoto = CreateMotorcycleFromUser();
                SaveMotorcycle(newMoto);
                Console.WriteLine("Motorcycle created and saved.");
                Log.Information("Motorcycle created and saved.");
            }
            else break;
            ShowAllInfo(_repository);
        }
    }

    private void ValidateMotorcycleFromUser(Motorcycle moto)
    {
        while (true)
        {
            Console.WriteLine("\n Enter Motorcycle id: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int motoId))
            { 
                if (_repository.GetList().Any(m => m.Id == motoId))
                {
                    Log.Warning("A motorcycle with this ID already exists. Please enter a different ID.");
                }
                else
                {
                    moto.Id = motoId;
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the ID.");
                Log.Warning("Invalid input. Please enter a valid number for the ID.{Input}", input);
            }
        }

        while (true)
        {
            Console.WriteLine("Enter Motorcycle brand: ");
            var brand = Console.ReadLine();
            if (!string.IsNullOrEmpty(brand))
            {
                moto.Brand = brand;
                break;
            }

            Console.WriteLine("Invalid input. Brand cannot be empty.");
            Log.Warning("Invalid input. Brand was empty: {Input}", brand);
        }

        while (true)
        {
            Console.WriteLine("Enter Motorcycle year: ");
            var yearString = Console.ReadLine();
            if (int.TryParse(yearString, out int year) && year >= 1900 && year <= DateTime.Now.Year)
            {
                moto.Year = year;
                break;
            }

            Console.WriteLine("Invalid input. Please enter a valid year.");
            Log.Warning("Invalid input{Input}",yearString);
        }

        while (true)
        {
            Console.WriteLine("Enter Motorcycle mileage: ");
            var odometr = Console.ReadLine();
            if (int.TryParse(odometr, out var motoOd) && motoOd >= 0)
            {
                moto.Mileage = motoOd;
                
                break;
            }

            Console.WriteLine("Invalid input. Please enter a valid mileage.");
            Log.Warning("Invalid input {Input}",odometr);
        }
        ShowAllInfo(_repository);
    }

    public void SaveMotorcycle(Motorcycle? motorcycle)
    {
        _repository.Create(motorcycle);
    }

    public Motorcycle? GetMotorcycleById(int id)
    {
        return _repository.GetId(id);
    }

    public void UpdateMotorcycle(Motorcycle motorcycle)
    {
        var updateService = new MotorcycleUpdateService();
        updateService.Update(_repository);
    }

    public void DeleteMotorcycle(Motorcycle id)
    {
        var deleteService = new MotorcycleDeletedService();
        deleteService.Delete(_repository);
    }

    public Motorcycle? SelectMotorcycle()
    {
        Console.Write("Enter Motorcycle ID: ");
        var input = Console.ReadLine();

        if (int.TryParse(input, out int id))
        {
            Log.Information("Searching for motorcycle with ID: {ID}", id);

            var motorcycle = _repository.GetId(id);
            if (motorcycle != null)
            {
                Log.Information("Motorcycle with ID {ID} found: {Brand}, {Year}, {Mileage}",
                    motorcycle.Id, motorcycle.Brand, motorcycle.Year, motorcycle.Mileage);
                return motorcycle;
            }

            Log.Warning("Motorcycle with ID {ID} not found.", id);
            Console.WriteLine($"Motorcycle with ID {id} not found.");
        }
        else
        {
            Log.Warning("Invalid input for Motorcycle ID: {Input}", input);
            Console.WriteLine("Invalid input.");
        }

        return null;
    }
}