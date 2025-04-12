using Serilog;

namespace ConsoleApp1;

public class MotorcycleService : MotorcycleShowInfo
{
    private readonly MotorcycleRepository _repository = new();

    public Motorcycle? AskUserToCreateMotorcycle()
    {
        while (true)
        {
            Console.WriteLine("Do you want to create a new motorcycle? y/n");
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.Y)
            {
                var newMoto = CreateMotorcycleFromUser();
                _repository.Create(newMoto);
                Console.WriteLine("Motorcycle created and saved.");
                Log.Information("Motorcycle created and saved.");

                return newMoto;
            }

            ShowAllInfo(_repository);
            break;
        }

        return null;
    }

    public Motorcycle? GetMotorcycleById(int id)
    {
        return _repository.GetById(id);
    }

    public void UpdateMotorcycle()
    {
        var updateService = new MotorcycleUpdateService();
        updateService.Update(_repository);
    }

    public void DeleteMotorcycle()
    {
        var deleteService = new MotorcycleDeletedService();
        deleteService.Delete(_repository);
    }
    
    private Motorcycle CreateMotorcycleFromUser()
    {
        return ValidateMotoInputFromUser();
    }

    public Motorcycle? SelectMotorcycleById()
    {
        Console.Write("Enter Motorcycle ID: ");
        var input = Console.ReadLine();

        if (int.TryParse(input, out var id))
        {
            Log.Information("Searching for motorcycle with ID: {ID}", id);

            var motorcycle = _repository.GetById(id);
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
    
    private Motorcycle ValidateMotoInputFromUser()
    {
        var motoId = ValidateMotorcycleId();
        var motoBrand = ValidateMotorcycleBrand();
        var motoYear = ValidateMotorcycleYear();
        var motoMileage = ValidateMotorcycleMileage();
        
        return new Motorcycle
        {
            Id = motoId,
            Brand = motoBrand,
            Year = motoYear,
            Mileage = motoMileage
        };
    }

    private static int ValidateMotorcycleMileage()
    {
        while (true)
        {
            Console.WriteLine("Enter Motorcycle mileage: ");
            var odometr = Console.ReadLine();
            if (int.TryParse(odometr, out var motoOdometr) && motoOdometr >= 0)
            {
                return motoOdometr;
            }

            Console.WriteLine("Invalid input. Please enter a valid mileage.");
            Log.Warning("Invalid input {Input}", odometr);
        }
    }

    private static int ValidateMotorcycleYear()
    {
        while (true)
        {
            Console.WriteLine("Enter Motorcycle year: ");
            var yearString = Console.ReadLine();
            if (int.TryParse(yearString, out var year) && year >= 1900 && year <= DateTime.Now.Year)
            {
                return year;
            }

            Console.WriteLine("Invalid input. Year must be more then 1900.");
            Log.Warning("Invalid input{Input}", yearString);
        }
    }

    private string ValidateMotorcycleBrand()
    {
        while (true)
        {
            Console.WriteLine("Enter Motorcycle brand: ");
            var brand = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(brand))
            {
                return brand;
            }

            Console.WriteLine("Invalid input. Brand cannot be empty.");
            Log.Warning("Invalid input. Brand was empty: {Input}", brand);
        }
    }

    private int ValidateMotorcycleId()
    {
        while (true)
        {
            Console.WriteLine("\n Enter Motorcycle id: ");
            var motoId = Convert.ToInt32(Console.ReadLine());

            var motorcycle = _repository.GetById(motoId);
            if (motorcycle is not null)
            {
                Log.Warning("A motorcycle with this ID already exists. Please enter a different ID.");
            }
            else
            {
                return motoId;
            }
        }
    }
}