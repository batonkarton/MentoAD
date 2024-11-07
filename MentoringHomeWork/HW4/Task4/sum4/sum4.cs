namespace Task4.sum4;

public class Sum4
{
    public void Task4()
    {
        var number = 0;
        var result = 0;
        var number2 = 0;

        Getnumber();
        GetOperator();
        CheckSum();
        return;
        
        void Getnumber()
        {
            Console.WriteLine("Please enter the first number: ");

            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please enter the second number: ");

                if (int.TryParse(Console.ReadLine(), out number2))
                {
                }
                else
                {
                    Console.WriteLine("Error, incorrect input for the second number. Please try again.");
                    Getnumber();
                }
            }
            else
            {
                Console.WriteLine("Error, incorrect input for the first number. Please try again.");
                Getnumber();
            }
        }

        void GetOperator()
        {
            Console.WriteLine("Please choose the operation '+' or '-': ");
            var operat = Console.ReadLine();

            if (operat == "+")
            {
                result = number + number2;
            }
            else if (operat == "-")
            {
                result = number - number2;
            }
            else
            {
                Console.WriteLine("Invalid operation. Please choose '+' or '-'.");
                GetOperator();
            }
        }

        void CheckSum()
        {
            Console.WriteLine("What do you think the sum is? ");
            if (int.TryParse(Console.ReadLine(), out var resultSum))
            {
                if (resultSum < result)
                {
                    Console.WriteLine("There should be more");
                    CheckSum();
                }
                else if (resultSum > result)
                {
                    Console.WriteLine("There should be less");
                    CheckSum();
                }
                else if (result != resultSum)
                {
                    Console.WriteLine("Incorrect, please try again.");
                    CheckSum();
                }
                else
                {
                    Console.WriteLine("Correct! The result is: " + result);
                }
            }
            else
            {
                Console.WriteLine("Error, incorrect input for the sum. Please try again.");
                CheckSum();
            }
        }
    }
}