namespace ConsoleApp1;

public interface IMotorcycleRepository
{
    void Create(Motorcycle? motorcycle1);
    Motorcycle? GetId(int id);
    List<Motorcycle?> GetList();
    void Update(Motorcycle motorcycle);
    void Delete(Motorcycle? motorcycle);
}