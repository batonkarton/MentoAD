namespace HW._05.Task2;

public class Pyramid
{
    public void Main()
    {
        Console.WriteLine("Please, enter your number (1-100)");

        var getNumber = Convert.ToInt32(Console.ReadLine());
        var workNumber = getNumber;
        string emptySyting = " ";

        for (int i = workNumber; i > 0; i--)
        {
            if (workNumber >= 10)
            {
                workNumber = 10;
            }

            Console.Write(emptySyting);
            for (int j = 0; j <= i; j++)
            {
                if (j <= 0)
                {
                    Console.Write(" ");
                }

                if (j >= workNumber)
                {
                    continue;
                }

                Console.Write(" " + workNumber);
            }

            Console.WriteLine();

            workNumber--;

            Console.Write("    ");
            emptySyting += " ";
        }

        if (workNumber <= 0)
        {
            for (int i = 2; i <= getNumber; i++)
            {
                if (getNumber >= 10)
                {
                    getNumber = 10;
                }

                Console.Write(emptySyting);

                for (int j = 0; j <= i; j++)
                {
                    if (j <= 0)
                    {
                        Console.Write(" ");
                    }

                    if (j >= getNumber)
                    {
                        continue;
                    }

                    Console.Write(" " + getNumber);
                }

                Console.WriteLine();
            }
        }
    }
}