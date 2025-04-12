namespace ConsoleApp1;

public interface IMotorcycleRepository
{
    void Create(Motorcycle motorcycle1);
    Motorcycle? GetById(int id);
    List<Motorcycle?> GetAll();
    void Update(Motorcycle motorcycle);
    void Delete(Motorcycle motorcycle);
}