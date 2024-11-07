namespace HW._05.Task2;

public class Pyramid
{
    public void Main()
    {
        Console.WriteLine("Please, enter your number (1-100)");
        var getNumber = Convert.ToInt32(Console.ReadLine());
        for (int i = getNumber; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" " + getNumber + " ");
                
            }

          
            Console.WriteLine();
            getNumber--;
            if (getNumber > 10)
            {
                getNumber = 10;
            }
        }

        }
    }
