using Serilog;
namespace ConsoleApp1;

public class MotorcycleService : MotorcycleShowInfo
{
    private readonly MotorcycleRepository _repository = new();
    
    public Motorcycle CreateMotorcycleFromUser()
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
            var motoId = Convert.ToInt32(Console.ReadLine());
           
                if (_repository.GetAll().Any(m => m.Id == motoId))
                {
                    Log.Warning("A motorcycle with this ID already exists. Please enter a different ID.");
                }
                else
                {
                    moto.Id = motoId;
                    break;
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

            Console.WriteLine("Invalid input. Year must be more then 1900.");
            Log.Warning("Invalid input{Input}",yearString);
        }

        while (true)
        {
            Console.WriteLine("Enter Motorcycle mileage: ");
            var odometr = Console.ReadLine();
            if (int.TryParse(odometr, out var motoOdometr) && motoOdometr >= 0)
            {
                moto.Mileage = motoOdometr;
                
                break;
            }

            Console.WriteLine("Invalid input. Please enter a valid mileage.");
            Log.Warning("Invalid input {Input}",odometr);
        }
    }

    public void SaveMotorcycle(Motorcycle? motorcycle)
    {
        _repository.Create(motorcycle);
    }

    public Motorcycle? GetMotorcycleById(int id)
    {
        return _repository.GetBYId(id);
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

    public Motorcycle? SelectMotorcycle()
    {
        Console.Write("Enter Motorcycle ID: ");
        var input = Console.ReadLine();

        if (int.TryParse(input, out int id))
        {
            Log.Information("Searching for motorcycle with ID: {ID}", id);

            var motorcycle = _repository.GetBYId(id);
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