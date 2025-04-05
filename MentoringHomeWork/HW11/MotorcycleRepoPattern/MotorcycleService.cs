using System.Threading.Channels;

namespace ConsoleApp1;

public class MotorcycleService : MotorcycleShowInfo
{
    public Motorcycle? CreateMotorcycleFromUser()
    {
        Motorcycle? moto = new Motorcycle();

        while (true)
        {
            Console.WriteLine("Enter Motorcycle id: ");
            
            var input = Console.ReadLine();
            
            if (int.TryParse(input, out int motoId))
            {
                moto.Id = motoId;
                
                break;
            }

            Console.WriteLine("Invalid input");
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

            Console.WriteLine("Invalid input.Brand cannot be empty");
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

            Console.WriteLine("Invalid input");
        }

        while (true)
        {
            Console.WriteLine("Enter Motorcycle odometer: ");
            var odometr = Console.ReadLine();
            if (int.TryParse(odometr, out int motoOd) && motoOd >= 0)
            {
                moto.Mileage = motoOd;
                
                break;
            }

            Console.WriteLine("Invalid input");
        }
        
        return moto;
    }

    
}
