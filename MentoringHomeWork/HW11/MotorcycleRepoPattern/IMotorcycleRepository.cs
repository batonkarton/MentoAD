namespace ConsoleApp1;

public interface IMotorcycleRepository
{
    void CreateMotorcycle(Motorcycle? motorcycle1);
    Motorcycle? GetMotorcycleById(int id);
    List<Motorcycle?> GetMotorcycles();
    void UpdateMotorcycle(Motorcycle motorcycle);
    void DeleteMotorcycle(int id);
}