using AssemblyOne;

public class BikeTask
{
    Motorcycle motor = new Motorcycle();
    public static void Main()
    {
        
        BikeType();
        
    }
    private static void BikeType()
    {
        SportBike sport = new SportBike();
        sport.SportName = "Sport";
    }

    public void StartEngine()
    {
        motor._speed = 100;
        //motor.MotorcycleEngine || MaxSpeed || LessSpeed "I can't use these methods because they have different access modifiers and are not accessible in this build."
        motor.StopEngine();
        
    }
}
