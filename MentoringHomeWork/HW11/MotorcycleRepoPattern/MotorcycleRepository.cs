using Serilog;
namespace ConsoleApp1;

public class MotorcycleRepository : IMotorcycleRepository
{
    private static List<Motorcycle> _motorcycles = [];

    public void Create(Motorcycle? motorcycle)
    {
        _motorcycles.Add(motorcycle);
        
        Log.Information("Motorcycle with ID {ID} added to repository.", motorcycle?.Id);
    }

    public Motorcycle? GetBYId(int id)
    {
        var motorcycle = _motorcycles.FirstOrDefault(m => m.Id == id);
        Log.Information("Searching for motorcycle with ID: {ID}. Found: {Found}", id,
            motorcycle != null ? "Yes" : "No");
        return motorcycle;
    }

    public List<Motorcycle?> GetAll()
    {
        return _motorcycles;
    }

    public void Update(Motorcycle motorcycle)
    {
        var existingMotorcycle = _motorcycles.FirstOrDefault(m => m.Id == motorcycle.Id);

        if (existingMotorcycle != null)
        {
            existingMotorcycle.Brand = motorcycle.Brand;
            existingMotorcycle.Year = motorcycle.Year;
            existingMotorcycle.Mileage = motorcycle.Mileage;

            Log.Information("Motorcycle with ID {ID} updated.", motorcycle.Id);
        }
        else
        {
            Log.Warning("Motorcycle with ID {ID} not found for update.", motorcycle.Id);
        }
    }

    public void Delete(Motorcycle? motorcycle)
    {
        var motorcycleToDelete = _motorcycles.FirstOrDefault(m => m.Id == motorcycle.Id);
        if (motorcycle != null)
        {
            _motorcycles.Remove(motorcycleToDelete);
            Log.Information("Motorcycle with ID {ID} has been removed from repository");
        }
        else throw new Exception("Motorcycle with ID {Motorcycle.id} not found");
    }
}