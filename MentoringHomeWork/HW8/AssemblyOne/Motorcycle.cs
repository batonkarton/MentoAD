namespace AssemblyOne;

public class Motorcycle
{
    public const ushort _UshortmaxSpeed = 300;
    private string _vinNumber = "2zzzs-wed29-43zxcu";
    private int _odometr = 20_000;
    public int _speed = 200;

    protected internal void StartEngine()
    {
        var car = "new";
    }

    public string StopEngine()
    {
        var car = "new";
        Console.WriteLine("stop engine");
        var colorOfMaincar = string.Empty;
        var colorOfSubmarine = string.Empty;
        return colorOfMaincar;
    }

    private protected class MotorcycleEngine
    {
        public void MotorcycleEngineStart()
        {
            Console.WriteLine("MotorcycleEngine");
        }
    }

    internal void MaxSpeed()
    {
        var maxCarSpeed = 200;
    }

    protected internal void LessSpeed()
    {
        var lessCarSpeed = 0;
    }
}