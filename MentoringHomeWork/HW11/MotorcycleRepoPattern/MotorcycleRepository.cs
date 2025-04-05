namespace ConsoleApp1;

public class MotorcycleRepository : IMotorcycleRepository
{ 
    private List<Motorcycle?> _motorcycles = [];
    
    public void CreateMotorcycle(Motorcycle? motorcycle)
    {
        _motorcycles.Add(motorcycle);
    }

    public Motorcycle? GetMotorcycleById(int id)
    {
        return _motorcycles.FirstOrDefault(m => m.Id == id);
    }

    public List<Motorcycle?> GetMotorcycles()
    {
        return _motorcycles;
    }

    public void UpdateMotorcycle(Motorcycle motorcycle)
    {
        var existingMotorcycle = _motorcycles.FirstOrDefault(m => m.Id == motorcycle.Id);
        if (existingMotorcycle == null) return;
        existingMotorcycle.Brand = motorcycle.Brand;;
        existingMotorcycle.Year = motorcycle.Year;
        existingMotorcycle.Mileage = motorcycle.Mileage;
    }

    public void DeleteMotorcycle(int id)
    {
       var  motorcycle = _motorcycles.FirstOrDefault(m => m.Id == id);
       if (motorcycle != null)
       {
           _motorcycles.Remove(motorcycle);
       }
    }
}