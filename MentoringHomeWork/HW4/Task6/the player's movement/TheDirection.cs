namespace Task6.the_player_s_movement;

public class TheDirection
{
    public void Main()
    {
        Console.WriteLine("Welcome ,lets start snowboarding \ud83c\udfc2");
        Console.WriteLine("Just write finish if you want exit");
        Console.WriteLine("Choose your direction(use 'W,A,S,D')");

        Dirextion();
        void Dirextion()
        {
            var directionA = Console.ReadLine();
        
            if (directionA is "W")
            {
                Console.WriteLine("\u2b06" + "\n \ud83c\udfc2");
                Dirextion();
            }
            else if (directionA is "A")
            {
                Console.WriteLine("\u2b05" + "       \ud83c\udfc2");
                Dirextion();
            } else if (directionA is "S")
            {
                Console.WriteLine("\u2b07" + "\n \ud83c\udfc2");
                Dirextion();
            } else if (directionA is "D")
            {
                Console.WriteLine("\u2b08" + " \ud83c\udfc2     ");
                Dirextion();
            }else if (directionA is "finish")
            {
                Console.WriteLine("goodbye ");
            }
            else
            {
                Console.WriteLine("Please choose your direction");
                Dirextion();
            }
        }
    }
}
